using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Virtual_Chat_Client
{
    public partial class ClientForm : Form
    {
        // Create a new client, thats me!
        Client me = new Client();

        public ClientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Update the Chat TextBox
        /// </summary>
        /// <param name="msg">Message to add</param>
        private void UpdateChatBox(string msg)
        {
            if (InvokeRequired) // handle if on a different thread.
            {
                this.Invoke(new Action<string>(UpdateChatBox), new object[] { msg });
                return;
            }
            ChatTextBox.AppendText( ">> " + msg + Environment.NewLine);
        }


        /// <summary>
        /// Update the File ListBox
        /// </summary>
        /// <param name="txt">Item to add</param>
        private void UpdateListBox(string txt)
        {
            if (InvokeRequired)  // handle if on a different thread.
            {
                this.Invoke(new Action<string>(UpdateListBox), new object[] { txt });
                return;
            }
            string fileName = txt.Substring(8);
            if (!FilesListBox.Items.Contains(fileName)) // add only if it is new
            {
                FilesListBox.Items.Add(fileName);
            }
        }


        /// <summary>
        /// Choose where and under what name to download the file
        /// </summary>
        /// <param name="file">The file's contant</param>
        private void DownloadFile(string file)
        {
            if (InvokeRequired) // handle if on a different thread.
            {
                this.Invoke(new Action<string>(DownloadFile), new object[] { file });
                return;
            }
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) // open the browser
            {
                byte[] bytes = Encoding.ASCII.GetBytes(file);
                string path = saveFileDialog1.FileName;
                File.WriteAllText(path, file);
            }
        }


        /// <summary>
        /// Connect to the server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string serverIP = IPTextBox.Text;
            me.ConnectToServer(serverIP);
            // disable button
            ConnectButton.Enabled = false;
            IPTextBox.ReadOnly = true;
            // enable buttons
            ChooseFileButton.Enabled = true;
            SendMessageButton.Enabled = true;
            DownloadButton.Enabled = true;
            Thread listenToServer = new Thread(TextLoop);
            Thread listenToServerFile = new Thread(FileLoop);
            listenToServer.Start();
            listenToServerFile.Start();
        }


        /// <summary>
        /// A loop to receive and handle text messages.
        /// </summary>
        private void TextLoop()
        {
            while (true)
            {
                me.SendMessage("");
                string msg = me.ReceiveResponseText();
                if (msg != "")
                {
                    UpdateChatBox(msg);
                }
                
            }
        }


        /// <summary>
        /// A loop to receive and handle files.
        /// </summary>
        private void FileLoop()
        {
            while (true)
            {
                string fileData = me.ReceiveResponseFile();
                if (fileData.StartsWith("<update>"))
                {
                    UpdateListBox(fileData);
                }
                else
                {
                    DownloadFile(fileData);
                }
            }
        }


        /// <summary>
        /// Send a message to the server, clear the Chat Message Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendMessageButton_Click_1(object sender, EventArgs e)
        {
            string msg = ChatMessageTextBox.Text;
            ChatMessageTextBox.Text = "";
            me.SendMessage(msg);
        }


        /// <summary>
        /// When the form close, do in with Grace!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    me.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }


        /// <summary>
        /// Select a file and send it to the server.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                me.SendFile(filePath);
            }
        }


        /// <summary>
        /// Send a download requst to the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (FilesListBox.SelectedIndex != -1)
            {
                string curItem = FilesListBox.SelectedItem.ToString();
                me.SendFile("<req>" + curItem);
            }
        }
    }
}
