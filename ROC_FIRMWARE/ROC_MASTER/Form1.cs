using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Windows.Gaming.Input;
using RichTextBoxMaxLine;
using Timer = System.Windows.Forms.Timer;
using System.Drawing;

// Server 
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace RunJoyStickOnLocalMachine
{
    public partial class Form_ROC_GUI : Form
    {
        // Currently assumes that Rover Starts with theses inital values for drive height & turn radius (Future - could read MCU on startup for current states)
        int turnRadius_State = 360;
        int driveHeight_State = 100;
        enum ROC_State
        {
            Standby,
            Manual,
            Auto,
            Stop_Auto
        }
        enum SteeringMode_State
        {
            Holonomic,
            NonHolonomic,
        }

        UdpClient server;
        IPEndPoint endPoint;

        // Timer for Emergency Stop
        private Timer Emergency_t;

        // Windows.Gaming.Input - Thumbsticks Setup
        private Timer _timer;
        Gamepad controller;
        Timer dispatcherTimer = new Timer();
        private const int _maxLine = 5; // Max no. of lines shown in Thumbsticks output textboxes

        // Windows.Gaming.Input - Button Setup
        Gamepad Controller;
        Timer t = new Timer();
        public Form_ROC_GUI()
        {
            // Checks if connection between MCU to ROC & Controller to ROC is present at start-time
            DebugROC();
            InitializeComponent();

            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = 1000; //Timer for Thumbsticks & Back Throttle
            dispatcherTimer.Start();

            t.Tick += T_Tick;
            t.Interval = 1000; // Timer for Buttons 
            t.Start();
            //Emergency_t.Tick += new EventHandler(_timer_Tick);
            //Emergency_t.Interval = 2000;
            //Emergency_t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _timer = new Timer();
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Interval = 1000; /*Speed of line for output is tabbed down to allow for next output*/
            _timer.Start();

            Standby_State(); // Form loads in Standby Mode
        }
        //---------------------------------------------------------------------
        private bool DebugROC()
        {
            /* Check everything is working first: 
                1. connection to MCU
                2. Controller is connected (Already have this)
            */
            if (Gamepad.Gamepads.Count == 0)
            {
                MessageBox.Show("Error, No Joystick connected!", "Debug Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }
        private ROC_State ROCSTATE { get; set; }    // Read ROC_State, writes to ROCSTATE
        private SteeringMode_State STEERSTATE { get; set; }  // Read SteeringMode_State, writes to STEERSTATE
        private void Standby_State()
        {
            ROCSTATE = ROC_State.Standby;   // Set State to Standby
            // Condition - When no joystick connected add visual description about it
            if (Gamepad.Gamepads.Count == 0)
            {
                output_ROC_MODE.Text = "";
                output_ROC_MODE.Text += "STANDBY - No Joystick Connected";
                output_ROC_MODE.BackColor = Color.Silver;
            }
            else
            {
                // GUI Output in ROC MODE textbox
                output_ROC_MODE.Text = "";
                output_ROC_MODE.Text += "STANDBY";
                output_ROC_MODE.BackColor = Color.Silver;
            }

            /*  1. Ensure MCU Operating mode is in MCU Standby Mode.
                2. Only recieve telemetry from LREV Drive System MCU
                3. Not transmit any commands from GUI or Joystick Controller
            */
        }
        private void Manual_State()
        {
            // GUI visual output feedback
            output_ROC_MODE.Text = "";
            output_ROC_MODE.Text += "MANUAL";
            output_ROC_MODE.BackColor = Color.DeepSkyBlue;

            /*  1. Set MCU operating mode to MCU Remote Control Mode
                2. Only permit commands from Joystick Controller to the LREV Drive System MCU
            */

            // If joystick isn't connected send back to standby state
            if (Gamepad.Gamepads.Count == 0)
            {
                Standby_State();
                return;
            }
                // Read current joystick Input  
                var readCurrent = Controller.GetCurrentReading();
            // If DPaddown or DPadup button is pressed: 
            if ((readCurrent.Buttons == GamepadButtons.DPadDown || readCurrent.Buttons == GamepadButtons.DPadUp))
            {
                // Output in ride height output window the current drive height state
                label_RideHeight.Text = driveHeight_State.ToString();   // Refresh Output
                //  Boundary check for ride height min
                if (readCurrent.Buttons == GamepadButtons.DPadDown && label_RideHeight.Text.ToString() != "0")
                {

                    driveHeight_State -= 10; // Decrease drive height state by 10 increments per button press
                    label_RideHeight.Text = driveHeight_State.ToString();   // Refresh Output
                }
                else if (GamepadButtons.DPadUp == readCurrent.Buttons && label_RideHeight.Text.ToString() != "100")
                {
                    //  Boundary for rideheight max
                    if (driveHeight_State == 100)
                    {
                        // Do Nothing
                    }
                    else
                    {
                        driveHeight_State += 10;    // Increase driveheight state by 10 increments per button press
                        label_RideHeight.Text = driveHeight_State.ToString();   // Refresh Output
                    }
                }
            }
            else if (readCurrent.Buttons == GamepadButtons.DPadLeft || readCurrent.Buttons == GamepadButtons.DPadRight)
            {
                // Output in rideheight output window the current turn radius state
                label_TurnRadius_Output.Text = turnRadius_State.ToString(); // Refresh Output
                //  Boundary check for turn radius min
                if (GamepadButtons.DPadLeft == readCurrent.Buttons && label_TurnRadius_Output.Text.ToString() != "0")
                {
                    turnRadius_State -= 10; // Decrease turn radius state by 10 increments per button press
                    label_TurnRadius_Output.Text = turnRadius_State.ToString(); // Refresh Output
                }
                else if (GamepadButtons.DPadRight == readCurrent.Buttons && label_TurnRadius_Output.Text.ToString() != "360")
                {
                    // Boundary for turn radius max
                    if (turnRadius_State == 100)
                    {
                        // Do Nothing
                    }
                    else
                    {
                        turnRadius_State += 10; // Increase turn radius state by 10 increments per button press
                        label_TurnRadius_Output.Text = turnRadius_State.ToString(); // Refresh Output
                    }
                }
            }
            ROCSTATE = ROC_State.Manual; // Set State to Manual
        }
        private void Auto_State()
        {
            ROCSTATE = ROC_State.Auto;  // Set State to Auto

            // GUI Output
            output_ROC_MODE.Text = "";
            output_ROC_MODE.Text += "AUTO";
            output_ROC_MODE.BackColor = Color.Lime;

            //Only Scripts Should Work Here!

            /*  1. Set MCU operating mode to MCU Remote Control Mode
             *  2. only permit commands from automation-scripts to the REV Drive System MCU
            */
        }
        private void StopAuto_State()
        {
            ROCSTATE = ROC_State.Stop_Auto; // Set State to Stop Auto

            // GUI Output
            output_ROC_MODE.Text = "";
            output_ROC_MODE.Text += "AUTO STOPPED";
            output_ROC_MODE.BackColor = Color.DarkOrange;
        }
        //private void EmergencyStop_State()
        //{
        //    ROCSTATE = ROC_State.Emergency_Stop;

        //    // GUI Output
        //    output_ROC_MODE.Text = "";
        //    output_ROC_MODE.Text += "EMERGENCY STOP";
        //    output_ROC_MODE.BackColor = Color.Red;

        //    /*  1. ROC Master Program shall set MCU Operating Mode to MCU Standby Mode when events occur:
        //     *  a. Joystick COntroller "Emergency Stop" event
        //     *  b. GUI "Emergency Stop" event
        //    */  
        //}
        private void Holonomic_State()
        {
            STEERSTATE = SteeringMode_State.NonHolonomic;   // Set Steering Mode state to Non-holonomic
            Label_SteeringMode_Output.Text = "Non-Holonomic";   // Output in steering mode output window
        }
        private void NonHolonomic_State()
        {
            STEERSTATE = SteeringMode_State.NonHolonomic;   // Set Steering Mode state to Holonomic
            Label_SteeringMode_Output.Text = "Holonomic";   // Output in steering mode output window
        }
        private void createPacket()
        {
            /* Combine all States: 
                1.  MCU Operating Mode Demand
                2. Steering-angle demand (0 to 360deg wrt. LREV Body x-axis)- Thumbstick X Axis Position (Find how often it needs to be outputted- the perfect balance)
                3. Throttle demand - Back Triggers (2) Position
                4. Ride height demand (0 tp 100%)
                5. Turn angle radius demand (0 to 100%)
                6. Set Holonomic or Non-Holonomic Mode
            */
        }
        // System.Windows.Form - Timer 
        private void StopTimer()
        {
            _timer.Stop();
        }
        private void RestartTimer()
        {
            _timer.Enabled = true;
        }
        private void _timer_Tick(object sender, EventArgs e)
        {
            StopTimer();

            // Run in background
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork; ;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        private void _Example_Timer(object sender, EventArgs e)
        {
            StopTimer();
        }
        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RestartTimer();
        }
        // Output thumbstick and back triggers in there respected output windows
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (Gamepad.Gamepads.Count > 0)
            {
                controller = Gamepad.Gamepads.First();
                var reading = controller.GetCurrentReading();

                var DriveDirection = reading.LeftThumbstickX;
                output_Drive_Direction.Text += DriveDirection.ToString("0.##");

                var DriveForward = reading.RightTrigger;
                output_Drive_Forward.Text += DriveForward.ToString("0.##");

                var DriveReverse = reading.LeftTrigger;
                output_Drive_Reverse.Text += DriveReverse.ToString("0.##");
            }
        }
        // Maintains _maxLine No, of outputs displayed in textboxes for thumbstick and back triggers
        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                output_Drive_Direction.AddLine("", _maxLine);
                output_Drive_Direction.ScrollToCaret();

                output_Drive_Forward.AddLine("", _maxLine);
                output_Drive_Forward.ScrollToCaret();

                output_Drive_Reverse.AddLine("", _maxLine);
                output_Drive_Reverse.ScrollToCaret();

            });
        }
        private async void T_Tick(object sender, EventArgs e)
        {
            if (Gamepad.Gamepads.Count > 0)
            {
                Controller = Gamepad.Gamepads.First();
                var REading = Controller.GetCurrentReading(); // Read current joystick input
                // Assign button on Joystick to there respective functions
                switch (REading.Buttons)
                {
                    case GamepadButtons.A:
                        Btn_Manual_Mode_Click(null, null);
                        break;

                    case GamepadButtons.B:
                        Btn_Stop_Auto_Click(null, null);
                        break;

                    case GamepadButtons.X:
                        Btn_Standby_Mode_Click(null, null);
                        break;

                    case GamepadButtons.Y:
                        Btn_Auto_Mode_Click(null, null);
                        break;

                    case GamepadButtons.Menu:
                        Btn_Emergency_Stop_Click(null, null);
                        break;

                    case GamepadButtons.View:
                        Btn_Emergency_Stop_Click(null, null);
                        break;

                    case GamepadButtons.LeftShoulder:
                        Label_SteeringMode_Output_Click(null, null);
                        break;

                    case GamepadButtons.DPadUp:
                        label_RideHeight_Click(null, null);
                        break;

                    case GamepadButtons.DPadDown:
                        label_RideHeight_Click(null, null);
                        break;

                    case GamepadButtons.DPadLeft:
                        label_TurnRadius_Output_Click(null, null);
                        break;

                    case GamepadButtons.DPadRight:
                        label_TurnRadius_Output_Click(null, null);
                        break;
                }
            }
        }
        private void Btn_Emergency_Stop_Click(object sender, EventArgs e)
        {
            Emergency_t = new Timer();
            //Emergency_t.Tick += new EventHandler(_);
            Emergency_t.Interval = 1000; 
            Emergency_t.Start();

            if (Emergency_t.Interval > 0)
            {
                
                output_ROC_MODE.Text = "";
                output_ROC_MODE.Text += "EMERGENCY STOP";
                output_ROC_MODE.BackColor = Color.Red;
                Emergency_t.Stop();
            }
            else if (!Emergency_t.Enabled)
            {
                Standby_State();
            }
            //output_ROC_MODE.Text = "";
            //output_ROC_MODE.Text += "STANDBY";
            //output_ROC_MODE.BackColor = Color.Silver;
        }
        bool steeringModeSwitch = false;
        private void Label_SteeringMode_Output_Click(object sender, EventArgs e)
        {
            // Switch - if its holonomic state, button press will switch to non-holonomic vice versa
            Holonomic_State(); 
            if (steeringModeSwitch == false)
            {
                NonHolonomic_State();
                steeringModeSwitch = true;
            }
            else if (steeringModeSwitch == true)
            {
                Holonomic_State();
                steeringModeSwitch = false;
            }
        }
        private void label_RideHeight_Click(object sender, EventArgs e)
        {
            // Parameter that only allows change in ride height ONLY in ROC Manual State
            if (ROC_State.Manual == ROCSTATE)
            {
                Manual_State();
            }
        }
        private void label_TurnRadius_Output_Click(object sender, EventArgs e)
        {
            // Parameter that only allows change in turn radius ONLY in ROC Manual State
            if (ROC_State.Manual == ROCSTATE)
            {
                Manual_State();
            }
        }
        private void Btn_Stop_Auto_Click(object sender, EventArgs e)
        {
            StopAuto_State();
        }
        private void Btn_Standby_Mode_Click(object sender, EventArgs e)
        {
            Standby_State();
        }
        private void Btn_Manual_Mode_Click(object sender, EventArgs e)
        {
            Manual_State();
        }
        private void Btn_Auto_Mode_Click(object sender, EventArgs e)
        {
            Auto_State();
        }

        private void btn_StartServer_Click(object sender, EventArgs e)
        {
            server = new UdpClient(int.Parse(txtServerPort.Text));
            endPoint = new IPEndPoint(IPAddress.Any, 0);    // Represents network endpoints as an IP Address and port no.

            // Start Server in Seprated Thread to Avoid User Inteface Blocking
            Thread thr = new Thread(new ThreadStart(ServerStart));
            thr.Start();
            btn_StartServer.Enabled = false;

            // Write Server Started
            WriteLog("Action : Server Started Successfully...");
        }
        private void ServerStart()
        {
            // Keep Server Listening
            while (true)
            {
                //byte[] buffer = server.Receive(ref endPoint);
                byte[] buffering = server.Receive(ref endPoint);

                //byte[] sendBytes = Encoding.ASCII.GetBytes("1"); // TEST PURPOSES

                // Message Formate => ClientPortNumber.hostName.Msg
                // Now Split Msg to Array Of Strings
                string[] msg = Encoding.Unicode.GetString(buffering).Split('.');
                int clientPort = int.Parse(msg[0]);
                string clientHostName = msg[1];
                //string request = msg[2];



                // Write Log to Notify Msg Received 
                WriteLog(string.Format("Client at Port : {0} at Host : {1}", clientPort, clientHostName)); // ROC OUTPUT

                //Respond to Client(for e.g send it the Current DateTime in this Server)
                //string response = string.Format("Date time at Server : {0}.", DateTime.Now.ToLocalTime());

                // Respond to Client 
                //buffer = Encoding.Unicode.GetBytes(response);
                //server.Send(buffering, buffering.Length, clientHostName, clientPort);

                // Write Log to Notify Response Sent
                WriteLog(string.Format("Response Sent to Client at Port : {0} at Host : {1}.", clientPort, clientHostName)); // ROC OUTPUT

                // Send State
                //byte[] buffering = server.Receive(ref endPoint);
                //ROCSTATE = ROC_State.Manual;
                string responseROC = string.Format(ROCSTATE.ToString());
                buffering = Encoding.Unicode.GetBytes(responseROC);
                server.Send(buffering, buffering.Length, clientHostName, clientPort);

            }
        }
        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                output_MCU_MODE.Text += string.Format("{0}.{1}", msg, Environment.NewLine);
            });
            this.BeginInvoke(invoker);
        }
        private void output_TextChanged(object sender, EventArgs e)
        {
        }
        private void Output_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        
        private void Panel_Btn_ROC_Mode_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Panel_Btn_MCU_Mode_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Display_MCU_Mode_Click(object sender, EventArgs e)
        {

        }
        private void Label_MCU_Output_Click(object sender, EventArgs e)
        {

        }

        private void Panel_MCU_Data_Joystick_State_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label_MCU_System_Data_Click(object sender, EventArgs e)
        {

        }

        private void Label_ROC_Mode_Click(object sender, EventArgs e)
        {

        }

        private void Label_ROC_Mode_Output_Click(object sender, EventArgs e)
        {

        }

        private void Label_Encoder_Telemetry_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void output_MCU_MODE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
