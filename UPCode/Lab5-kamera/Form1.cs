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


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (videoSource.IsRunning)
            // {
            //    videoSource.Stop();
            //}
        }
        private void button_searchDev_Click(object sender, EventArgs e)
        {
            videoDevicesList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in videoDevicesList)
            {
                cmbDevList1.Items.Add(videoDevice.Name);
            }
        }

        private void CameraOne_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap1 = (Bitmap)eventArgs.Frame.Clone();
            BrightnessCorrection br = new BrightnessCorrection(brightess);
            ContrastCorrection cr = new ContrastCorrection(contrast);
            SaturationCorrection sr = new SaturationCorrection(saturation);
            bitmap1 = br.Apply((Bitmap)bitmap1.Clone());
            bitmap1 = cr.Apply((Bitmap)bitmap1.Clone());
            bitmap1 = sr.Apply((Bitmap)bitmap1.Clone());

            pbCam1.Image = bitmap1;

            if (isRecording)
            {
                writer.WriteVideoFrame(bitmap1);
            }
        }

        private void buttonSsCam1_Click(object sender, EventArgs e)
        {
            camera = new VideoCaptureDevice(videoDevicesList[cmbDevList1.SelectedIndex].MonikerString);
            camera.NewFrame += new NewFrameEventHandler(CameraOne_NewFrame);
            camera.Start();
        }

        private void buttonCamOneStop_Click(object sender, EventArgs e)
        {
            camera.Stop();
        }

        private void buttonPictureCamOne_Click(object sender, EventArgs e)
        {
            buttonCamOneStop_Click(sender, e);
            Bitmap picture = (Bitmap)pbCam1.Image;
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
            picture.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
            fs.Close();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            brightess = 0;
            contrast = 0;
            saturation = 0;
        }

        private void buttonRecordingCamOne_Click(object sender, EventArgs e)
        {
            if (camera.IsRunning)
            {
                buttonRecordingCamOne.Enabled = false;
                buttonStopRecordingCamOne.Enabled = true;

                try
                {
                    isRecording = true;
                    writer = new VideoFileWriter();
                    writer.Open("video.avi", pbCam1.Image.Width, pbCam1.Image.Height, 30, VideoCodec.MPEG4);
                }
                catch { }
            }
        }
        private void buttonStopRecordingCamOne_Click(object sender, EventArgs e)
        {
            if (camera.IsRunning)
            {
                isRecording = false;
                writer.Close();

                buttonRecordingCamOne.Enabled = true;
                buttonStopRecordingCamOne.Enabled = false;
                saveFileDialog.Filter = "Avi Files (*.avi)|*.avi";
                saveFileDialog.Title = "Save a Video File";
                saveFileDialog.ShowDialog();
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
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
    }
}