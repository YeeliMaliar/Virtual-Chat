using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Virtual_Chat_Client
{
    class Client
    {
        // Entery:
        private IPHostEntry ipServerInfo { get; set; }
        private IPHostEntry ipHostInfo { get; set; }

        // Client Sockets:
        private readonly Socket ClientTextSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private readonly Socket ClientFileSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // Constant Variables:
        private const int TEXTPORT = 8080;
        private const int FILEPORT = 8081;

        /// <summary>
        /// Create a new client object, sets the HostEntery
        /// </summary>
        /// <param name="serverIP"></param>
        public Client()
        {
            this.ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
        }

        /// <summary>
        /// Send a txt message to the server.
        /// </summary>
        /// <param name="text"></param>
        public void SendMessage(string text)
        {
            try
            {
                if (text.ToLower() == "exit")
                {
                    Exit();
                }
                else
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(text);
                    ClientTextSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // -------------------------------------------------------------------------------------------------
                if (ex.Message.ToLower() == "an existing connection was forcibly closed by the remote host")
                {
                    Exit();
                }
            }

        }

        /// <summary>
        /// Send a file or a download request to the server.
        /// fileName = The name of the file requested + "<req>" or the path to the file sent
        /// </summary>
        /// <param name="fileName"></param>
        public void SendFile(string fileName)
        {
            if (fileName.StartsWith("<req>"))
            {
                byte[] bytes = Encoding.ASCII.GetBytes(fileName); 
                ClientFileSocket.Send(bytes);
            }
            else
            {
                byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
                byte[] fileData = File.ReadAllBytes(fileName);
                byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];

                fileNameLen.CopyTo(clientData, 0);
                fileNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fileNameByte.Length);
                ClientFileSocket.Send(clientData);
            }
            
        }

        /// <summary>
        /// Connect both the Text and the file sockets to the server.
        /// </summary>
        /// <param name="serverIP"></param>
        [Obsolete]
        public void ConnectToServer(string serverIP)
        {
            this.ipServerInfo = Dns.GetHostEntry(serverIP);
            int attempts = 0;

            while (!ClientTextSocket.Connected)
            {
                try
                {
                    attempts++;
                    ClientTextSocket.Connect(serverIP, TEXTPORT);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Connection attempt " + attempts);
                }
            }

            while (!ClientFileSocket.Connected)
            {
                try
                {
                    attempts++;
                    ClientFileSocket.Connect(serverIP, FILEPORT);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Connection attempt " + attempts);
                }
            }
        }

        /// <summary>
        /// Close both text and file sockets and acknowledge the server
        /// </summary>
        public void Exit()
        {
            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes("exit");

                ClientTextSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                ClientTextSocket.Shutdown(SocketShutdown.Both);
                ClientTextSocket.Close();

                ClientFileSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                ClientFileSocket.Shutdown(SocketShutdown.Both);
                ClientFileSocket.Close();

                Environment.Exit(0);
            }
            catch
            {
                // if the client was not connected to the socket
            }
        }

        /// <summary>
        /// Get a Text message from the server.
        /// </summary>
        /// <returns>The text message</returns>
        public string ReceiveResponseText()
        {
            var buffer = new byte[2048];
            try
            {
                if (buffer.ToString().Length == 2048) return "message too long";
                int received = ClientTextSocket.Receive(buffer, SocketFlags.None);
                if (received == 0) return "";
                var data = new byte[received];
                Array.Copy(buffer, data, received);
                string text = Encoding.ASCII.GetString(data);
                return text;
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Get a File or a listbox update from the server.
        /// </summary>
        /// <returns>the file or the message.</returns>
        public string ReceiveResponseFile()
        {
            byte[] clientData = new byte[1024000];
            try
            {
                int receivedBytesLen = ClientFileSocket.Receive(clientData, SocketFlags.None);
                int fileNameLen = BitConverter.ToInt32(clientData, 0);
                if (!Encoding.ASCII.GetString(clientData).StartsWith("<update>"))
                {
                    string fileData = Encoding.ASCII.GetString(clientData, fileNameLen + 4, clientData.Length);
                    return fileData;
                }
                else
                {
                    //return the message
                    return Encoding.ASCII.GetString(clientData);
                }
            }
            catch
            {
                return "";
            }
        }
    }

}
