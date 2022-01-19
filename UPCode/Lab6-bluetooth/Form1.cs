using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.Threading; 

namespace Lab6_bluetooth
{
    public partial class Form1 : Form
    {
        public const string DEVICE_PIN = "000000";
        private bool continueScanning = false;
        private bool isPaired = false;
        private bool isUnpaired = false;
        private OpenFileDialog openFile = new OpenFileDialog();
        private List<BluetoothDeviceInfo> devices = new List<BluetoothDeviceInfo>();
        BluetoothDeviceInfo deviceToPair = null;
        private string[] fileNames; 
        public Form1()
        {
            InitializeComponent();
            openFile.Multiselect = true;
            openFile.Title = "Select files to send";
        }

        private void ScanDevices()
        {
            try
            {
                while (continueScanning)
                {
                    var bluetoothClient = new BluetoothClient();
                    var bluetoothDevices = bluetoothClient.DiscoverDevices();

                    foreach (var bluetoothDevice in bluetoothDevices)
                    {
                        invokerText(richTextBoxInfo, string.Format("Nazwa urządzenia: {0}\r\nTyp urządzenia: {1} Połączono: {2} Adres: {3}\r\nOstatnio widziano: {4} Ostatnio użyto: {5}\n",
                            bluetoothDevice.DeviceName, bluetoothDevice.ClassOfDevice.Device, bluetoothDevice.Connected, bluetoothDevice.DeviceAddress, bluetoothDevice.LastSeen, bluetoothDevice.LastUsed), true);

                        bool onList = false;

                        if (bluetoothDevice.DeviceName != null)
                        {
                            foreach (string item in listBoxDiscoveredDevices.Items)
                                if (item == bluetoothDevice.DeviceName)
                                    onList = true;
                        }

                        if (!onList)
                        {
                            invoker_listBox_item_add(listBoxDiscoveredDevices, bluetoothDevice.DeviceName);
                            devices.Add(bluetoothDevice);
                        }
                    }
                }
            } catch (Exception error)
            {
                invokerText(richTextBoxInfo, "ERROR: \n" + error.Message + "\n", true);
                invokerText(buttonDiscoverDevices, "Discover devices", false);
                continueScanning = true;
                invokerText(richTextBoxInfo, "Stopped discovering\n", true);
            }

        }

        private void buttonDiscoverDevices_Click(object sender, EventArgs e)
        {
            if (buttonDiscoverDevices.Text == "Discover devices")
            {
                buttonDiscoverDevices.Text = "Stop discovering";
                continueScanning = true;
                invokerText(richTextBoxInfo, "Discovering devices\n", true);
            }
            else
            {
                buttonDiscoverDevices.Text = "Discover devices";
                continueScanning = true;
                invokerText(richTextBoxInfo, "Stopped discovering\n", true);
            }
            Thread findDevices = new Thread(ScanDevices);
            findDevices.Priority = ThreadPriority.Highest;
            findDevices.IsBackground = true;
            findDevices.Start();

        }

        private void ReceiveFiles()
        {
            while (isPaired)
            {
                MessageBox.Show("XasdasdaD");

                var listener = new ObexListener(ObexTransport.Bluetooth);
                listener.Start();
                ObexListenerContext ctx = listener.GetContext();
                ObexListenerRequest req = ctx.Request;
                String[] pathSplits = req.RawUrl.Split('/');
                String file = pathSplits[pathSplits.Length - 1];
                req.WriteFile(file);
                invokerText(richTextBoxInfo, "File received\n", true);
                listener.Stop();
            }
        }

        private void ConnectWithDevice()
        {
            foreach (var device in devices)
            {
                if (device.DeviceName == invoker_listBox_selectedItem(listBoxDiscoveredDevices))
                    deviceToPair = device;

            }

            if (deviceToPair == null)
            {
                invokerText(richTextBoxInfo, "Select device from Discovered devices list\n", true);
            }
            else
            {
                invokerText(richTextBoxInfo, "Connecting with: " + (string)deviceToPair.DeviceName + "\n", true);
                deviceToPair.Update();
                deviceToPair.Refresh();
                deviceToPair.SetServiceState(BluetoothService.ObexObjectPush, true);
                isPaired = BluetoothSecurity.PairRequest(deviceToPair.DeviceAddress, DEVICE_PIN);
                if (isPaired)
                {
                    MessageBox.Show("XD");
                    invokerText(buttonConnection, "Disconnect", false);
                    invokerText(richTextBoxInfo, "Connected\n", true);
                    invoker_listBox_item_add(listBoxConnected, deviceToPair.DeviceName);

                    Thread receiveFiles = new Thread(ReceiveFiles);
                    receiveFiles.Priority = ThreadPriority.Highest;
                    receiveFiles.IsBackground = true;
                    receiveFiles.Start();
                }
                else
                {
                    invokerText(richTextBoxInfo, "Couldn't connect with the device\n", true);
                }
            }
        }

        private void UnpairDevice()
        {
            if (deviceToPair.DeviceName == listBoxConnected.SelectedItem.ToString())
                isUnpaired = BluetoothSecurity.RemoveDevice(deviceToPair.DeviceAddress);

            if (isUnpaired)
            {
                buttonConnection.Text = "Connect";
                invokerText(richTextBoxInfo, "Disconnected\n", true);
                listBoxConnected.Items.Remove(deviceToPair.DeviceName);
                isPaired = false;
            }
            else
            {
                invokerText(richTextBoxInfo, "Couldn't disconnect the device\n", true);
            }
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            if (buttonConnection.Text == "Connect")
            {
                Thread pairWithDevice = new Thread(ConnectWithDevice);
                pairWithDevice.Priority = ThreadPriority.Highest;
                pairWithDevice.IsBackground = true;
                pairWithDevice.Start();
            }
            else
            {
                UnpairDevice();

            }

        }

        private void buttonShowConnectors_Click(object sender, EventArgs e)
        {
            BluetoothRadio[] radios = BluetoothRadio.AllRadios;
            foreach (BluetoothRadio btradio in radios)
            {
                showRadioInfo(btradio);
            }

        }

        private void showRadioInfo(BluetoothRadio radio)
        {
            if (radio == null)
            {
                radio = BluetoothRadio.PrimaryRadio;
            }

            if (radio != null)
            {
                richTextBoxInfo.AppendText("***************************\n");
                richTextBoxInfo.AppendText("Name: " + radio.Name + "\n");
                richTextBoxInfo.AppendText("Manufacturer: " + radio.Manufacturer + "\n");
                richTextBoxInfo.AppendText("Class of device: " + radio.ClassOfDevice + "\n");
                richTextBoxInfo.AppendText("Hardware status: " + radio.HardwareStatus + "\n");
                richTextBoxInfo.AppendText("Local address: " + radio.LocalAddress + "\n");
                richTextBoxInfo.AppendText("Software Manufacturer: " + radio.SoftwareManufacturer + "\n");
            }
            else
            {
                richTextBoxInfo.AppendText("No primary radio");
            }
        }

        private void richTextBoxInfo_TextChanged(object sender, EventArgs e)
        {
            richTextBoxInfo.SelectionStart = richTextBoxInfo.Text.Length;
            richTextBoxInfo.ScrollToCaret();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            fileNames = openFile.FileNames;

            if (fileNames.Length == 1)
                textBoxSelectedFile.Text = fileNames[0];

            else if (fileNames.Length == 0)
                textBoxSelectedFile.Text = "No files selected";

            else
                textBoxSelectedFile.Text = fileNames.Length + " files selected";
        }
        private void Send()
        {
            foreach (string file in fileNames)
            {
                try
                {
                    if (deviceToPair != null)
                        invokerText(richTextBoxInfo, "Sending the file\n", true);

                    var uri = new Uri("obex://" + deviceToPair.DeviceAddress + "/" + file);
                    var request = new ObexWebRequest(uri);
                    request.ReadFile(file);
                    var response = (ObexWebResponse)request.GetResponse();
                    invokerText(richTextBoxInfo, "File send successfully " + file + "\n", true);
                }
                catch (Exception error)
                {
                    invokerText(richTextBoxInfo, "ERROR: " + error.Message + "\n", true);
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Thread sendFilesTh = new Thread(Send);
            sendFilesTh.Priority = ThreadPriority.Highest;
            sendFilesTh.IsBackground = true;
            sendFilesTh.Start();
        }

        void invokerText(Control control, string message, bool append)
        {
            if (control.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    invokerText(control, message, append);
                }));
            }
            else
            {
                if (append)
                    control.Text += message;

                else
                    control.Text = message;
            }
        }

        void invoker_listBox_item_add(ListBox listBox, string message)
        {
            if (listBox.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    invoker_listBox_item_add(listBox, message);
                }));
            }
            else
                listBox.Items.Add(message);

        }

        string invoker_listBox_selectedItem(ListBox listBox)
        {
            if (listBox.InvokeRequired)
            {
                return (string)listBox.Invoke(
                    new Func<String>(() => invoker_listBox_selectedItem(listBox))
                );
            }
            else
                return (string)listBox.SelectedItem;
        }
    }
}
