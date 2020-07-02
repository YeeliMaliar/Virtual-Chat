using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.IO;

namespace Virtual_Chat_Server
{
    class Server
    {
        private IPHostEntry ipHostInfo { get; set; }
        public Hashtable FileList = new Hashtable();

        // Sockets:
        private static readonly Socket serverSocketText = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly Socket serverSocketFile = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // Lists of sockets:
        private static readonly List<Socket> clientTextSockets = new List<Socket>();
        private static readonly List<Socket> clientFileSockets = new List<Socket>();

        // Permanent Variables:
        private const int TEXT_BUFFER_SIZE = 2048;
        private const int FILE_BUFFER_SIZE = 1024000;
        private const int TEXTPORT = 8080;
        private const int FILEPORT = 8081;

        // Buffers:
        private static readonly byte[] textBuffer = new byte[TEXT_BUFFER_SIZE];
        private static readonly byte[] fileBuffer = new byte[FILE_BUFFER_SIZE];


        /// <summary>
        /// Create an new server item with a host entery of this machine.
        /// </summary>
        public Server()
        {
            this.ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        }


        /// <summary>
        /// Start the new server, listens for both file sockets and text sockets.
        /// </summary>
        public void ServerStart()
        {
            Console.WriteLine("Setting up server...");
            // set up text messages
            serverSocketText.Bind(new IPEndPoint(IPAddress.Any, TEXTPORT));
            serverSocketText.Listen(0);
            serverSocketText.BeginAccept(AcceptCallbackText, null);
            // set up files
            serverSocketFile.Bind(new IPEndPoint(IPAddress.Any, FILEPORT));
            serverSocketFile.Listen(0);
            serverSocketFile.BeginAccept(AcceptCallbackFile, null);
            // all done!
            Console.WriteLine("Server setup complete");
        }


        /// <summary>
        /// Listen for new connections for text sockets. adds the sockets to clientTextSockets.
        /// </summary>
        /// <param name="AR"></param>
        private static void AcceptCallbackText(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocketText.EndAccept(AR);
            }
            catch (ObjectDisposedException)
            {
                return;
            }
            clientTextSockets.Add(socket);
            socket.BeginReceive(textBuffer, 0, TEXT_BUFFER_SIZE, SocketFlags.None, ReceiveTextCallback, socket);
            Console.WriteLine("{0}", socket.RemoteEndPoint + " connected...");
            //do it again:
            serverSocketText.BeginAccept(AcceptCallbackText, null);
        }


        /// <summary>
        /// Listen for new connections for File sockets. adds the sockets to clientFileSockets.
        /// </summary>
        /// <param name="AR"></param>
        private static void AcceptCallbackFile(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocketFile.EndAccept(AR);
            }
            catch (ObjectDisposedException)
            {
                return;
            }
            clientFileSockets.Add(socket);
            socket.BeginReceive(fileBuffer, 0, FILE_BUFFER_SIZE, SocketFlags.None, ReceiveFileCallback, socket);
            //do it again:
            serverSocketFile.BeginAccept(AcceptCallbackFile, null);
        }


        /// <summary>
        /// Handles the client's text messages.
        /// </summary>
        /// <param name="AR"></param>
        private static void ReceiveTextCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Client forcefully disconnected");
                current.Close();
                clientTextSockets.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(textBuffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            if (text != "")
            {
                if (text.ToLower() == "exit") // Client wants to exit gracefully
                {
                    Console.WriteLine(current.RemoteEndPoint + " disconnected");
                    current.Shutdown(SocketShutdown.Both);
                    current.Close();
                    clientTextSockets.Remove(current);
                    return;
                }
                else
                {
                    Console.WriteLine("Received Text: " + text);
                    foreach (Socket socket in clientTextSockets)
                    {
                        byte[] data = Encoding.ASCII.GetBytes(text);
                        socket.Send(data);

                    }
                    Console.WriteLine("Message was sent to all");
                }
            }
            // do it again:
            current.BeginReceive(textBuffer, 0, TEXT_BUFFER_SIZE, SocketFlags.None, ReceiveTextCallback, current);
        }


        /// <summary>
        /// Handles the client's File requests.
        /// </summary>
        /// <param name="AR"></param>
        private static void ReceiveFileCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                current.Close();
                clientFileSockets.Remove(current);
                return;
            }
            
            byte[] recBuf = new byte[received];
            Array.Copy(fileBuffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            if (text == "exit")
            {
                current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientFileSockets.Remove(current);
                return;
            }
            else if (text.StartsWith("<req>"))
            {
                text = text.Substring(5);// delete the req part
                string newPath = @"Files\" + text;

                if (File.Exists(newPath))
                {

                    byte[] fileNameByte = Encoding.ASCII.GetBytes(newPath);
                    byte[] fileNameLenbyte = BitConverter.GetBytes(fileNameByte.Length);
                    byte[] fileData = File.ReadAllBytes(newPath);
                    byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];

                    fileNameLenbyte.CopyTo(clientData, 0);
                    fileNameByte.CopyTo(clientData, 4);
                    fileData.CopyTo(clientData, 4 + fileNameByte.Length);

                    // send to client
                    current.Send(clientData);
                }
                else
                {
                    byte[] clientData = Encoding.ASCII.GetBytes("error");
                    current.Send(clientData);
                }
            }
            else
            {
                Console.WriteLine("getting file....");
                int receivedBytesLen = received;
                int fileNameLen = BitConverter.ToInt32(recBuf, 0);


                string path = @"Files\";

                string fileOldPath = Encoding.ASCII.GetString(recBuf, 4, fileNameLen);

                string fileName = Path.GetFileName(fileOldPath);
                string newPath = path + fileName;

                BinaryWriter bWrite = new BinaryWriter(File.Open(newPath, FileMode.Create));
                bWrite.Write(recBuf, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);
                bWrite.Close();

                //[0]filenamelen[4]filenamebyte[*]filedata   

                Console.WriteLine("Received File: " + fileName);

                foreach (Socket socket in clientFileSockets)
                {
                    byte[] data = Encoding.ASCII.GetBytes("<update>" + fileName);
                    socket.Send(data);
                }
            }
            // do it again:
            current.BeginReceive(fileBuffer, 0, FILE_BUFFER_SIZE, SocketFlags.None, ReceiveFileCallback, current); 


        }


        /// <summary>
        /// Close all the sockets in clientTextSocket, then close serverSocketText.
        /// </summary>
        public void CloseAllSocketsText()
        {
            foreach (Socket socket in clientTextSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            serverSocketText.Close();
        }


        /// <summary>
        /// Close all the sockets in clientFileSocket, then close serverSocketFile.
        /// </summary>
        public void CloseAllSocketsFile()
        {
            foreach (Socket socket in clientFileSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            serverSocketFile.Close();
        }

    }//End of class Server

}
