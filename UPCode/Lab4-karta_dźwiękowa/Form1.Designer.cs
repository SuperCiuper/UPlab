namespace Lab4_karta_dźwiękowa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.listBoxFileInfo = new System.Windows.Forms.ListBox();
            this.labelRecording = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.radioButtonDirectSound = new System.Windows.Forms.RadioButton();
            this.radioButtonWaveOut = new System.Windows.Forms.RadioButton();
            this.radioButtonMediaPlayer = new System.Windows.Forms.RadioButton();
            this.radioButtonSoundPlayer = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.listBoxMicrophones = new System.Windows.Forms.ListBox();
            this.buttonFindDevice = new System.Windows.Forms.Button();
            this.labelSelectDevice = new System.Windows.Forms.Label();
            this.labelSaveFilePath = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            this.buttonFile.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFile.Location = new System.Drawing.Point(15, 37);
            this.buttonFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(210, 54);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "Select File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlay.Location = new System.Drawing.Point(15, 100);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(210, 54);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFilePath.Location = new System.Drawing.Point(10, 420);
            this.labelFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(91, 24);
            this.labelFilePath.TabIndex = 2;
            this.labelFilePath.Text = "Listen to: ";
            // 
            // listBoxFileInfo
            // 
            this.listBoxFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFileInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxFileInfo.FormattingEnabled = true;
            this.listBoxFileInfo.ItemHeight = 24;
            this.listBoxFileInfo.Location = new System.Drawing.Point(285, 37);
            this.listBoxFileInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFileInfo.Name = "listBoxFileInfo";
            this.listBoxFileInfo.Size = new System.Drawing.Size(264, 364);
            this.listBoxFileInfo.TabIndex = 3;
            // 
            // labelRecording
            // 
            this.labelRecording.AutoSize = true;
            this.labelRecording.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecording.Location = new System.Drawing.Point(326, 37);
            this.labelRecording.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecording.Name = "labelRecording";
            this.labelRecording.Size = new System.Drawing.Size(0, 24);
            this.labelRecording.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer);
            this.groupBox1.Controls.Add(this.radioButtonDirectSound);
            this.groupBox1.Controls.Add(this.radioButtonWaveOut);
            this.groupBox1.Controls.Add(this.radioButtonMediaPlayer);
            this.groupBox1.Controls.Add(this.radioButtonSoundPlayer);
            this.groupBox1.Controls.Add(this.labelRecording);
            this.groupBox1.Controls.Add(this.listBoxFileInfo);
            this.groupBox1.Controls.Add(this.labelFilePath);
            this.groupBox1.Controls.Add(this.buttonPlay);
            this.groupBox1.Controls.Add(this.buttonFile);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(38, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(579, 472);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odtwarzanie";
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(7, 181);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(266, 49);
            this.axWindowsMediaPlayer.TabIndex = 14;
            this.axWindowsMediaPlayer.Visible = false;
            // 
            // radioButtonDirectSound
            // 
            this.radioButtonDirectSound.AutoSize = true;
            this.radioButtonDirectSound.Location = new System.Drawing.Point(15, 252);
            this.radioButtonDirectSound.Name = "radioButtonDirectSound";
            this.radioButtonDirectSound.Size = new System.Drawing.Size(142, 24);
            this.radioButtonDirectSound.TabIndex = 18;
            this.radioButtonDirectSound.TabStop = true;
            this.radioButtonDirectSound.Text = "Direct Sound";
            this.radioButtonDirectSound.UseVisualStyleBackColor = true;
            // 
            // radioButtonWaveOut
            // 
            this.radioButtonWaveOut.AutoSize = true;
            this.radioButtonWaveOut.Location = new System.Drawing.Point(14, 222);
            this.radioButtonWaveOut.Name = "radioButtonWaveOut";
            this.radioButtonWaveOut.Size = new System.Drawing.Size(106, 24);
            this.radioButtonWaveOut.TabIndex = 17;
            this.radioButtonWaveOut.TabStop = true;
            this.radioButtonWaveOut.Text = "Wave Out";
            this.radioButtonWaveOut.UseVisualStyleBackColor = true;
            // 
            // radioButtonMediaPlayer
            // 
            this.radioButtonMediaPlayer.AutoSize = true;
            this.radioButtonMediaPlayer.Location = new System.Drawing.Point(15, 192);
            this.radioButtonMediaPlayer.Name = "radioButtonMediaPlayer";
            this.radioButtonMediaPlayer.Size = new System.Drawing.Size(142, 24);
            this.radioButtonMediaPlayer.TabIndex = 16;
            this.radioButtonMediaPlayer.TabStop = true;
            this.radioButtonMediaPlayer.Text = "Media Player";
            this.radioButtonMediaPlayer.UseVisualStyleBackColor = true;
            // 
            // radioButtonSoundPlayer
            // 
            this.radioButtonSoundPlayer.AutoSize = true;
            this.radioButtonSoundPlayer.Checked = true;
            this.radioButtonSoundPlayer.Location = new System.Drawing.Point(15, 162);
            this.radioButtonSoundPlayer.Name = "radioButtonSoundPlayer";
            this.radioButtonSoundPlayer.Size = new System.Drawing.Size(142, 24);
            this.radioButtonSoundPlayer.TabIndex = 15;
            this.radioButtonSoundPlayer.TabStop = true;
            this.radioButtonSoundPlayer.Text = "Sound Player";
            this.radioButtonSoundPlayer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSelectFile);
            this.groupBox2.Controls.Add(this.buttonRecord);
            this.groupBox2.Controls.Add(this.listBoxMicrophones);
            this.groupBox2.Controls.Add(this.buttonFindDevice);
            this.groupBox2.Controls.Add(this.labelSelectDevice);
            this.groupBox2.Controls.Add(this.labelSaveFilePath);
            this.groupBox2.Location = new System.Drawing.Point(38, 498);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 254);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nagrywanie";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.buttonSelectFile.Location = new System.Drawing.Point(15, 151);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(210, 57);
            this.buttonSelectFile.TabIndex = 8;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.buttonRecord.Location = new System.Drawing.Point(15, 88);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(210, 57);
            this.buttonRecord.TabIndex = 7;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // listBoxMicrophones
            // 
            this.listBoxMicrophones.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.listBoxMicrophones.FormattingEnabled = true;
            this.listBoxMicrophones.ItemHeight = 24;
            this.listBoxMicrophones.Location = new System.Drawing.Point(285, 49);
            this.listBoxMicrophones.Name = "listBoxMicrophones";
            this.listBoxMicrophones.Size = new System.Drawing.Size(264, 124);
            this.listBoxMicrophones.TabIndex = 6;
            // 
            // buttonFindDevice
            // 
            this.buttonFindDevice.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.buttonFindDevice.Location = new System.Drawing.Point(15, 25);
            this.buttonFindDevice.Name = "buttonFindDevice";
            this.buttonFindDevice.Size = new System.Drawing.Size(210, 57);
            this.buttonFindDevice.TabIndex = 5;
            this.buttonFindDevice.Text = "Find Microphone";
            this.buttonFindDevice.UseVisualStyleBackColor = true;
            this.buttonFindDevice.Click += new System.EventHandler(this.buttonFindDevice_Click);
            // 
            // labelSelectDevice
            // 
            this.labelSelectDevice.AutoSize = true;
            this.labelSelectDevice.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.labelSelectDevice.Location = new System.Drawing.Point(281, 22);
            this.labelSelectDevice.Name = "labelSelectDevice";
            this.labelSelectDevice.Size = new System.Drawing.Size(125, 24);
            this.labelSelectDevice.TabIndex = 4;
            this.labelSelectDevice.Text = "Select device:";
            this.labelSelectDevice.Visible = false;
            // 
            // labelSaveFilePath
            // 
            this.labelSaveFilePath.AutoSize = true;
            this.labelSaveFilePath.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSaveFilePath.Location = new System.Drawing.Point(11, 211);
            this.labelSaveFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaveFilePath.Name = "labelSaveFilePath";
            this.labelSaveFilePath.Size = new System.Drawing.Size(82, 24);
            this.labelSaveFilePath.TabIndex = 3;
            this.labelSaveFilePath.Text = "Save to: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 780);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obsługa karty dźwiękowej";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.ListBox listBoxFileInfo;
        private System.Windows.Forms.Label labelRecording;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.RadioButton radioButtonDirectSound;
        private System.Windows.Forms.RadioButton radioButtonWaveOut;
        private System.Windows.Forms.RadioButton radioButtonMediaPlayer;
        private System.Windows.Forms.RadioButton radioButtonSoundPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSaveFilePath;
        private System.Windows.Forms.Label labelSelectDevice;
        private System.Windows.Forms.Button buttonFindDevice;
        private System.Windows.Forms.ListBox listBoxMicrophones;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonSelectFile;
    }
}

