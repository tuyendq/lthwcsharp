/**
* Source: https://docs.microsoft.com/en-us/dotnet/api/system.net.sockets.tcplistener?view=netcore-3.0
*/
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace MyTcpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TcpListener!");

            TcpListener server = null;

            try {
                // Set TcpListener port
                Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port)
                server = new TcpListener(localAddr, port);

                // Start listening for client requests
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop
                while(true) {
                    System.Console.WriteLine("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AccessSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    System.Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0) {
                        // Translate data bytes to a ASCII string
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        System.Console.WriteLine("Received: {0}", data);

                        // Process the data sent by the client.
                        data = data.ToUpper();

                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                        // Senb back a response.
                        stream.Write(msg, 0, msg.Length);
                        System.Console.WriteLine("Send: {0}", data);
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e) {
                System.Console.WriteLine("SocketException: {0}", e);
            }
            finally {
                // Stop listening for new clients
                server.Stop();
            }

            Console.WriteLine("\nHit ENTER to continue...");
            Console.Read();

        }
    }
}
