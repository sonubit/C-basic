using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    class Client
    { 
        
        public static void Main(string[] args)
        {
            TcpClient client = new TcpClient("localhost", 8888);
            NetworkStream ns = client.GetStream();
            StreamReader sr = new StreamReader(ns);
            Console.WriteLine("server ");
            Console.WriteLine("server >" +sr.ReadToEnd());
            /*StreamWriter sw = new StreamWriter(ns);
            Console.WriteLine("text something here");
            sw.WriteLine("Console.ReadLine()");
            sw.Flush();*/
            Console.ReadLine();
        }
    }
}
