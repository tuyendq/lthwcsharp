/**
* Source: https://rosettacode.org/wiki/Hello_world/Web_server
*/
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace WebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string msg = "<html><body>Hello from C#, a simple web server.</body></html>";
            const int port = 8080;
            bool serverRunning = true;

            TcpListener tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();

            while (serverRunning)
            {
                Socket socketConnection = tcpListener.AcceptSocket();
                byte[] bMsg = Encoding.ASCII.GetBytes(msg.ToCharArray(), 0, (int)msg.Length);
                socketConnection.Send(bMsg);
                socketConnection.Disconnect(true);
            }
        }
    }
}
