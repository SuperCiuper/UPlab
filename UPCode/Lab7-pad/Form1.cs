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
        private int width = 6;
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
        }

        private void pollJoystick() {
            JoystickState state = new JoystickState();
            state = gamepad.GetCurrentState();


            if (state.X == zeroPoint) {
                xVal = 0;
                trackBarX.Value = 50;
            } else if (state.X < zeroPoint) {
                xVal = -2;
                trackBarX.Value = 0;
            } else {
                xVal = 2;
                trackBarX.Value = 100;
            }

            if (state.Y == zeroPoint)
                yVal = 0;

            else if (state.Y < zeroPoint)
                yVal = -2;

            else yVal = 2;

            textBoxX.Text = state.X.ToString();
            textBoxY.Text = state.Y.ToString();

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

            if (state.Buttons[4]) {
                if (radioButtonBlue.Checked) {
                    if (numericUpDownBlue.Value < 251) numericUpDownBlue.Value += 5;
                }
                if (radioButtonRed.Checked) {
                    if (numericUpDownRed.Value < 251) numericUpDownRed.Value += 5;
                }
                if (radioButtonGreen.Checked) {
                    if (numericUpDownGreen.Value < 251) numericUpDownGreen.Value += 5;
                }
            }

            if (state.Buttons[5]) {
                if (radioButtonBlue.Checked) {
                    if (numericUpDownBlue.Value > 4) numericUpDownBlue.Value -= 5;
                }
                if (radioButtonRed.Checked) {
                    if (numericUpDownRed.Value > 4) numericUpDownRed.Value -= 5;
                }
                if (radioButtonGreen.Checked) {
                    if (numericUpDownGreen.Value > 4) numericUpDownGreen.Value -= 5;
                }
            }

            if (state.Buttons[6]) {
                panelCanvas.Invalidate();
            }

            solidBrush = new SolidBrush(Color.FromArgb(255, Convert.ToInt32(numericUpDownRed.Value), Convert.ToInt32(numericUpDownGreen.Value), Convert.ToInt32(numericUpDownBlue.Value)));
            moveMouse(xVal, yVal);
        }

        public void moveMouse(int posx, int posy) {
            Cursor.Position = new Point(Cursor.Position.X + (posx * 2), Cursor.Position.Y + (posy * 2));
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e) {
            if (painting) {
                //richTextBoxConsole.AppendText("XD ");
                graphics = panelCanvas.CreateGraphics();
                graphics.FillEllipse(solidBrush, e.X, e.Y, width, width);
            }
        }
    }
}