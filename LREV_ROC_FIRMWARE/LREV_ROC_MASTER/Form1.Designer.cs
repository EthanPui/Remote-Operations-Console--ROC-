namespace RunJoyStickOnLocalMachine
{
    partial class Form_ROC_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ROC_GUI));
            this.joystickTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Panel_Logo = new System.Windows.Forms.TableLayoutPanel();
            this.label_MCU_MODE = new System.Windows.Forms.Label();
            this.label_ROC_MODE = new System.Windows.Forms.Label();
            this.output_MCU_MODE = new System.Windows.Forms.RichTextBox();
            this.output_ROC_MODE = new System.Windows.Forms.RichTextBox();
            this.Panel_MCU_Data_Joystick_State = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Encoder_Telemetry = new System.Windows.Forms.Label();
            this.Label_FrontLeft = new System.Windows.Forms.Label();
            this.Label_FrontRight = new System.Windows.Forms.Label();
            this.Label_Wheel_FrontLeft = new System.Windows.Forms.Label();
            this.Label_Wheel_FrontRight = new System.Windows.Forms.Label();
            this.Label_Elbow_FrontLeft = new System.Windows.Forms.Label();
            this.Label_Elbow_FrontRight = new System.Windows.Forms.Label();
            this.Label_Shoulder_FrontLeft = new System.Windows.Forms.Label();
            this.Label_Shoulder_FrontRight = new System.Windows.Forms.Label();
            this.Label_MiddleLeft = new System.Windows.Forms.Label();
            this.Label_MiddleRight = new System.Windows.Forms.Label();
            this.Label_RearLeft = new System.Windows.Forms.Label();
            this.Label_RearRight = new System.Windows.Forms.Label();
            this.Label_Wheel_MiddleLeft = new System.Windows.Forms.Label();
            this.Label_Elbow_MiddleLeft = new System.Windows.Forms.Label();
            this.Label_Shoulder_MiddleLeft = new System.Windows.Forms.Label();
            this.Label_Wheel_RearLeft = new System.Windows.Forms.Label();
            this.Label_Elbow_RearLeft = new System.Windows.Forms.Label();
            this.Label_Shoulder_RearLeft = new System.Windows.Forms.Label();
            this.Label_Wheel_MiddleRight = new System.Windows.Forms.Label();
            this.Label_Elbow_MiddleRight = new System.Windows.Forms.Label();
            this.Label_Shoulder_MiddleRight = new System.Windows.Forms.Label();
            this.Label_Wheel_RearRight = new System.Windows.Forms.Label();
            this.Label_Elbow_RearRight = new System.Windows.Forms.Label();
            this.Label_Shoulder_RearRight = new System.Windows.Forms.Label();
            this.Panel_Btn_MCU_Mode = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Drive_Power = new System.Windows.Forms.Label();
            this.Label_Drive_Direction = new System.Windows.Forms.Label();
            this.Label_Steering_Mode = new System.Windows.Forms.Label();
            this.Label_RideHeight_Output = new System.Windows.Forms.Label();
            this.label_RideHeight = new System.Windows.Forms.Label();
            this.Label_SteeringMode_Output = new System.Windows.Forms.Label();
            this.output_Drive_Reverse = new System.Windows.Forms.RichTextBox();
            this.output_Drive_Forward = new System.Windows.Forms.RichTextBox();
            this.output_Drive_Direction = new System.Windows.Forms.RichTextBox();
            this.label_TurnRadius = new System.Windows.Forms.Label();
            this.label_TurnRadius_Output = new System.Windows.Forms.Label();
            this.Btn_Emergency_Stop = new System.Windows.Forms.Button();
            this.Panel_Btn_ROC_Mode = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Standby_Mode = new System.Windows.Forms.Button();
            this.Btn_Stop_Auto = new System.Windows.Forms.Button();
            this.Btn_Manual_Mode = new System.Windows.Forms.Button();
            this.Btn_Auto_Mode = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.Label_serverport = new System.Windows.Forms.Label();
            this.btn_StartServer = new System.Windows.Forms.Button();
            this.Panel_Logo.SuspendLayout();
            this.Panel_MCU_Data_Joystick_State.SuspendLayout();
            this.Panel_Btn_MCU_Mode.SuspendLayout();
            this.Panel_Btn_ROC_Mode.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Logo.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.Panel_Logo, 2);
            this.Panel_Logo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_Logo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel_Logo.Controls.Add(this.label_MCU_MODE, 1, 1);
            this.Panel_Logo.Controls.Add(this.label_ROC_MODE, 0, 1);
            this.Panel_Logo.Controls.Add(this.output_MCU_MODE, 1, 0);
            this.Panel_Logo.Controls.Add(this.output_ROC_MODE, 0, 0);
            this.Panel_Logo.ForeColor = System.Drawing.Color.White;
            this.Panel_Logo.Location = new System.Drawing.Point(234, 57);
            this.Panel_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.Panel_Logo, 2);
            this.Panel_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Panel_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Logo.Size = new System.Drawing.Size(548, 471);
            this.Panel_Logo.TabIndex = 9;
            // 
            // label_MCU_MODE
            // 
            this.label_MCU_MODE.AutoSize = true;
            this.label_MCU_MODE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_MCU_MODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MCU_MODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label_MCU_MODE.Location = new System.Drawing.Point(277, 376);
            this.label_MCU_MODE.Name = "label_MCU_MODE";
            this.label_MCU_MODE.Size = new System.Drawing.Size(268, 95);
            this.label_MCU_MODE.TabIndex = 10;
            this.label_MCU_MODE.Text = "MCU MODE";
            this.label_MCU_MODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ROC_MODE
            // 
            this.label_ROC_MODE.AutoSize = true;
            this.label_ROC_MODE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ROC_MODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ROC_MODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label_ROC_MODE.Location = new System.Drawing.Point(3, 376);
            this.label_ROC_MODE.Name = "label_ROC_MODE";
            this.label_ROC_MODE.Size = new System.Drawing.Size(268, 95);
            this.label_ROC_MODE.TabIndex = 11;
            this.label_ROC_MODE.Text = "ROC MODE";
            this.label_ROC_MODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output_MCU_MODE
            // 
            this.output_MCU_MODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_MCU_MODE.Location = new System.Drawing.Point(277, 2);
            this.output_MCU_MODE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output_MCU_MODE.Name = "output_MCU_MODE";
            this.output_MCU_MODE.Size = new System.Drawing.Size(268, 372);
            this.output_MCU_MODE.TabIndex = 13;
            this.output_MCU_MODE.Text = "";
            this.output_MCU_MODE.TextChanged += new System.EventHandler(this.output_MCU_MODE_TextChanged);
            // 
            // output_ROC_MODE
            // 
            this.output_ROC_MODE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output_ROC_MODE.BackColor = System.Drawing.SystemColors.Window;
            this.output_ROC_MODE.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_ROC_MODE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.output_ROC_MODE.Location = new System.Drawing.Point(3, 2);
            this.output_ROC_MODE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output_ROC_MODE.MaxLength = 15;
            this.output_ROC_MODE.Name = "output_ROC_MODE";
            this.output_ROC_MODE.Size = new System.Drawing.Size(268, 372);
            this.output_ROC_MODE.TabIndex = 12;
            this.output_ROC_MODE.Text = "";
            // 
            // Panel_MCU_Data_Joystick_State
            // 
            this.Panel_MCU_Data_Joystick_State.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_MCU_Data_Joystick_State.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Panel_MCU_Data_Joystick_State.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.Panel_MCU_Data_Joystick_State, 3);
            this.Panel_MCU_Data_Joystick_State.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel_MCU_Data_Joystick_State.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel_MCU_Data_Joystick_State.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel_MCU_Data_Joystick_State.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Encoder_Telemetry, 0, 0);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_FrontLeft, 0, 1);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_FrontRight, 2, 1);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Wheel_FrontLeft, 0, 2);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Wheel_FrontRight, 2, 2);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Elbow_FrontLeft, 0, 3);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Elbow_FrontRight, 2, 3);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Shoulder_FrontLeft, 0, 4);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Shoulder_FrontRight, 2, 4);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_MiddleLeft, 0, 5);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_MiddleRight, 2, 5);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_RearLeft, 0, 9);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_RearRight, 2, 9);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Wheel_MiddleLeft, 0, 6);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Elbow_MiddleLeft, 0, 7);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Shoulder_MiddleLeft, 0, 8);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Wheel_RearLeft, 0, 10);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Elbow_RearLeft, 0, 11);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Shoulder_RearLeft, 0, 12);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Wheel_MiddleRight, 2, 6);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Elbow_MiddleRight, 2, 7);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Shoulder_MiddleRight, 2, 8);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Wheel_RearRight, 2, 10);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Elbow_RearRight, 2, 11);
            this.Panel_MCU_Data_Joystick_State.Controls.Add(this.Label_Shoulder_RearRight, 2, 12);
            this.Panel_MCU_Data_Joystick_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_MCU_Data_Joystick_State.ForeColor = System.Drawing.Color.White;
            this.Panel_MCU_Data_Joystick_State.Location = new System.Drawing.Point(788, 57);
            this.Panel_MCU_Data_Joystick_State.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_MCU_Data_Joystick_State.Name = "Panel_MCU_Data_Joystick_State";
            this.Panel_MCU_Data_Joystick_State.RowCount = 13;
            this.tableLayoutPanel1.SetRowSpan(this.Panel_MCU_Data_Joystick_State, 2);
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.Panel_MCU_Data_Joystick_State.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.246377F));
            this.Panel_MCU_Data_Joystick_State.Size = new System.Drawing.Size(398, 471);
            this.Panel_MCU_Data_Joystick_State.TabIndex = 6;
            this.Panel_MCU_Data_Joystick_State.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_MCU_Data_Joystick_State_Paint);
            // 
            // Label_Encoder_Telemetry
            // 
            this.Label_Encoder_Telemetry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Encoder_Telemetry.AutoSize = true;
            this.Label_Encoder_Telemetry.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Label_Encoder_Telemetry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_MCU_Data_Joystick_State.SetColumnSpan(this.Label_Encoder_Telemetry, 4);
            this.Label_Encoder_Telemetry.ForeColor = System.Drawing.Color.Black;
            this.Label_Encoder_Telemetry.Location = new System.Drawing.Point(4, 1);
            this.Label_Encoder_Telemetry.Name = "Label_Encoder_Telemetry";
            this.Label_Encoder_Telemetry.Size = new System.Drawing.Size(390, 39);
            this.Label_Encoder_Telemetry.TabIndex = 0;
            this.Label_Encoder_Telemetry.Text = "Encoder Telemetry";
            this.Label_Encoder_Telemetry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Encoder_Telemetry.Click += new System.EventHandler(this.Label_Encoder_Telemetry_Click);
            // 
            // Label_FrontLeft
            // 
            this.Label_FrontLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_FrontLeft.AutoSize = true;
            this.Label_FrontLeft.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel_MCU_Data_Joystick_State.SetColumnSpan(this.Label_FrontLeft, 2);
            this.Label_FrontLeft.ForeColor = System.Drawing.Color.Black;
            this.Label_FrontLeft.Location = new System.Drawing.Point(4, 41);
            this.Label_FrontLeft.Name = "Label_FrontLeft";
            this.Label_FrontLeft.Size = new System.Drawing.Size(191, 39);
            this.Label_FrontLeft.TabIndex = 1;
            this.Label_FrontLeft.Text = "Front Left";
            this.Label_FrontLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_FrontRight
            // 
            this.Label_FrontRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_FrontRight.AutoSize = true;
            this.Label_FrontRight.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel_MCU_Data_Joystick_State.SetColumnSpan(this.Label_FrontRight, 2);
            this.Label_FrontRight.ForeColor = System.Drawing.Color.Black;
            this.Label_FrontRight.Location = new System.Drawing.Point(202, 41);
            this.Label_FrontRight.Name = "Label_FrontRight";
            this.Label_FrontRight.Size = new System.Drawing.Size(192, 39);
            this.Label_FrontRight.TabIndex = 2;
            this.Label_FrontRight.Text = "Front Right";
            this.Label_FrontRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Wheel_FrontLeft
            // 
            this.Label_Wheel_FrontLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Wheel_FrontLeft.AutoSize = true;
            this.Label_Wheel_FrontLeft.Location = new System.Drawing.Point(4, 81);
            this.Label_Wheel_FrontLeft.Name = "Label_Wheel_FrontLeft";
            this.Label_Wheel_FrontLeft.Size = new System.Drawing.Size(92, 33);
            this.Label_Wheel_FrontLeft.TabIndex = 3;
            this.Label_Wheel_FrontLeft.Text = "Wheel";
            this.Label_Wheel_FrontLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Wheel_FrontRight
            // 
            this.Label_Wheel_FrontRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Wheel_FrontRight.AutoSize = true;
            this.Label_Wheel_FrontRight.Location = new System.Drawing.Point(202, 81);
            this.Label_Wheel_FrontRight.Name = "Label_Wheel_FrontRight";
            this.Label_Wheel_FrontRight.Size = new System.Drawing.Size(92, 33);
            this.Label_Wheel_FrontRight.TabIndex = 4;
            this.Label_Wheel_FrontRight.Text = "Wheel";
            this.Label_Wheel_FrontRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Elbow_FrontLeft
            // 
            this.Label_Elbow_FrontLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Elbow_FrontLeft.AutoSize = true;
            this.Label_Elbow_FrontLeft.Location = new System.Drawing.Point(4, 115);
            this.Label_Elbow_FrontLeft.Name = "Label_Elbow_FrontLeft";
            this.Label_Elbow_FrontLeft.Size = new System.Drawing.Size(92, 33);
            this.Label_Elbow_FrontLeft.TabIndex = 5;
            this.Label_Elbow_FrontLeft.Text = "Elbow";
            this.Label_Elbow_FrontLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Elbow_FrontRight
            // 
            this.Label_Elbow_FrontRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Elbow_FrontRight.AutoSize = true;
            this.Label_Elbow_FrontRight.Location = new System.Drawing.Point(202, 115);
            this.Label_Elbow_FrontRight.Name = "Label_Elbow_FrontRight";
            this.Label_Elbow_FrontRight.Size = new System.Drawing.Size(92, 33);
            this.Label_Elbow_FrontRight.TabIndex = 6;
            this.Label_Elbow_FrontRight.Text = "Elbow";
            this.Label_Elbow_FrontRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Shoulder_FrontLeft
            // 
            this.Label_Shoulder_FrontLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Shoulder_FrontLeft.AutoSize = true;
            this.Label_Shoulder_FrontLeft.Location = new System.Drawing.Point(4, 149);
            this.Label_Shoulder_FrontLeft.Name = "Label_Shoulder_FrontLeft";
            this.Label_Shoulder_FrontLeft.Size = new System.Drawing.Size(92, 33);
            this.Label_Shoulder_FrontLeft.TabIndex = 7;
            this.Label_Shoulder_FrontLeft.Text = "Shoulder";
            this.Label_Shoulder_FrontLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Shoulder_FrontRight
            // 
            this.Label_Shoulder_FrontRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Shoulder_FrontRight.AutoSize = true;
            this.Label_Shoulder_FrontRight.Location = new System.Drawing.Point(202, 149);
            this.Label_Shoulder_FrontRight.Name = "Label_Shoulder_FrontRight";
            this.Label_Shoulder_FrontRight.Size = new System.Drawing.Size(92, 33);
            this.Label_Shoulder_FrontRight.TabIndex = 8;
            this.Label_Shoulder_FrontRight.Text = "Shoulder";
            this.Label_Shoulder_FrontRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_MiddleLeft
            // 
            this.Label_MiddleLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_MiddleLeft.AutoSize = true;
            this.Label_MiddleLeft.BackColor = System.Drawing.Color.MediumOrchid;
            this.Panel_MCU_Data_Joystick_State.SetColumnSpan(this.Label_MiddleLeft, 2);
            this.Label_MiddleLeft.ForeColor = System.Drawing.Color.Black;
            this.Label_MiddleLeft.Location = new System.Drawing.Point(4, 183);
            this.Label_MiddleLeft.Name = "Label_MiddleLeft";
            this.Label_MiddleLeft.Size = new System.Drawing.Size(191, 39);
            this.Label_MiddleLeft.TabIndex = 9;
            this.Label_MiddleLeft.Text = "Middle Left";
            this.Label_MiddleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_MiddleRight
            // 
            this.Label_MiddleRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_MiddleRight.AutoSize = true;
            this.Label_MiddleRight.BackColor = System.Drawing.Color.MediumOrchid;
            this.Panel_MCU_Data_Joystick_State.SetColumnSpan(this.Label_MiddleRight, 2);
            this.Label_MiddleRight.ForeColor = System.Drawing.Color.Black;
            this.Label_MiddleRight.Location = new System.Drawing.Point(202, 183);
            this.Label_MiddleRight.Name = "Label_MiddleRight";
            this.Label_MiddleRight.Size = new System.Drawing.Size(192, 39);
            this.Label_MiddleRight.TabIndex = 10;
            this.Label_MiddleRight.Text = "Middle Right";
            this.Label_MiddleRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_RearLeft
            // 
            this.Label_RearLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RearLeft.AutoSize = true;
            this.Label_RearLeft.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Panel_MCU_Data_Joystick_State.SetColumnSpan(this.Label_RearLeft, 2);
            this.Label_RearLeft.ForeColor = System.Drawing.Color.Black;
            this.Label_RearLeft.Location = new System.Drawing.Point(4, 325);
            this.Label_RearLeft.Name = "Label_RearLeft";
            this.Label_RearLeft.Size = new System.Drawing.Size(191, 39);
            this.Label_RearLeft.TabIndex = 11;
            this.Label_RearLeft.Text = "Rear Left";
            this.Label_RearLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_RearRight
            // 
            this.Label_RearRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RearRight.AutoSize = true;
            this.Label_RearRight.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Panel_MCU_Data_Joystick_State.SetColumnSpan(this.Label_RearRight, 2);
            this.Label_RearRight.ForeColor = System.Drawing.Color.Black;
            this.Label_RearRight.Location = new System.Drawing.Point(202, 325);
            this.Label_RearRight.Name = "Label_RearRight";
            this.Label_RearRight.Size = new System.Drawing.Size(192, 39);
            this.Label_RearRight.TabIndex = 12;
            this.Label_RearRight.Text = "Rear Right";
            this.Label_RearRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Wheel_MiddleLeft
            // 
            this.Label_Wheel_MiddleLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Wheel_MiddleLeft.AutoSize = true;
            this.Label_Wheel_MiddleLeft.Location = new System.Drawing.Point(4, 223);
            this.Label_Wheel_MiddleLeft.Name = "Label_Wheel_MiddleLeft";
            this.Label_Wheel_MiddleLeft.Size = new System.Drawing.Size(92, 33);
            this.Label_Wheel_MiddleLeft.TabIndex = 13;
            this.Label_Wheel_MiddleLeft.Text = "Wheel";
            this.Label_Wheel_MiddleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Elbow_MiddleLeft
            // 
            this.Label_Elbow_MiddleLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Elbow_MiddleLeft.AutoSize = true;
            this.Label_Elbow_MiddleLeft.Location = new System.Drawing.Point(4, 257);
            this.Label_Elbow_MiddleLeft.Name = "Label_Elbow_MiddleLeft";
            this.Label_Elbow_MiddleLeft.Size = new System.Drawing.Size(92, 33);
            this.Label_Elbow_MiddleLeft.TabIndex = 14;
            this.Label_Elbow_MiddleLeft.Text = "Elbow";
            this.Label_Elbow_MiddleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Shoulder_MiddleLeft
            // 
            this.Label_Shoulder_MiddleLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Shoulder_MiddleLeft.AutoSize = true;
            this.Label_Shoulder_MiddleLeft.Location = new System.Drawing.Point(4, 291);
            this.Label_Shoulder_MiddleLeft.Name = "Label_Shoulder_MiddleLeft";
            this.Label_Shoulder_MiddleLeft.Size = new System.Drawing.Size(92, 33);
            this.Label_Shoulder_MiddleLeft.TabIndex = 15;
            this.Label_Shoulder_MiddleLeft.Text = "Shoulder";
            this.Label_Shoulder_MiddleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Wheel_RearLeft
            // 
            this.Label_Wheel_RearLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Wheel_RearLeft.AutoSize = true;
            this.Label_Wheel_RearLeft.Location = new System.Drawing.Point(4, 365);
            this.Label_Wheel_RearLeft.Name = "Label_Wheel_RearLeft";
            this.Label_Wheel_RearLeft.Size = new System.Drawing.Size(92, 33);
            this.Label_Wheel_RearLeft.TabIndex = 16;
            this.Label_Wheel_RearLeft.Text = "Wheel";
            this.Label_Wheel_RearLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Elbow_RearLeft
            // 
            this.Label_Elbow_RearLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Elbow_RearLeft.AutoSize = true;
            this.Label_Elbow_RearLeft.Location = new System.Drawing.Point(4, 399);
            this.Label_Elbow_RearLeft.Name = "Label_Elbow_RearLeft";
            this.Label_Elbow_RearLeft.Size = new System.Drawing.Size(92, 33);
            this.Label_Elbow_RearLeft.TabIndex = 17;
            this.Label_Elbow_RearLeft.Text = "Elbow";
            this.Label_Elbow_RearLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Shoulder_RearLeft
            // 
            this.Label_Shoulder_RearLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Shoulder_RearLeft.AutoSize = true;
            this.Label_Shoulder_RearLeft.Location = new System.Drawing.Point(4, 433);
            this.Label_Shoulder_RearLeft.Name = "Label_Shoulder_RearLeft";
            this.Label_Shoulder_RearLeft.Size = new System.Drawing.Size(92, 37);
            this.Label_Shoulder_RearLeft.TabIndex = 18;
            this.Label_Shoulder_RearLeft.Text = "Shoulder";
            this.Label_Shoulder_RearLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Wheel_MiddleRight
            // 
            this.Label_Wheel_MiddleRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Wheel_MiddleRight.AutoSize = true;
            this.Label_Wheel_MiddleRight.Location = new System.Drawing.Point(202, 223);
            this.Label_Wheel_MiddleRight.Name = "Label_Wheel_MiddleRight";
            this.Label_Wheel_MiddleRight.Size = new System.Drawing.Size(92, 33);
            this.Label_Wheel_MiddleRight.TabIndex = 19;
            this.Label_Wheel_MiddleRight.Text = "Wheel";
            this.Label_Wheel_MiddleRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Elbow_MiddleRight
            // 
            this.Label_Elbow_MiddleRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Elbow_MiddleRight.AutoSize = true;
            this.Label_Elbow_MiddleRight.Location = new System.Drawing.Point(202, 257);
            this.Label_Elbow_MiddleRight.Name = "Label_Elbow_MiddleRight";
            this.Label_Elbow_MiddleRight.Size = new System.Drawing.Size(92, 33);
            this.Label_Elbow_MiddleRight.TabIndex = 20;
            this.Label_Elbow_MiddleRight.Text = "Elbow";
            this.Label_Elbow_MiddleRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Shoulder_MiddleRight
            // 
            this.Label_Shoulder_MiddleRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Shoulder_MiddleRight.AutoSize = true;
            this.Label_Shoulder_MiddleRight.Location = new System.Drawing.Point(202, 291);
            this.Label_Shoulder_MiddleRight.Name = "Label_Shoulder_MiddleRight";
            this.Label_Shoulder_MiddleRight.Size = new System.Drawing.Size(92, 33);
            this.Label_Shoulder_MiddleRight.TabIndex = 21;
            this.Label_Shoulder_MiddleRight.Text = "Shoulder";
            this.Label_Shoulder_MiddleRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Wheel_RearRight
            // 
            this.Label_Wheel_RearRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Wheel_RearRight.AutoSize = true;
            this.Label_Wheel_RearRight.Location = new System.Drawing.Point(202, 365);
            this.Label_Wheel_RearRight.Name = "Label_Wheel_RearRight";
            this.Label_Wheel_RearRight.Size = new System.Drawing.Size(92, 33);
            this.Label_Wheel_RearRight.TabIndex = 22;
            this.Label_Wheel_RearRight.Text = "Wheel";
            this.Label_Wheel_RearRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Elbow_RearRight
            // 
            this.Label_Elbow_RearRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Elbow_RearRight.AutoSize = true;
            this.Label_Elbow_RearRight.Location = new System.Drawing.Point(202, 399);
            this.Label_Elbow_RearRight.Name = "Label_Elbow_RearRight";
            this.Label_Elbow_RearRight.Size = new System.Drawing.Size(92, 33);
            this.Label_Elbow_RearRight.TabIndex = 23;
            this.Label_Elbow_RearRight.Text = "Elbow";
            this.Label_Elbow_RearRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Shoulder_RearRight
            // 
            this.Label_Shoulder_RearRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Shoulder_RearRight.AutoSize = true;
            this.Label_Shoulder_RearRight.Location = new System.Drawing.Point(202, 433);
            this.Label_Shoulder_RearRight.Name = "Label_Shoulder_RearRight";
            this.Label_Shoulder_RearRight.Size = new System.Drawing.Size(92, 37);
            this.Label_Shoulder_RearRight.TabIndex = 24;
            this.Label_Shoulder_RearRight.Text = "Shoulder";
            this.Label_Shoulder_RearRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Btn_MCU_Mode
            // 
            this.Panel_Btn_MCU_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Btn_MCU_Mode.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Panel_Btn_MCU_Mode.ColumnCount = 3;
            this.Panel_Btn_MCU_Mode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.0969F));
            this.Panel_Btn_MCU_Mode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.95155F));
            this.Panel_Btn_MCU_Mode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.95155F));
            this.Panel_Btn_MCU_Mode.Controls.Add(this.Label_Drive_Power, 0, 0);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.Label_Drive_Direction, 0, 1);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.Label_Steering_Mode, 0, 2);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.Label_RideHeight_Output, 0, 3);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.label_RideHeight, 1, 3);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.Label_SteeringMode_Output, 1, 2);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.output_Drive_Reverse, 1, 0);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.output_Drive_Forward, 2, 0);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.output_Drive_Direction, 1, 1);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.label_TurnRadius, 0, 4);
            this.Panel_Btn_MCU_Mode.Controls.Add(this.label_TurnRadius_Output, 1, 4);
            this.Panel_Btn_MCU_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Btn_MCU_Mode.ForeColor = System.Drawing.Color.White;
            this.Panel_Btn_MCU_Mode.Location = new System.Drawing.Point(3, 57);
            this.Panel_Btn_MCU_Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Btn_MCU_Mode.Name = "Panel_Btn_MCU_Mode";
            this.Panel_Btn_MCU_Mode.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_Btn_MCU_Mode.RowCount = 4;
            this.tableLayoutPanel1.SetRowSpan(this.Panel_Btn_MCU_Mode, 4);
            this.Panel_Btn_MCU_Mode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22397F));
            this.Panel_Btn_MCU_Mode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22397F));
            this.Panel_Btn_MCU_Mode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.52076F));
            this.Panel_Btn_MCU_Mode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51762F));
            this.Panel_Btn_MCU_Mode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51369F));
            this.Panel_Btn_MCU_Mode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Btn_MCU_Mode.Size = new System.Drawing.Size(225, 540);
            this.Panel_Btn_MCU_Mode.TabIndex = 5;
            this.Panel_Btn_MCU_Mode.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Btn_MCU_Mode_Paint);
            // 
            // Label_Drive_Power
            // 
            this.Label_Drive_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Drive_Power.AutoSize = true;
            this.Label_Drive_Power.BackColor = System.Drawing.SystemColors.Desktop;
            this.Label_Drive_Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Drive_Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Drive_Power.Location = new System.Drawing.Point(9, 6);
            this.Label_Drive_Power.Name = "Label_Drive_Power";
            this.Label_Drive_Power.Size = new System.Drawing.Size(82, 116);
            this.Label_Drive_Power.TabIndex = 6;
            this.Label_Drive_Power.Text = "Drive Power";
            this.Label_Drive_Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Drive_Power.Click += new System.EventHandler(this.Label_MCU_Output_Click);
            // 
            // Label_Drive_Direction
            // 
            this.Label_Drive_Direction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Drive_Direction.AutoSize = true;
            this.Label_Drive_Direction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Drive_Direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Drive_Direction.Location = new System.Drawing.Point(9, 123);
            this.Label_Drive_Direction.Name = "Label_Drive_Direction";
            this.Label_Drive_Direction.Size = new System.Drawing.Size(82, 116);
            this.Label_Drive_Direction.TabIndex = 9;
            this.Label_Drive_Direction.Text = "Drive Direction";
            this.Label_Drive_Direction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Steering_Mode
            // 
            this.Label_Steering_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Steering_Mode.AutoSize = true;
            this.Label_Steering_Mode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Steering_Mode.Location = new System.Drawing.Point(9, 240);
            this.Label_Steering_Mode.Name = "Label_Steering_Mode";
            this.Label_Steering_Mode.Size = new System.Drawing.Size(82, 97);
            this.Label_Steering_Mode.TabIndex = 11;
            this.Label_Steering_Mode.Text = "Steering Mode";
            this.Label_Steering_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_RideHeight_Output
            // 
            this.Label_RideHeight_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_RideHeight_Output.AutoSize = true;
            this.Label_RideHeight_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_RideHeight_Output.Location = new System.Drawing.Point(9, 338);
            this.Label_RideHeight_Output.Name = "Label_RideHeight_Output";
            this.Label_RideHeight_Output.Size = new System.Drawing.Size(82, 97);
            this.Label_RideHeight_Output.TabIndex = 13;
            this.Label_RideHeight_Output.Text = "Ride Height";
            this.Label_RideHeight_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_RideHeight
            // 
            this.label_RideHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RideHeight.AutoSize = true;
            this.Panel_Btn_MCU_Mode.SetColumnSpan(this.label_RideHeight, 2);
            this.label_RideHeight.ForeColor = System.Drawing.Color.White;
            this.label_RideHeight.Location = new System.Drawing.Point(98, 338);
            this.label_RideHeight.Name = "label_RideHeight";
            this.label_RideHeight.Size = new System.Drawing.Size(118, 97);
            this.label_RideHeight.TabIndex = 14;
            this.label_RideHeight.Text = "100";
            this.label_RideHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_RideHeight.Click += new System.EventHandler(this.label_RideHeight_Click);
            // 
            // Label_SteeringMode_Output
            // 
            this.Label_SteeringMode_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SteeringMode_Output.AutoSize = true;
            this.Panel_Btn_MCU_Mode.SetColumnSpan(this.Label_SteeringMode_Output, 2);
            this.Label_SteeringMode_Output.Location = new System.Drawing.Point(98, 240);
            this.Label_SteeringMode_Output.Name = "Label_SteeringMode_Output";
            this.Label_SteeringMode_Output.Size = new System.Drawing.Size(118, 97);
            this.Label_SteeringMode_Output.TabIndex = 12;
            this.Label_SteeringMode_Output.Text = "Non-Holonomic";
            this.Label_SteeringMode_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_SteeringMode_Output.Click += new System.EventHandler(this.Label_SteeringMode_Output_Click);
            // 
            // output_Drive_Reverse
            // 
            this.output_Drive_Reverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_Drive_Reverse.Location = new System.Drawing.Point(98, 8);
            this.output_Drive_Reverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output_Drive_Reverse.Name = "output_Drive_Reverse";
            this.output_Drive_Reverse.Size = new System.Drawing.Size(55, 112);
            this.output_Drive_Reverse.TabIndex = 16;
            this.output_Drive_Reverse.Text = "";
            // 
            // output_Drive_Forward
            // 
            this.output_Drive_Forward.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output_Drive_Forward.Location = new System.Drawing.Point(160, 8);
            this.output_Drive_Forward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output_Drive_Forward.Name = "output_Drive_Forward";
            this.output_Drive_Forward.Size = new System.Drawing.Size(56, 112);
            this.output_Drive_Forward.TabIndex = 17;
            this.output_Drive_Forward.Text = "";
            // 
            // output_Drive_Direction
            // 
            this.output_Drive_Direction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Btn_MCU_Mode.SetColumnSpan(this.output_Drive_Direction, 2);
            this.output_Drive_Direction.Location = new System.Drawing.Point(98, 125);
            this.output_Drive_Direction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output_Drive_Direction.Name = "output_Drive_Direction";
            this.output_Drive_Direction.Size = new System.Drawing.Size(118, 112);
            this.output_Drive_Direction.TabIndex = 15;
            this.output_Drive_Direction.Text = "";
            // 
            // label_TurnRadius
            // 
            this.label_TurnRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TurnRadius.AutoSize = true;
            this.label_TurnRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_TurnRadius.Location = new System.Drawing.Point(9, 436);
            this.label_TurnRadius.Name = "label_TurnRadius";
            this.label_TurnRadius.Size = new System.Drawing.Size(82, 98);
            this.label_TurnRadius.TabIndex = 18;
            this.label_TurnRadius.Text = "Turn Radius";
            this.label_TurnRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TurnRadius_Output
            // 
            this.label_TurnRadius_Output.AutoSize = true;
            this.Panel_Btn_MCU_Mode.SetColumnSpan(this.label_TurnRadius_Output, 2);
            this.label_TurnRadius_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TurnRadius_Output.Location = new System.Drawing.Point(98, 436);
            this.label_TurnRadius_Output.Name = "label_TurnRadius_Output";
            this.label_TurnRadius_Output.Size = new System.Drawing.Size(118, 98);
            this.label_TurnRadius_Output.TabIndex = 19;
            this.label_TurnRadius_Output.Text = "360";
            this.label_TurnRadius_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_TurnRadius_Output.Click += new System.EventHandler(this.label_TurnRadius_Output_Click);
            // 
            // Btn_Emergency_Stop
            // 
            this.Btn_Emergency_Stop.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.SetColumnSpan(this.Btn_Emergency_Stop, 2);
            this.Btn_Emergency_Stop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Emergency_Stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Emergency_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Emergency_Stop.FlatAppearance.BorderSize = 5;
            this.Btn_Emergency_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Btn_Emergency_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Emergency_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Emergency_Stop.ForeColor = System.Drawing.Color.White;
            this.Btn_Emergency_Stop.Location = new System.Drawing.Point(236, 536);
            this.Btn_Emergency_Stop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_Emergency_Stop.Name = "Btn_Emergency_Stop";
            this.tableLayoutPanel1.SetRowSpan(this.Btn_Emergency_Stop, 2);
            this.Btn_Emergency_Stop.Size = new System.Drawing.Size(544, 57);
            this.Btn_Emergency_Stop.TabIndex = 0;
            this.Btn_Emergency_Stop.Text = "Emergency Stop";
            this.Btn_Emergency_Stop.UseVisualStyleBackColor = false;
            this.Btn_Emergency_Stop.Click += new System.EventHandler(this.Btn_Emergency_Stop_Click);
            // 
            // Panel_Btn_ROC_Mode
            // 
            this.Panel_Btn_ROC_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Btn_ROC_Mode.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.Panel_Btn_ROC_Mode, 3);
            this.Panel_Btn_ROC_Mode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.Panel_Btn_ROC_Mode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.Panel_Btn_ROC_Mode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.Panel_Btn_ROC_Mode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.Panel_Btn_ROC_Mode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Btn_ROC_Mode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel_Btn_ROC_Mode.Controls.Add(this.Btn_Standby_Mode, 0, 0);
            this.Panel_Btn_ROC_Mode.Controls.Add(this.Btn_Stop_Auto, 3, 0);
            this.Panel_Btn_ROC_Mode.Controls.Add(this.Btn_Manual_Mode, 1, 0);
            this.Panel_Btn_ROC_Mode.Controls.Add(this.Btn_Auto_Mode, 2, 0);
            this.Panel_Btn_ROC_Mode.Location = new System.Drawing.Point(3, 2);
            this.Panel_Btn_ROC_Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Btn_ROC_Mode.Name = "Panel_Btn_ROC_Mode";
            this.Panel_Btn_ROC_Mode.RowCount = 1;
            this.Panel_Btn_ROC_Mode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel_Btn_ROC_Mode.Size = new System.Drawing.Size(779, 51);
            this.Panel_Btn_ROC_Mode.TabIndex = 2;
            this.Panel_Btn_ROC_Mode.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Btn_ROC_Mode_Paint);
            // 
            // Btn_Standby_Mode
            // 
            this.Btn_Standby_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Standby_Mode.BackColor = System.Drawing.Color.Silver;
            this.Btn_Standby_Mode.FlatAppearance.BorderSize = 5;
            this.Btn_Standby_Mode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Standby_Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Standby_Mode.Location = new System.Drawing.Point(3, 2);
            this.Btn_Standby_Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Standby_Mode.Name = "Btn_Standby_Mode";
            this.Btn_Standby_Mode.Size = new System.Drawing.Size(188, 47);
            this.Btn_Standby_Mode.TabIndex = 0;
            this.Btn_Standby_Mode.Text = "STANDBY";
            this.Btn_Standby_Mode.UseVisualStyleBackColor = false;
            this.Btn_Standby_Mode.Click += new System.EventHandler(this.Btn_Standby_Mode_Click);
            // 
            // Btn_Stop_Auto
            // 
            this.Btn_Stop_Auto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Stop_Auto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Stop_Auto.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Stop_Auto.FlatAppearance.BorderSize = 5;
            this.Btn_Stop_Auto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Stop_Auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Stop_Auto.Location = new System.Drawing.Point(585, 2);
            this.Btn_Stop_Auto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Stop_Auto.Name = "Btn_Stop_Auto";
            this.Btn_Stop_Auto.Size = new System.Drawing.Size(191, 47);
            this.Btn_Stop_Auto.TabIndex = 3;
            this.Btn_Stop_Auto.Text = "STOP AUTO";
            this.Btn_Stop_Auto.UseVisualStyleBackColor = false;
            this.Btn_Stop_Auto.Click += new System.EventHandler(this.Btn_Stop_Auto_Click);
            // 
            // Btn_Manual_Mode
            // 
            this.Btn_Manual_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Manual_Mode.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Manual_Mode.FlatAppearance.BorderSize = 5;
            this.Btn_Manual_Mode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Manual_Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Manual_Mode.Location = new System.Drawing.Point(197, 2);
            this.Btn_Manual_Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Manual_Mode.Name = "Btn_Manual_Mode";
            this.Btn_Manual_Mode.Size = new System.Drawing.Size(188, 47);
            this.Btn_Manual_Mode.TabIndex = 1;
            this.Btn_Manual_Mode.Text = "MANUAL";
            this.Btn_Manual_Mode.UseVisualStyleBackColor = false;
            this.Btn_Manual_Mode.Click += new System.EventHandler(this.Btn_Manual_Mode_Click);
            // 
            // Btn_Auto_Mode
            // 
            this.Btn_Auto_Mode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Auto_Mode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Auto_Mode.BackColor = System.Drawing.Color.Lime;
            this.Btn_Auto_Mode.FlatAppearance.BorderSize = 5;
            this.Btn_Auto_Mode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Auto_Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Auto_Mode.Location = new System.Drawing.Point(391, 2);
            this.Btn_Auto_Mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Auto_Mode.Name = "Btn_Auto_Mode";
            this.Btn_Auto_Mode.Size = new System.Drawing.Size(188, 47);
            this.Btn_Auto_Mode.TabIndex = 2;
            this.Btn_Auto_Mode.Text = "AUTO";
            this.Btn_Auto_Mode.UseVisualStyleBackColor = false;
            this.Btn_Auto_Mode.Click += new System.EventHandler(this.Btn_Auto_Mode_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21849F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.830506F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.830506F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Emergency_Stop, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Logo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Btn_MCU_Mode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Panel_Btn_ROC_Mode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Panel_MCU_Data_Joystick_State, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtServerPort, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.Label_serverport, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_StartServer, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.232443F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.93135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666371F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.503167F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 599);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtServerPort.Location = new System.Drawing.Point(1086, 571);
            this.txtServerPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 34);
            this.txtServerPort.TabIndex = 12;
            this.txtServerPort.Text = "1234";
            this.txtServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_serverport
            // 
            this.Label_serverport.AutoSize = true;
            this.Label_serverport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_serverport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_serverport.ForeColor = System.Drawing.Color.White;
            this.Label_serverport.Location = new System.Drawing.Point(981, 569);
            this.Label_serverport.Name = "Label_serverport";
            this.Label_serverport.Size = new System.Drawing.Size(99, 30);
            this.Label_serverport.TabIndex = 13;
            this.Label_serverport.Text = "Server Port:";
            this.Label_serverport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_StartServer
            // 
            this.btn_StartServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_StartServer.BackgroundImage")));
            this.btn_StartServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_StartServer, 3);
            this.btn_StartServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_StartServer.ForeColor = System.Drawing.Color.White;
            this.btn_StartServer.Location = new System.Drawing.Point(788, 532);
            this.btn_StartServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StartServer.Name = "btn_StartServer";
            this.btn_StartServer.Size = new System.Drawing.Size(398, 35);
            this.btn_StartServer.TabIndex = 14;
            this.btn_StartServer.Text = "Start Server";
            this.btn_StartServer.UseVisualStyleBackColor = true;
            this.btn_StartServer.Click += new System.EventHandler(this.btn_StartServer_Click);
            // 
            // Form_ROC_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1189, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ROC_GUI";
            this.Text = "ROC GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Logo.ResumeLayout(false);
            this.Panel_Logo.PerformLayout();
            this.Panel_MCU_Data_Joystick_State.ResumeLayout(false);
            this.Panel_MCU_Data_Joystick_State.PerformLayout();
            this.Panel_Btn_MCU_Mode.ResumeLayout(false);
            this.Panel_Btn_MCU_Mode.PerformLayout();
            this.Panel_Btn_ROC_Mode.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer joystickTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TableLayoutPanel Panel_Logo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel Panel_Btn_ROC_Mode;
        private System.Windows.Forms.Button Btn_Standby_Mode;
        private System.Windows.Forms.Button Btn_Stop_Auto;
        private System.Windows.Forms.Button Btn_Manual_Mode;
        private System.Windows.Forms.Button Btn_Auto_Mode;
        private System.Windows.Forms.Button Btn_Emergency_Stop;
        private System.Windows.Forms.TableLayoutPanel Panel_Btn_MCU_Mode;
        private System.Windows.Forms.Label Label_Drive_Power;
        private System.Windows.Forms.Label Label_Drive_Direction;
        private System.Windows.Forms.Label Label_Steering_Mode;
        private System.Windows.Forms.Label Label_RideHeight_Output;
        private System.Windows.Forms.Label label_RideHeight;
        private System.Windows.Forms.Label Label_SteeringMode_Output;
        private System.Windows.Forms.RichTextBox output_Drive_Reverse;
        private System.Windows.Forms.RichTextBox output_Drive_Forward;
        private System.Windows.Forms.RichTextBox output_Drive_Direction;
        private System.Windows.Forms.TableLayoutPanel Panel_MCU_Data_Joystick_State;
        private System.Windows.Forms.Label Label_Encoder_Telemetry;
        private System.Windows.Forms.Label Label_FrontLeft;
        private System.Windows.Forms.Label Label_FrontRight;
        private System.Windows.Forms.Label Label_Wheel_FrontLeft;
        private System.Windows.Forms.Label Label_Wheel_FrontRight;
        private System.Windows.Forms.Label Label_Elbow_FrontLeft;
        private System.Windows.Forms.Label Label_Elbow_FrontRight;
        private System.Windows.Forms.Label Label_Shoulder_FrontLeft;
        private System.Windows.Forms.Label Label_Shoulder_FrontRight;
        private System.Windows.Forms.Label Label_MiddleLeft;
        private System.Windows.Forms.Label Label_MiddleRight;
        private System.Windows.Forms.Label Label_RearLeft;
        private System.Windows.Forms.Label Label_RearRight;
        private System.Windows.Forms.Label Label_Wheel_MiddleLeft;
        private System.Windows.Forms.Label Label_Elbow_MiddleLeft;
        private System.Windows.Forms.Label Label_Shoulder_MiddleLeft;
        private System.Windows.Forms.Label Label_Wheel_RearLeft;
        private System.Windows.Forms.Label Label_Elbow_RearLeft;
        private System.Windows.Forms.Label Label_Shoulder_RearLeft;
        private System.Windows.Forms.Label Label_Wheel_MiddleRight;
        private System.Windows.Forms.Label Label_Elbow_MiddleRight;
        private System.Windows.Forms.Label Label_Shoulder_MiddleRight;
        private System.Windows.Forms.Label Label_Wheel_RearRight;
        private System.Windows.Forms.Label Label_Elbow_RearRight;
        private System.Windows.Forms.Label Label_Shoulder_RearRight;
        private System.Windows.Forms.Label label_MCU_MODE;
        private System.Windows.Forms.Label label_ROC_MODE;
        private System.Windows.Forms.RichTextBox output_ROC_MODE;
        private System.Windows.Forms.RichTextBox output_MCU_MODE;
        private System.Windows.Forms.Label label_TurnRadius;
        private System.Windows.Forms.Label label_TurnRadius_Output;
        private System.Windows.Forms.Label Label_serverport;
        private System.Windows.Forms.Button btn_StartServer;
        private System.Windows.Forms.TextBox txtServerPort;
    }
}

