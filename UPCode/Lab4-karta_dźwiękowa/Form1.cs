using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using AxWMPLib;
using NAudio.Wave;

namespace Lab4_karta_dźwiękowa
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        private string fileRecordPath = "";

        private SoundPlayer soundPlayer;
        private AxWindowsMediaPlayer mediaPlayer;
        private WaveOut waveOutDevice = new WaveOut();
        private DirectSoundOut directSoundOut = new DirectSoundOut();
        private AudioFileReader audioFileReader;

        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut soundOut = null;
        NAudio.Wave.WaveFileWriter waveFileWriter = null;

        public Form1()
        {
            InitializeComponent();
            mediaPlayer = axWindowsMediaPlayer;
            mediaPlayer.CreateControl();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog();
            fileExplorer.Filter = "Audio files (.wav)|*.wav";
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                filePath = fileExplorer.FileName;
                labelFilePath.Text = $"Listen to: {filePath}";
                FillListBox();
                soundPlayer = new SoundPlayer(@filePath);
                audioFileReader = new AudioFileReader(filePath);
            }
        }

        private void FillListBox()
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                BinaryReader reader = new BinaryReader(fileStream);

                byte[] wave = reader.ReadBytes(24);

                fileStream.Position = 0;


                int chunkID = reader.ReadInt32();
                int fileSize = reader.ReadInt32();
                var fileFormat = Encoding.Default.GetString(wave);
                string format = fileFormat.Substring(8, 4);
                string subchunk1ID = fileFormat.Substring(12, 8);
                int subchunk1Size = reader.ReadInt32();


                reader.Close();


                string chunkIDStr = $"Chunk ID: {chunkID}";
                string fileSizeStr = $"Chunk size: {fileSize}";

                string fileFormatStr = $"Format: {format}";
                string subchunk1IDStr = $"Subchunk ID: {subchunk1ID}";
                string subchunk1SizeStr = $"Subchunk Size ID: {subchunk1Size}";

                listBoxFileInfo.Items.Clear();
                listBoxFileInfo.Items.AddRange(new string[] {
                                                             "\tNagłówek pliku:",
                                                             chunkIDStr,
                                                             fileSizeStr,
                                                             fileFormatStr,
                                                             "\tOpis struktury audio:",
                                                             subchunk1IDStr,
                                                             subchunk1SizeStr});
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {

            if (filePath == String.Empty)
                MessageBox.Show("Wybierz plik!");

            else
            {
                if (buttonPlay.Text == "PLAY")
                {
                    buttonPlay.Text = "STOP";

                    if(radioButtonSoundPlayer.Checked)
                    {
                        soundPlayer.Play();
                    }

                    if(radioButtonMediaPlayer.Checked)
                    {
                        axWindowsMediaPlayer.Visible = true;
                        mediaPlayer.URL = filePath;
                        mediaPlayer.Ctlcontrols.play();
                    }
                    
                    if(radioButtonWaveOut.Checked)
                    {
                        var waveOut = new WaveChannel32(new WaveFileReader(filePath));
                        waveOutDevice.Init(waveOut);
                        waveOutDevice.Play();
                    }

                    if (radioButtonDirectSound.Checked)
                    {
                        directSoundOut.Init(audioFileReader);
                        directSoundOut.Play();
                    }
                }

                else
                {
                    buttonPlay.Text = "PLAY";

                    if (radioButtonSoundPlayer.Checked)
                    {
                        soundPlayer.Stop();
                    }

                    if (radioButtonMediaPlayer.Checked)
                    {
                        mediaPlayer.Ctlcontrols.stop();
                        axWindowsMediaPlayer.Visible = false;
                    }

                    if (radioButtonWaveOut.Checked)
                    {
                        waveOutDevice.Stop();
                    }

                    if (radioButtonDirectSound.Checked)
                    {
                        directSoundOut.Stop();
                    }
                }
            }
        }

        // obsługa przycisku wyszukiwania mikrofonu
        private void buttonFindDevice_Click(object sender, EventArgs e)
        {
            labelSelectDevice.Visible = true;

            List<NAudio.Wave.WaveInCapabilities> sources = new List<WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
                sources.Add(WaveIn.GetCapabilities(i));

            listBoxMicrophones.Items.Clear();

            int counter = 0;
            foreach (var source in sources)
            {
                string item = source.ProductName;
                listBoxMicrophones.Items.Add("Microfon " + counter + "->" + item);
                counter++;
            }
        }

        private void sourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFileWriter == null)
                return;

            waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveFileWriter.Flush();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (buttonRecord.Text == "Record")
            {
                if (listBoxMicrophones.SelectedItems.Count == 0)
                    return;

                if (fileRecordPath == "")
                {
                    MessageBox.Show("Select save file");
                }
                else
                {
                    int deviceNumber = listBoxMicrophones.SelectedIndex;

                    sourceStream = new WaveIn();
                    sourceStream.DeviceNumber = deviceNumber;
                    sourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceNumber).Channels);
                    sourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(sourceStream_DataAvailable);
                    waveFileWriter = new WaveFileWriter(fileRecordPath, sourceStream.WaveFormat);

                    sourceStream.StartRecording();

                    buttonRecord.Text = "Stop recording";
                }
            }
            else
            {
                if (soundOut != null)
                {
                    soundOut.Stop();
                    soundOut.Dispose();
                    soundOut = null;
                    buttonRecord.Text = "Record";
                }
                if (sourceStream != null)
                {
                    sourceStream.StopRecording();
                    sourceStream.Dispose();
                    sourceStream = null;
                    buttonRecord.Text = "Record";
                }
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                    waveFileWriter = null;
                    buttonRecord.Text = "Record";
                }

                labelRecording.Text = "";
            }
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileExplorer = new SaveFileDialog();
            fileExplorer.Filter = "Wave File (*.wav)|*.wav;";
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                fileRecordPath = fileExplorer.FileName;
                labelSaveFilePath.Text = $"Save to: {fileRecordPath}";
            }

        }
    }
}
