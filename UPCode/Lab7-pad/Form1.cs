using SharpDX.DirectInput;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_pad {
    public partial class Form1 : Form {
        private Joystick gamepad;
        private int lastButtonSelected;
        private int oldXVal = 32767;
        private DirectInput directInput;
        private bool painting = true;
        private Graphics graphics;
        private SolidBrush solidBrush;
        private int width = 5;
        private int zeroPoint = 32767;
        private int xVal = 32767;
        private int yVal = 32767;

        public Form1() {
            InitializeComponent();
            connectJoystick();
            timer.Enabled = true;
        }

        private void connectJoystick() {
            // Initialize DirectInput
            directInput = new DirectInput();

            // Find all gamepads connected to the system
            IList<DeviceInstance> connectedGamepads = new List<DeviceInstance>();
            // - look for gamepads
            foreach (DeviceInstance deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices)) {
                connectedGamepads.Add(deviceInstance);
            }
            // - look for joysticks
            foreach (DeviceInstance deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices)) {
                connectedGamepads.Add(deviceInstance);
            }

            // Use the gamepad found
            if (connectedGamepads.Count >= 1) {
                gamepad = new Joystick(directInput, connectedGamepads[0].InstanceGuid);
                gamepad.Acquire();
                richTextBoxConsole.AppendText("Połączono z padem: " + connectedGamepads[0].InstanceName + "\n");
            } else {
                richTextBoxConsole.AppendText("Nie znaleziono padów!" + "\n");
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            pollJoystick();
            //richTextBoxConsole.AppendText(Cursor.Position.X.ToString() + " " + Cursor.Position.Y.ToString());
            //solidBrush = new SolidBrush(Color.FromArgb(255, Convert.ToInt32(numericUpDownRed.Value), Convert.ToInt32(numericUpDownGreen.Value), Convert.ToInt32(numericUpDownBlue.Value)));
        }

        private void pollJoystick() {
            JoystickState state = new JoystickState();
            state = gamepad.GetCurrentState();

            if (state.X == zeroPoint)
                xVal = 0;

            else if (state.X < zeroPoint)
                xVal = -2;

            else xVal = 2;

            if (state.Y == zeroPoint)
                yVal = 0;

            else if (state.Y < zeroPoint)
                yVal = -2;

            else yVal = 2;

            MouseMove(xVal, yVal);

            textBoxX.Text = xVal.ToString();
            textBoxY.Text = yVal.ToString();

            if (xVal < oldXVal) {
                trackBarX.Value--;
            } else if (xVal > oldXVal) {
                trackBarX.Value++;
            }

            if (state.Buttons[0] && lastButtonSelected != 0) {
                radioButtonBlue.Checked = true;
                richTextBoxConsole.AppendText("Blue color selected" + "\n");
                lastButtonSelected = 0;
            }

            if (state.Buttons[1] && lastButtonSelected != 1) {
                radioButtonGreen.Checked = true;
                richTextBoxConsole.AppendText("Green color selected" + "\n");
                lastButtonSelected = 1;
            }

            if (state.Buttons[2] && lastButtonSelected != 2) {
                radioButtonRed.Checked = true;
                richTextBoxConsole.AppendText("Red color selected" + "\n");
                lastButtonSelected = 2;
            }

            if (state.Buttons[3]) {
                painting = true;
            } else {
                painting = false;
            }

            solidBrush = new SolidBrush(Color.FromArgb(255, Convert.ToInt32(numericUpDownRed.Value), Convert.ToInt32(numericUpDownGreen.Value), Convert.ToInt32(numericUpDownBlue.Value)));
        }

        public void MouseMove(int posx, int posy) {
            Cursor.Position = new Point(Cursor.Position.X + posx, Cursor.Position.Y + posy);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e) {
            if (painting) {
                graphics = panelCanvas.CreateGraphics();
                graphics.FillEllipse(solidBrush, e.X, e.Y, width, width);
            }
        }
    }
}