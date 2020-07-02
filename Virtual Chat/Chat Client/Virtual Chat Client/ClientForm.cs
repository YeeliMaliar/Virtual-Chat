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

namespace Virtual_Chat_Client
{
    public partial class ClientForm : Form
    {
        Client me = new Client("127.0.0.1");
        [Obsolete]
        public ClientForm()
        {
            InitializeComponent();
            string confData = me.ClientStart();
            UpdateChatBox(confData);

            Thread listen = new Thread(listenForBroadcaust);
            listen.Start();
          

        }

        private void UpdateChatBox(string msg)
        {
            ChatTextBox.AppendText(msg + Environment.NewLine);
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            string msg = ChatMessageTextBox.Text;
            ChatMessageTextBox.Text = "";
            me.sendToServer(msg);
        }

        private void listenForBroadcaust()
        {
            string msgFromServer = "";
            while (true)
            {
                msgFromServer = me.ListenToServer();
                UpdateChatBox(msgFromServer);
                msgFromServer = "";

            }
        }

    }
    
}

