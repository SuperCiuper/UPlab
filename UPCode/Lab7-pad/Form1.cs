using SharpDX.DirectInput;
using System;
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
        private int oldXVal = 32767;
        private DirectInput directInput;
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
            //pollJoystick();
            richTextBoxConsole.AppendText(Cursor.Position.X.ToString() + " " + Cursor.Position.Y.ToString());
        }

        private void pollJoystick() {
            JoystickState state = new JoystickState();
            state = gamepad.GetCurrentState();

            int xVal = state.X;
            int yVal = state.Y;

            textBoxX.Text = xVal.ToString();
            textBoxY.Text = yVal.ToString();

            if (xVal < oldXVal) {
                trackBarX.Value--;
            } else if (xVal > oldXVal) {
                trackBarX.Value++;
            }

            bool buttonOne = state.Buttons[0];
            if (buttonOne) {
                radioButtonBlue.Enabled = true;
                richTextBoxConsole.AppendText("Red color selected" + "\n");
            }

            var buttonTwo = state.Buttons[1];
            if (buttonTwo) {
                radioButtonGreen.Enabled = true;
                richTextBoxConsole.AppendText("Green color selected" + "\n");
            }

            var buttonThree = state.Buttons[2];
            if (buttonThree) {
                radioButtonRed.Enabled = true;
                richTextBoxConsole.AppendText("Red color selected" + "\n");
            }
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e) {

        }
    }
}
