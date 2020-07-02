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
            this.SuspendLayout();
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 16;
            this.FilesListBox.Location = new System.Drawing.Point(286, 47);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(106, 196);
            this.FilesListBox.TabIndex = 45;
            // 
            // SendMessageLabel
            // 
            this.SendMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendMessageLabel.AutoSize = true;
            this.SendMessageLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SendMessageLabel.Location = new System.Drawing.Point(530, 111);
            this.SendMessageLabel.Name = "SendMessageLabel";
            this.SendMessageLabel.Size = new System.Drawing.Size(92, 18);
            this.SendMessageLabel.TabIndex = 44;
            this.SendMessageLabel.Text = "שליחת הודעה";
            // 
            // SendFileLabel
            // 
            this.SendFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendFileLabel.AutoSize = true;
            this.SendFileLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SendFileLabel.Location = new System.Drawing.Point(541, 16);
            this.SendFileLabel.Name = "SendFileLabel";
            this.SendFileLabel.Size = new System.Drawing.Size(81, 18);
            this.SendFileLabel.TabIndex = 43;
            this.SendFileLabel.Text = "שליחת קובץ";
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseFileButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ChooseFileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChooseFileButton.Location = new System.Drawing.Point(464, 51);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(112, 32);
            this.ChooseFileButton.TabIndex = 42;
            this.ChooseFileButton.Text = "בחירת קובץ";
            this.ChooseFileButton.UseVisualStyleBackColor = false;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendMessageButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SendMessageButton.Location = new System.Drawing.Point(469, 185);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(101, 30);
            this.SendMessageButton.TabIndex = 41;
            this.SendMessageButton.Text = "שליחה";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // FilesLabel
            // 
            this.FilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesLabel.AutoSize = true;
            this.FilesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FilesLabel.Location = new System.Drawing.Point(345, 16);
            this.FilesLabel.Name = "FilesLabel";
            this.FilesLabel.Size = new System.Drawing.Size(47, 18);
            this.FilesLabel.TabIndex = 40;
            this.FilesLabel.Text = "קבצים";
            // 
            // ChatLabel
            // 
            this.ChatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatLabel.AutoSize = true;
            this.ChatLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChatLabel.Location = new System.Drawing.Point(210, 16);
            this.ChatLabel.Name = "ChatLabel";
            this.ChatLabel.Size = new System.Drawing.Size(37, 18);
            this.ChatLabel.TabIndex = 39;
            this.ChatLabel.Text = "צ\'אט";
            // 
            // ChatMessageTextBox
            // 
            this.ChatMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatMessageTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChatMessageTextBox.Location = new System.Drawing.Point(420, 146);
            this.ChatMessageTextBox.Name = "ChatMessageTextBox";
            this.ChatMessageTextBox.Size = new System.Drawing.Size(200, 23);
            this.ChatMessageTextBox.TabIndex = 38;
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
            this.ChatTextBox.Location = new System.Drawing.Point(12, 47);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChatTextBox.Size = new System.Drawing.Size(252, 198);
            this.ChatTextBox.TabIndex = 37;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.SendMessageLabel);
            this.Controls.Add(this.SendFileLabel);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.FilesLabel);
            this.Controls.Add(this.ChatLabel);
            this.Controls.Add(this.ChatMessageTextBox);
            this.Controls.Add(this.ChatTextBox);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "ClientForm";
            this.Text = "Virtual Chat";
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
    }
}

