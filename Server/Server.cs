using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Server
{
    class Server
    {
    public static void Main(string[] args)
        {
            TcpListener server = new TcpListener(8888);
            server.Start();
            Console.WriteLine("waiting for client");
            Socket socketForClients = server.AcceptSocket();

            if (socketForClients.Connected)
            {
                NetworkStream ns = new NetworkStream(socketForClients);
                StreamWriter sw = new StreamWriter(ns);
                Console.WriteLine("server > welcome client");
                sw.WriteLine("welcome client");
                sw.WriteLine("hi client");
                sw.Flush();
                /*StreamReader sr = new StreamReader(ns);
                Console.WriteLine("client >" + sr.ReadLine());*/
                sw.Close();
                ns.Close();
            }
            socketForClients.Close();

        }
    }
}
