using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC;
using PCSC.Utils;
using System.Threading;

namespace Lab2_czytnik_kaart_chipowych
{
    public partial class Form1 : Form
    {
        private static SCardError error;
        private static SCardReader reader;
        private static System.IntPtr intptr;
        private static SCardContext context;
        byte[] command;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            context = new SCardContext(); 
            context.Establish(SCardScope.System);
            var readerList = context.GetReaders();

            if (readerList.Length <= 0)
            {
                richTextBoxOutput.AppendText("No readers found, aborting \n");
                return;
            }

            reader = new SCardReader(context);
            error = reader.Connect(readerList[0], SCardShareMode.Shared, SCardProtocol.T0 | SCardProtocol.T1);
            if (error != SCardError.Success)
            {
                richTextBoxOutput.AppendText("SCardError: " + error +  "\n");
                return;
            }

            if (reader.ActiveProtocol == SCardProtocol.T0)
            {
                intptr = SCardPCI.T0;
                richTextBoxOutput.AppendText("Current protocol is: T0 \n");
            }
            else if (reader.ActiveProtocol == SCardProtocol.T1)
            {
                intptr = SCardPCI.T1;
                richTextBoxOutput.AppendText("Current protocol is: T1 \n");
            }
            else
                richTextBoxOutput.AppendText("This protocol is not implemented");
            
        }

        private void buttonSelectSMS_Click(object sender, EventArgs e)
        {
            //select telecom
            command = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x7F, 0x10 };
            sendCommand("SELECT TELECOM");

            //get response
            command = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x16 };
            sendCommand("GET RESPONSE");

            //select sms
            command = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x6F, 0x3C };
            sendCommand("SELECT SMS");

            //get response
            command = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x16 };
            sendCommand("GET RESPONSE");

            //read record
            command = new byte[] { 0xA0, 0xB2, 0x01, 0x04, 0xB0 };
            sendCommand("READ RECORD");

            //get response
            command = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x16 };
            sendCommand("GET RESPONSE");

        }

        private void sendCommand(String action)
        {
            SCardPCI receuvePci = new SCardPCI();
            byte[] received = new byte[256];

            error = reader.Transmit(intptr, command, receuvePci, ref received);
            if (error != SCardError.Success)
            {
                richTextBoxOutput.AppendText("Send command " + action + " failed: " + error + "\n");
            }
            else
            {
                richTextBoxOutput.AppendText("Response: ");
                richTextBoxOutput.AppendText("\n");
                for (int q=0; q<received.Length; ++q)
                    richTextBoxOutput.AppendText(received[q] + "  ");

                richTextBoxOutput.AppendText("\n");
            }
        }
    }
}
