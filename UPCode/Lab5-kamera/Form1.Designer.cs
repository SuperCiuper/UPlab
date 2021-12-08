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
            this.pbCam1 = new System.Windows.Forms.PictureBox();
            this.labelCamera1 = new System.Windows.Forms.Label();
            this.buttonSsCam1 = new System.Windows.Forms.Button();
            this.buttonCamOneStop = new System.Windows.Forms.Button();
            this.buttonPictureCamOne = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonRecordingCamOne = new System.Windows.Forms.Button();
            this.buttonStopRecordingCamOne = new System.Windows.Forms.Button();
            this.brightnesslabel = new System.Windows.Forms.Label();
            this.saturationlabel = new System.Windows.Forms.Label();
            this.contrastlabel = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_searchDev
            // 
            this.button_searchDev.Location = new System.Drawing.Point(12, 8);
            this.button_searchDev.Name = "button_searchDev";
            this.button_searchDev.Size = new System.Drawing.Size(136, 23);
            this.button_searchDev.TabIndex = 0;
            this.button_searchDev.Text = "Search devices";
            this.button_searchDev.UseVisualStyleBackColor = true;
            this.button_searchDev.Click += new System.EventHandler(this.button_searchDev_Click);
            // 
            // cmbDevList1
            // 
            this.cmbDevList1.FormattingEnabled = true;
            this.cmbDevList1.Location = new System.Drawing.Point(12, 54);
            this.cmbDevList1.Name = "cmbDevList1";
            this.cmbDevList1.Size = new System.Drawing.Size(357, 21);
            this.cmbDevList1.TabIndex = 1;
            // 
            // pbCam1
            // 
            this.pbCam1.Location = new System.Drawing.Point(12, 81);
            this.pbCam1.Name = "pbCam1";
            this.pbCam1.Size = new System.Drawing.Size(357, 271);
            this.pbCam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCam1.TabIndex = 3;
            this.pbCam1.TabStop = false;
            // 
            // labelCamera1
            // 
            this.labelCamera1.AutoSize = true;
            this.labelCamera1.Location = new System.Drawing.Point(12, 35);
            this.labelCamera1.Name = "labelCamera1";
            this.labelCamera1.Size = new System.Drawing.Size(55, 13);
            this.labelCamera1.TabIndex = 4;
            this.labelCamera1.Text = "Camera 1:";
            // 
            // buttonSsCam1
            // 
            this.buttonSsCam1.Location = new System.Drawing.Point(12, 358);
            this.buttonSsCam1.Name = "buttonSsCam1";
            this.buttonSsCam1.Size = new System.Drawing.Size(65, 23);
            this.buttonSsCam1.TabIndex = 7;
            this.buttonSsCam1.Text = "Start";
            this.buttonSsCam1.UseVisualStyleBackColor = true;
            this.buttonSsCam1.Click += new System.EventHandler(this.buttonSsCam1_Click);
            // 
            // buttonCamOneStop
            // 
            this.buttonCamOneStop.Location = new System.Drawing.Point(83, 358);
            this.buttonCamOneStop.Name = "buttonCamOneStop";
            this.buttonCamOneStop.Size = new System.Drawing.Size(65, 23);
            this.buttonCamOneStop.TabIndex = 8;
            this.buttonCamOneStop.Text = "Stop";
            this.buttonCamOneStop.UseVisualStyleBackColor = true;
            this.buttonCamOneStop.Click += new System.EventHandler(this.buttonCamOneStop_Click);
            // 
            // buttonPictureCamOne
            // 
            this.buttonPictureCamOne.Location = new System.Drawing.Point(154, 358);
            this.buttonPictureCamOne.Name = "buttonPictureCamOne";
            this.buttonPictureCamOne.Size = new System.Drawing.Size(65, 23);
            this.buttonPictureCamOne.TabIndex = 11;
            this.buttonPictureCamOne.Text = "Picture";
            this.buttonPictureCamOne.UseVisualStyleBackColor = true;
            this.buttonPictureCamOne.Click += new System.EventHandler(this.buttonPictureCamOne_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "picture";
            // 
            // buttonRecordingCamOne
            // 
            this.buttonRecordingCamOne.Location = new System.Drawing.Point(225, 358);
            this.buttonRecordingCamOne.Name = "buttonRecordingCamOne";
            this.buttonRecordingCamOne.Size = new System.Drawing.Size(65, 23);
            this.buttonRecordingCamOne.TabIndex = 13;
            this.buttonRecordingCamOne.Text = "Record";
            this.buttonRecordingCamOne.UseVisualStyleBackColor = true;
            this.buttonRecordingCamOne.Click += new System.EventHandler(this.buttonRecordingCamOne_Click);
            // 
            // buttonStopRecordingCamOne
            // 
            this.buttonStopRecordingCamOne.Enabled = false;
            this.buttonStopRecordingCamOne.Location = new System.Drawing.Point(225, 358);
            this.buttonStopRecordingCamOne.Name = "buttonStopRecordingCamOne";
            this.buttonStopRecordingCamOne.Size = new System.Drawing.Size(65, 23);
            this.buttonStopRecordingCamOne.TabIndex = 18;
            this.buttonStopRecordingCamOne.Text = "Stop";
            this.buttonStopRecordingCamOne.UseVisualStyleBackColor = true;
            this.buttonStopRecordingCamOne.Click += new System.EventHandler(this.buttonStopRecordingCamOne_Click);
            // 
            // brightnesslabel
            // 
            this.brightnesslabel.AutoSize = true;
            this.brightnesslabel.Location = new System.Drawing.Point(80, 402);
            this.brightnesslabel.Name = "brightnesslabel";
            this.brightnesslabel.Size = new System.Drawing.Size(56, 13);
            this.brightnesslabel.TabIndex = 15;
            this.brightnesslabel.Text = "Brightness";
            // 
            // saturationlabel
            // 
            this.saturationlabel.AutoSize = true;
            this.saturationlabel.Location = new System.Drawing.Point(82, 466);
            this.saturationlabel.Name = "saturationlabel";
            this.saturationlabel.Size = new System.Drawing.Size(55, 13);
            this.saturationlabel.TabIndex = 16;
            this.saturationlabel.Text = "Saturation";
            // 
            // contrastlabel
            // 
            this.contrastlabel.AutoSize = true;
            this.contrastlabel.Location = new System.Drawing.Point(82, 530);
            this.contrastlabel.Name = "contrastlabel";
            this.contrastlabel.Size = new System.Drawing.Size(46, 13);
            this.contrastlabel.TabIndex = 17;
            this.contrastlabel.Text = "Contrast";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(85, 418);
            this.brightnessTrackBar.Maximum = 100;
            this.brightnessTrackBar.Minimum = -100;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(131, 45);
            this.brightnessTrackBar.TabIndex = 18;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // saturationTrackBar
            // 
            this.saturationTrackBar.Location = new System.Drawing.Point(83, 482);
            this.saturationTrackBar.Maximum = 100;
            this.saturationTrackBar.Minimum = -100;
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.Size = new System.Drawing.Size(131, 45);
            this.saturationTrackBar.TabIndex = 19;
            this.saturationTrackBar.Scroll += new System.EventHandler(this.saturationTrackBar_Scroll);
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(83, 546);
            this.contrastTrackBar.Maximum = 100;
            this.contrastTrackBar.Minimum = -100;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(131, 45);
            this.contrastTrackBar.TabIndex = 20;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 640);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.saturationTrackBar);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.contrastlabel);
            this.Controls.Add(this.saturationlabel);
            this.Controls.Add(this.brightnesslabel);
            this.Controls.Add(this.buttonRecordingCamOne);
            this.Controls.Add(this.buttonPictureCamOne);
            this.Controls.Add(this.buttonCamOneStop);
            this.Controls.Add(this.buttonSsCam1);
            this.Controls.Add(this.labelCamera1);
            this.Controls.Add(this.pbCam1);
            this.Controls.Add(this.cmbDevList1);
            this.Controls.Add(this.button_searchDev);
            this.Name = "MainWindow";
            this.Text = "USBCam";
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbCam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_searchDev;
        private System.Windows.Forms.ComboBox cmbDevList1;
        private System.Windows.Forms.PictureBox pbCam1;
        private System.Windows.Forms.Label labelCamera1;
        private System.Windows.Forms.Button buttonSsCam1;
        private System.Windows.Forms.Button buttonCamOneStop;
        private System.Windows.Forms.Button buttonPictureCamOne;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonRecordingCamOne;
        private System.Windows.Forms.Button buttonStopRecordingCamOne;
        private System.Windows.Forms.Label brightnesslabel;
        private System.Windows.Forms.Label saturationlabel;
        private System.Windows.Forms.Label contrastlabel;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TrackBar saturationTrackBar;
        private System.Windows.Forms.TrackBar contrastTrackBar;
    }
}

