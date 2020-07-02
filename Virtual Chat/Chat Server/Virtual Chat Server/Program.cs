using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Virtual_Chat_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Server";
            Server server = new Server();
            server.ServerStart();
            while (Console.ReadKey().Key != ConsoleKey.Q) {} // press Q to close the server
            server.CloseAllSocketsFile();
            server.CloseAllSocketsText();
        }
    }

}
