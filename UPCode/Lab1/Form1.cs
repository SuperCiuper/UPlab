using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTD2XX_NET;
using System.Threading;

namespace Lab1_silnik_krokowy
{
    public partial class Form1 : Form
    {
        FTDI device = new FTDI();
        byte[] motorOne = { 0x08, 0x02, 0x04, 0x01 };
        byte[] motorTwo = { 0x80, 0x20, 0x40, 0x10 };
        byte[] end = { 0x00 };
        int currentPosition = 0;
        UInt32 bytesToBeWritten = 0;
        bool connected;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                device.OpenByDescription("usb step motor");
                device.SetBitMode(0xff, 1);
                //write line success
                richTextBoxOutput.AppendText("Connected to motor \n");
                connected = true;
            }
            catch (Exception error)
            {
                richTextBoxOutput.AppendText("Connection error \n");
            }
        }

        private void buttonSOneLeftOne_Click(object sender, EventArgs e)
        {
            step(1, false, true);
        }

        private void buttonSOneRightOne_Click(object sender, EventArgs e)
        {
            step(1, true, true);
        }

        private void buttonSTwoLeftOne_Click(object sender, EventArgs e)
        {
            step(1, false, false);
        }

        private void buttonSTwoRightOne_Click(object sender, EventArgs e)
        {
            step(1, true, false);
        }

        private void buttonMOneLeftN_Click(object sender, EventArgs e)
        {
            step(Convert.ToInt32(numericUpDownSteps.Value), false, true);
        }

        private void buttonMOneRightN_Click(object sender, EventArgs e)
        {
            step(Convert.ToInt32(numericUpDownSteps.Value), true, true);
        }

        private void buttonMTwoLeftN_Click(object sender, EventArgs e)
        {
            step(Convert.ToInt32(numericUpDownSteps.Value), false, false);
        }

        private void buttonMTwoRightN_Click(object sender, EventArgs e)
        {
            step(Convert.ToInt32(numericUpDownSteps.Value), true, false);
        }

        private void step(int numberOfSteps, bool right, bool motorOneOn)
        {
            double sleep = Convert.ToDouble(numericUpDownSpeed.Value) * 1000;
            for (int i = 0; i < numberOfSteps; ++i)
            {
                if (right)
                {
                    currentPosition -= 1;
                }
                else currentPosition += 1;
                if (currentPosition > 3)
                {
                    currentPosition = 0;
                }
                if (currentPosition < 0)
                {
                    currentPosition = 3;
                }
                byte[] instruction = new byte[1];
                if (motorOneOn)
                    instruction[0] = motorOne[currentPosition];

                else
                    instruction[0] = motorTwo[currentPosition];

                if (connected)
                    device.Write(instruction, 1, ref bytesToBeWritten);

                Thread.Sleep(Convert.ToInt32(sleep));

            }
            if (connected)
                device.Write(end, 1, ref bytesToBeWritten);
        }

        private void twoSideMove(int numberOfSteps, bool right, bool blabla)
        {
            double sleep = Convert.ToDouble(numericUpDownSpeed.Value) * 1000;
            int actPosition = currentPosition;
            for (int i = 0; i < numberOfSteps; ++i)
            {
                if (right)
                {
                    currentPosition -= 1;

                    if (blabla)
                        actPosition += 1;

                    else
                        actPosition -= 1;
                }
                else
                {
                    currentPosition += 1;

                    if (blabla)
                        actPosition -= 1;

                    else
                        actPosition += 1;
                }

                if (currentPosition > 3)
                    currentPosition = 0;

                if (currentPosition < 0)
                    currentPosition = 3;

                if (actPosition > 3)
                    actPosition = 0;

                if (actPosition < 0)
                    actPosition = 3;

                byte[] instruction = new byte[1];

                instruction[0] = Convert.ToByte(motorOne[actPosition] + motorTwo[currentPosition]);

                if (connected)
                    device.Write(instruction, 1, ref bytesToBeWritten);

                Thread.Sleep(Convert.ToInt32(sleep));

            }
            if (connected)
                device.Write(end, 1, ref bytesToBeWritten);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            twoSideMove(10, false, false);
            twoSideMove(10, true, false);
            twoSideMove(10, true, true);
            twoSideMove(10, false, true);
        }
    }
}
