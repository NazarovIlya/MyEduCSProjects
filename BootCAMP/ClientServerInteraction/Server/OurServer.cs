using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    public class OurServer
    {
        TcpListener server;
        public OurServer()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555);
            server.Start();
            LoopClients();
        }
        void LoopClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Thread thread = new Thread(() => HandleClient(client));
                thread.Start();
            }
        }
        void HandleClient(TcpClient client)
        {
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8);
            while (true)
            {
                string msg = sReader.ReadLine();
                Console.WriteLine($"Client wrote {msg}");
            }
        }
    }
}