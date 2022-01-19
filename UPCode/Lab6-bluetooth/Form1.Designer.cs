
namespace Lab6_bluetooth
{
    partial class Form1
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
            this.labelDiscoverDevices = new System.Windows.Forms.Label();
            this.labelConnection = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonDiscoverDevices = new System.Windows.Forms.Button();
            this.listBoxDiscoveredDevices = new System.Windows.Forms.ListBox();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.listBoxConnected = new System.Windows.Forms.ListBox();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSelectedFile = new System.Windows.Forms.TextBox();
            this.buttonShowConnectors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDiscoverDevices
            // 
            this.labelDiscoverDevices.AutoSize = true;
            this.labelDiscoverDevices.Location = new System.Drawing.Point(9, 88);
            this.labelDiscoverDevices.Name = "labelDiscoverDevices";
            this.labelDiscoverDevices.Size = new System.Drawing.Size(101, 13);
            this.labelDiscoverDevices.TabIndex = 0;
            this.labelDiscoverDevices.Text = "Discovered devices";
            // 
            // labelConnection
            // 
            this.labelConnection.AutoSize = true;
            this.labelConnection.Location = new System.Drawing.Point(9, 216);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(81, 13);
            this.labelConnection.TabIndex = 1;
            this.labelConnection.Text = "Connected with";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(9, 399);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(25, 13);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Info";
            // 
            // buttonDiscoverDevices
            // 
            this.buttonDiscoverDevices.Location = new System.Drawing.Point(116, 78);
            this.buttonDiscoverDevices.Name = "buttonDiscoverDevices";
            this.buttonDiscoverDevices.Size = new System.Drawing.Size(131, 23);
            this.buttonDiscoverDevices.TabIndex = 3;
            this.buttonDiscoverDevices.Text = "Discover devices";
            this.buttonDiscoverDevices.UseVisualStyleBackColor = true;
            this.buttonDiscoverDevices.Click += new System.EventHandler(this.buttonDiscoverDevices_Click);
            // 
            // listBoxDiscoveredDevices
            // 
            this.listBoxDiscoveredDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxDiscoveredDevices.FormattingEnabled = true;
            this.listBoxDiscoveredDevices.Location = new System.Drawing.Point(9, 107);
            this.listBoxDiscoveredDevices.Name = "listBoxDiscoveredDevices";
            this.listBoxDiscoveredDevices.Size = new System.Drawing.Size(238, 93);
            this.listBoxDiscoveredDevices.TabIndex = 4;
            this.listBoxDiscoveredDevices.Tag = "";
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(116, 206);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(131, 23);
            this.buttonConnection.TabIndex = 5;
            this.buttonConnection.Text = "Connect";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // listBoxConnected
            // 
            this.listBoxConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxConnected.FormattingEnabled = true;
            this.listBoxConnected.Location = new System.Drawing.Point(9, 235);
            this.listBoxConnected.Name = "listBoxConnected";
            this.listBoxConnected.Size = new System.Drawing.Size(238, 93);
            this.listBoxConnected.TabIndex = 6;
            this.listBoxConnected.Tag = "";
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(12, 418);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(238, 231);
            this.richTextBoxInfo.TabIndex = 7;
            this.richTextBoxInfo.Text = "";
            this.richTextBoxInfo.TextChanged += new System.EventHandler(this.richTextBoxInfo_TextChanged);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(9, 334);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(119, 23);
            this.buttonSelectFile.TabIndex = 8;
            this.buttonSelectFile.Text = "Select file";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(134, 334);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(113, 23);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSelectedFile
            // 
            this.textBoxSelectedFile.Location = new System.Drawing.Point(9, 363);
            this.textBoxSelectedFile.Name = "textBoxSelectedFile";
            this.textBoxSelectedFile.ReadOnly = true;
            this.textBoxSelectedFile.Size = new System.Drawing.Size(238, 20);
            this.textBoxSelectedFile.TabIndex = 10;
            this.textBoxSelectedFile.Text = "No file selected";
            // 
            // buttonShowConnectors
            // 
            this.buttonShowConnectors.Location = new System.Drawing.Point(116, 49);
            this.buttonShowConnectors.Name = "buttonShowConnectors";
            this.buttonShowConnectors.Size = new System.Drawing.Size(131, 23);
            this.buttonShowConnectors.TabIndex = 11;
            this.buttonShowConnectors.Text = "Show connectors";
            this.buttonShowConnectors.UseVisualStyleBackColor = true;
            this.buttonShowConnectors.Click += new System.EventHandler(this.buttonShowConnectors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 661);
            this.Controls.Add(this.buttonShowConnectors);
            this.Controls.Add(this.textBoxSelectedFile);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.listBoxConnected);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.listBoxDiscoveredDevices);
            this.Controls.Add(this.buttonDiscoverDevices);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.labelDiscoverDevices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDiscoverDevices;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonDiscoverDevices;
        private System.Windows.Forms.ListBox listBoxDiscoveredDevices;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.ListBox listBoxConnected;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSelectedFile;
        private System.Windows.Forms.Button buttonShowConnectors;
    }
}

