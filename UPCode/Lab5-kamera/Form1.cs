using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using Accord.Video.VFW;
using Accord.Video.FFMPEG;
using AForge.Imaging.Filters;


namespace Lab5_kamera
{
    public partial class Form1 : Form
    {
        FilterInfoCollection videoDevicesList;
        VideoCaptureDevice camera;
        int brightess = 0;
        int contrast = 0;
        int saturation = 0;
        bool isRecording = false;
        VideoFileWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_searchDev_Click(object sender, EventArgs e)
        {
            videoDevicesList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cmbDevList1.Items.Clear();
            foreach (FilterInfo videoDevice in videoDevicesList)
            {
                cmbDevList1.Items.Add(videoDevice.Name);
            }
        }

        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BrightnessCorrection br = new BrightnessCorrection(brightess);
            ContrastCorrection cr = new ContrastCorrection(contrast);
            SaturationCorrection sr = new SaturationCorrection(saturation);
            bitmap = br.Apply((Bitmap)bitmap.Clone());
            bitmap = cr.Apply((Bitmap)bitmap.Clone());
            bitmap = sr.Apply((Bitmap)bitmap.Clone());

            pbCam.Image = bitmap;

            if (isRecording)
            {
                writer.WriteVideoFrame(bitmap);
            }
        }

        private void buttonStartCam_Click(object sender, EventArgs e)
        {
            if(cmbDevList1.Items.Count == 0)
            {
                MessageBox.Show("No cams detected");
                return;
            }
            camera = new VideoCaptureDevice(videoDevicesList[cmbDevList1.SelectedIndex].MonikerString);
            camera.NewFrame += new NewFrameEventHandler(Camera_NewFrame);
            camera.Start();

            buttonStopCam.Enabled = true;
            buttonPictureCam.Enabled = true;
            buttonRecordingCam.Enabled = true;
            buttonStartCam.Enabled = false;
        }

        private void buttonStopCam_Click(object sender, EventArgs e)
        {
            camera.Stop();
            buttonStopCam.Enabled = false;
            buttonPictureCam.Enabled = false;
            buttonRecordingCam.Enabled = false;
            buttonStartCam.Enabled = true;
        }

        private void buttonPictureCam_Click(object sender, EventArgs e)
        {
            buttonStopCam_Click(sender, e);
            Bitmap picture = (Bitmap)pbCam.Image;
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
            picture.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
            fs.Close();

            buttonStopCam.Enabled = false;
            buttonPictureCam.Enabled = false;
            buttonRecordingCam.Enabled = false;
            buttonStartCam.Enabled = true;
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            brightess = 0;
            contrast = 0;
            saturation = 0;
        }

        private void buttonRecordingCam_Click(object sender, EventArgs e)
        {
            if (camera.IsRunning)
            {
                camera.Stop();
                buttonStopCam.Enabled = false;
                buttonPictureCam.Enabled = false;
                buttonRecordingCam.Enabled = false;
                buttonStartCam.Enabled = false;
                buttonStopRecordingCam.Enabled = true;

                saveFileDialog.Filter = "Avi |*.avi";
                saveFileDialog.Title = "Save recording";
                saveFileDialog.ShowDialog();

                try
                {
                    isRecording = true;
                    writer = new VideoFileWriter();
                    writer.Open(saveFileDialog.FileName, pbCam.Image.Width, pbCam.Image.Height, 30, VideoCodec.MPEG4);
                    MessageBox.Show("XD");
                }
                catch 
                {
                    isRecording = false;
                }
            }
        }
        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            if (camera.IsRunning)
                brightess = brightnessTrackBar.Value;
        }

        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            if (camera.IsRunning)
                contrast = contrastTrackBar.Value;
        }

        private void saturationTrackBar_Scroll(object sender, EventArgs e)
        {
            if (camera.IsRunning)
                saturation = saturationTrackBar.Value;
        }

        private void buttonStopRecordingCam_Click(object sender, EventArgs e)
        {
            writer.Close();
            camera.Stop();
            buttonStopCam.Enabled = false;
            buttonPictureCam.Enabled = false;
            buttonRecordingCam.Enabled = false;
            buttonStartCam.Enabled = true;
            buttonStopRecordingCam.Enabled = false;
        }
    }
}