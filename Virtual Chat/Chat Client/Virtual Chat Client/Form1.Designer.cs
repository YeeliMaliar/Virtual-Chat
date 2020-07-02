namespace Virtual_Chat_Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.SendMessageLabel = new System.Windows.Forms.Label();
            this.SendFileLabel = new System.Windows.Forms.Label();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.FilesLabel = new System.Windows.Forms.Label();
            this.ChatLabel = new System.Windows.Forms.Label();
            this.ChatMessageTextBox = new System.Windows.Forms.TextBox();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IPLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 16;
            this.FilesListBox.Location = new System.Drawing.Point(456, 101);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(139, 308);
            this.FilesListBox.TabIndex = 54;
            // 
            // SendMessageLabel
            // 
            this.SendMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendMessageLabel.AutoSize = true;
            this.SendMessageLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SendMessageLabel.Location = new System.Drawing.Point(780, 223);
            this.SendMessageLabel.Name = "SendMessageLabel";
            this.SendMessageLabel.Size = new System.Drawing.Size(96, 18);
            this.SendMessageLabel.TabIndex = 53;
            this.SendMessageLabel.Text = ":שליחת הודעה";
            // 
            // SendFileLabel
            // 
            this.SendFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendFileLabel.AutoSize = true;
            this.SendFileLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SendFileLabel.Location = new System.Drawing.Point(791, 109);
            this.SendFileLabel.Name = "SendFileLabel";
            this.SendFileLabel.Size = new System.Drawing.Size(85, 18);
            this.SendFileLabel.TabIndex = 52;
            this.SendFileLabel.Text = ":שליחת קובץ";
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseFileButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ChooseFileButton.Enabled = false;
            this.ChooseFileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChooseFileButton.Location = new System.Drawing.Point(691, 147);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(101, 32);
            this.ChooseFileButton.TabIndex = 51;
            this.ChooseFileButton.Text = "בחירת קובץ";
            this.ChooseFileButton.UseVisualStyleBackColor = false;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendMessageButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SendMessageButton.Enabled = false;
            this.SendMessageButton.Location = new System.Drawing.Point(691, 301);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(101, 30);
            this.SendMessageButton.TabIndex = 50;
            this.SendMessageButton.Text = "שליחה";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click_1);
            // 
            // FilesLabel
            // 
            this.FilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesLabel.AutoSize = true;
            this.FilesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FilesLabel.Location = new System.Drawing.Point(548, 70);
            this.FilesLabel.Name = "FilesLabel";
            this.FilesLabel.Size = new System.Drawing.Size(47, 18);
            this.FilesLabel.TabIndex = 49;
            this.FilesLabel.Text = "קבצים";
            // 
            // ChatLabel
            // 
            this.ChatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatLabel.AutoSize = true;
            this.ChatLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChatLabel.Location = new System.Drawing.Point(384, 70);
            this.ChatLabel.Name = "ChatLabel";
            this.ChatLabel.Size = new System.Drawing.Size(37, 18);
            this.ChatLabel.TabIndex = 48;
            this.ChatLabel.Text = "צ\'אט";
            // 
            // ChatMessageTextBox
            // 
            this.ChatMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatMessageTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChatMessageTextBox.Location = new System.Drawing.Point(614, 258);
            this.ChatMessageTextBox.Name = "ChatMessageTextBox";
            this.ChatMessageTextBox.Size = new System.Drawing.Size(256, 23);
            this.ChatMessageTextBox.TabIndex = 47;
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ChatTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChatTextBox.ForeColor = System.Drawing.Color.Black;
            this.ChatTextBox.HideSelection = false;
            this.ChatTextBox.Location = new System.Drawing.Point(12, 101);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChatTextBox.Size = new System.Drawing.Size(424, 348);
            this.ChatTextBox.TabIndex = 46;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DownloadButton.Enabled = false;
            this.DownloadButton.Location = new System.Drawing.Point(456, 421);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(139, 30);
            this.DownloadButton.TabIndex = 55;
            this.DownloadButton.Text = "הורד קובץ";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IPTextBox.Location = new System.Drawing.Point(181, 23);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(503, 23);
            this.IPTextBox.TabIndex = 56;
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ConnectButton.Location = new System.Drawing.Point(42, 18);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(105, 34);
            this.ConnectButton.TabIndex = 57;
            this.ConnectButton.Text = "התחבר";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IPLabel
            // 
            this.IPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.Location = new System.Drawing.Point(711, 24);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(138, 18);
            this.IPLabel.TabIndex = 58;
            this.IPLabel.Text = ":של השרת  IP כתובת";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Json files (*.json)|*.json|XML Files (*.xml)|*.xml";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.SendMessageLabel);
            this.Controls.Add(this.SendFileLabel);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.FilesLabel);
            this.Controls.Add(this.ChatLabel);
            this.Controls.Add(this.ChatMessageTextBox);
            this.Controls.Add(this.ChatTextBox);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "ClientForm";
            this.Text = "Virtual Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Label SendMessageLabel;
        private System.Windows.Forms.Label SendFileLabel;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Label FilesLabel;
        private System.Windows.Forms.Label ChatLabel;
        private System.Windows.Forms.TextBox ChatMessageTextBox;
        private System.Windows.Forms.TextBox ChatTextBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

