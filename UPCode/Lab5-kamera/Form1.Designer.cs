using System.Windows.Forms;

namespace Lab5_kamera

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
            this.button_searchDev = new System.Windows.Forms.Button();
            this.cmbDevList1 = new System.Windows.Forms.ComboBox();
            this.pbCam = new System.Windows.Forms.PictureBox();
            this.labelCamera = new System.Windows.Forms.Label();
            this.buttonStartCam = new System.Windows.Forms.Button();
            this.buttonStopCam = new System.Windows.Forms.Button();
            this.buttonPictureCam = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonRecordingCam = new System.Windows.Forms.Button();
            this.brightnesslabel = new System.Windows.Forms.Label();
            this.saturationlabel = new System.Windows.Forms.Label();
            this.contrastlabel = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.buttonStopRecordingCam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_searchDev
            // 
            this.button_searchDev.Location = new System.Drawing.Point(18, 12);
            this.button_searchDev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_searchDev.Name = "button_searchDev";
            this.button_searchDev.Size = new System.Drawing.Size(204, 35);
            this.button_searchDev.TabIndex = 0;
            this.button_searchDev.Text = "Search devices";
            this.button_searchDev.UseVisualStyleBackColor = true;
            this.button_searchDev.Click += new System.EventHandler(this.button_searchDev_Click);
            // 
            // cmbDevList1
            // 
            this.cmbDevList1.FormattingEnabled = true;
            this.cmbDevList1.Location = new System.Drawing.Point(18, 83);
            this.cmbDevList1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDevList1.Name = "cmbDevList1";
            this.cmbDevList1.Size = new System.Drawing.Size(534, 28);
            this.cmbDevList1.TabIndex = 1;
            // 
            // pbCam
            // 
            this.pbCam.Location = new System.Drawing.Point(18, 125);
            this.pbCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbCam.Name = "pbCam";
            this.pbCam.Size = new System.Drawing.Size(536, 417);
            this.pbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCam.TabIndex = 3;
            this.pbCam.TabStop = false;
            // 
            // labelCamera
            // 
            this.labelCamera.AutoSize = true;
            this.labelCamera.Location = new System.Drawing.Point(18, 54);
            this.labelCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCamera.Name = "labelCamera";
            this.labelCamera.Size = new System.Drawing.Size(69, 20);
            this.labelCamera.TabIndex = 4;
            this.labelCamera.Text = "Camera:";
            // 
            // buttonStartCam
            // 
            this.buttonStartCam.Location = new System.Drawing.Point(18, 551);
            this.buttonStartCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStartCam.Name = "buttonStartCam";
            this.buttonStartCam.Size = new System.Drawing.Size(98, 35);
            this.buttonStartCam.TabIndex = 7;
            this.buttonStartCam.Text = "Start";
            this.buttonStartCam.UseVisualStyleBackColor = true;
            this.buttonStartCam.Click += new System.EventHandler(this.buttonStartCam_Click);
            // 
            // buttonStopCam
            // 
            this.buttonStopCam.Enabled = false;
            this.buttonStopCam.Location = new System.Drawing.Point(124, 551);
            this.buttonStopCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStopCam.Name = "buttonStopCam";
            this.buttonStopCam.Size = new System.Drawing.Size(98, 35);
            this.buttonStopCam.TabIndex = 8;
            this.buttonStopCam.Text = "Stop";
            this.buttonStopCam.UseVisualStyleBackColor = true;
            this.buttonStopCam.Click += new System.EventHandler(this.buttonStopCam_Click);
            // 
            // buttonPictureCam
            // 
            this.buttonPictureCam.Enabled = false;
            this.buttonPictureCam.Location = new System.Drawing.Point(231, 551);
            this.buttonPictureCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPictureCam.Name = "buttonPictureCam";
            this.buttonPictureCam.Size = new System.Drawing.Size(98, 35);
            this.buttonPictureCam.TabIndex = 11;
            this.buttonPictureCam.Text = "Picture";
            this.buttonPictureCam.UseVisualStyleBackColor = true;
            this.buttonPictureCam.Click += new System.EventHandler(this.buttonPictureCam_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "picture";
            // 
            // buttonRecordingCam
            // 
            this.buttonRecordingCam.Enabled = false;
            this.buttonRecordingCam.Location = new System.Drawing.Point(338, 551);
            this.buttonRecordingCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRecordingCam.Name = "buttonRecordingCam";
            this.buttonRecordingCam.Size = new System.Drawing.Size(98, 35);
            this.buttonRecordingCam.TabIndex = 13;
            this.buttonRecordingCam.Text = "Record";
            this.buttonRecordingCam.UseVisualStyleBackColor = true;
            this.buttonRecordingCam.Click += new System.EventHandler(this.buttonRecordingCam_Click);
            // 
            // brightnesslabel
            // 
            this.brightnesslabel.AutoSize = true;
            this.brightnesslabel.Location = new System.Drawing.Point(120, 618);
            this.brightnesslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brightnesslabel.Name = "brightnesslabel";
            this.brightnesslabel.Size = new System.Drawing.Size(85, 20);
            this.brightnesslabel.TabIndex = 15;
            this.brightnesslabel.Text = "Brightness";
            // 
            // saturationlabel
            // 
            this.saturationlabel.AutoSize = true;
            this.saturationlabel.Location = new System.Drawing.Point(123, 717);
            this.saturationlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturationlabel.Name = "saturationlabel";
            this.saturationlabel.Size = new System.Drawing.Size(83, 20);
            this.saturationlabel.TabIndex = 16;
            this.saturationlabel.Text = "Saturation";
            // 
            // contrastlabel
            // 
            this.contrastlabel.AutoSize = true;
            this.contrastlabel.Location = new System.Drawing.Point(123, 815);
            this.contrastlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrastlabel.Name = "contrastlabel";
            this.contrastlabel.Size = new System.Drawing.Size(70, 20);
            this.contrastlabel.TabIndex = 17;
            this.contrastlabel.Text = "Contrast";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(128, 643);
            this.brightnessTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brightnessTrackBar.Maximum = 100;
            this.brightnessTrackBar.Minimum = -100;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(196, 69);
            this.brightnessTrackBar.TabIndex = 18;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // saturationTrackBar
            // 
            this.saturationTrackBar.Location = new System.Drawing.Point(124, 742);
            this.saturationTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saturationTrackBar.Maximum = 100;
            this.saturationTrackBar.Minimum = -100;
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.Size = new System.Drawing.Size(196, 69);
            this.saturationTrackBar.TabIndex = 19;
            this.saturationTrackBar.Scroll += new System.EventHandler(this.saturationTrackBar_Scroll);
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(124, 840);
            this.contrastTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contrastTrackBar.Maximum = 100;
            this.contrastTrackBar.Minimum = -100;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(196, 69);
            this.contrastTrackBar.TabIndex = 20;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // buttonStopRecordingCam
            // 
            this.buttonStopRecordingCam.Enabled = false;
            this.buttonStopRecordingCam.Location = new System.Drawing.Point(444, 551);
            this.buttonStopRecordingCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStopRecordingCam.Name = "buttonStopRecordingCam";
            this.buttonStopRecordingCam.Size = new System.Drawing.Size(98, 66);
            this.buttonStopRecordingCam.TabIndex = 21;
            this.buttonStopRecordingCam.Text = "Stop recording";
            this.buttonStopRecordingCam.UseVisualStyleBackColor = true;
            this.buttonStopRecordingCam.Click += new System.EventHandler(this.buttonStopRecordingCam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 985);
            this.Controls.Add(this.buttonStopRecordingCam);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.saturationTrackBar);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.contrastlabel);
            this.Controls.Add(this.saturationlabel);
            this.Controls.Add(this.brightnesslabel);
            this.Controls.Add(this.buttonRecordingCam);
            this.Controls.Add(this.buttonPictureCam);
            this.Controls.Add(this.buttonStopCam);
            this.Controls.Add(this.buttonStartCam);
            this.Controls.Add(this.labelCamera);
            this.Controls.Add(this.pbCam);
            this.Controls.Add(this.cmbDevList1);
            this.Controls.Add(this.button_searchDev);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "USBCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_searchDev;
        private System.Windows.Forms.ComboBox cmbDevList1;
        private System.Windows.Forms.PictureBox pbCam;
        private System.Windows.Forms.Label labelCamera;
        private System.Windows.Forms.Button buttonStartCam;
        private System.Windows.Forms.Button buttonStopCam;
        private System.Windows.Forms.Button buttonPictureCam;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonRecordingCam;
        private System.Windows.Forms.Label brightnesslabel;
        private System.Windows.Forms.Label saturationlabel;
        private System.Windows.Forms.Label contrastlabel;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TrackBar saturationTrackBar;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private Button buttonStopRecordingCam;
    }
}

