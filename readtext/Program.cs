using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace readtext
{
    class Program
    {
        public static void Main(string[] args)
        {
            RunTeleprompter().Wait();
        }
        // ReadFrom method
        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    // Return whole line
                    // yield return line;
                    
                    // Return word by word
                    var words = line.Split(' ');
                    var lineLength = 0;
                    foreach (var word in words)
                    {
                        yield return word + " ";
                        lineLength += word.Length + 1;
                        if (lineLength > 70)
                        {
                            yield return Environment.NewLine;
                            lineLength = 0;
                        }
                    }
                
                    yield return Environment.NewLine;
                }
            }
        }

        // Asynchronous Task
        private static async Task ShowTeleprompter(TelePrompterConfig config)
        {
            try
            {
                var filename = "sampleQuotes.txt";
                var words = ReadFrom(filename);
                foreach (var line in words)
                {
                    Console.Write(line);
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        await Task.Delay(config.DelayInMilliseconds);
                    }
                }
                config.SetDone();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        // GetInput() Task
        private static async Task GetInput(TelePrompterConfig config)
        {
            //var delay = 200;
            Action work = () =>
            {
                do {
                    var key = Console.ReadKey(true);
                    if (key.KeyChar == '>')
                    {
                        //delay -= 10;
                        config.UpdateDelay(-10);
                    }
                    else if (key.KeyChar == '<')
                    {
                        //delay +=10;
                        config.UpdateDelay(10);
                    }
                } while (!config.Done); //while (true);
            };
            await Task.Run(work);
        }

        private static async Task RunTeleprompter()
        {
            var config = new TelePrompterConfig();
            var displayTask = ShowTeleprompter(config);

            var speedTask = GetInput(config);
            await Task.WhenAny(displayTask, speedTask);
        }

    }
}
