using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;


namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ProcessRepositories().Wait();

/*             try
            {
                var repositories = ProcessRepositories().Result;
                
                foreach (var repo in repositories)
                {
                    Console.WriteLine(repo.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            } */

        }

        // Method using HttpClient
        //private static async Task<List<Repository>> ProcessRepositories()
        private static async Task ProcessRepositories()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<Repository>));
            
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            //var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            //var url = "https://youtube.com"; // To test only
            var url = "https://api.github.com/orgs/dotnet/repos";

            /*var stringTask = client.GetStringAsync(url);
            var msg = await stringTask;
            Console.WriteLine(msg); 
            */           

            try
            {
                var streamTask = client.GetStreamAsync(url);
                var repositories = serializer.ReadObject(await streamTask) as List<Repository>;

                //return repositories;
                foreach (var repo in repositories)
                {
                    Console.WriteLine(repo.Name);
                    Console.WriteLine(repo.Description);
                    Console.WriteLine(repo.GitHubHomeUrl);
                    Console.WriteLine(repo.Homepage);
                    Console.WriteLine(repo.Watchers);
                    Console.WriteLine(repo.LastPush);
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {   
                Console.WriteLine(e.ToString());
            }

        }


    }
}
