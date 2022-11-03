using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public class OurClient
    {
        private TcpClient client;
        StreamWriter sWriter;

        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555);
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);
            HandleCommunication();
        }
        void HandleCommunication()
        {
            while (true)
            {
                Console.WriteLine("> ");
                string? msg = Console.ReadLine();
                sWriter.WriteLine(msg);
                sWriter.Flush();
            }
        }
    }
}