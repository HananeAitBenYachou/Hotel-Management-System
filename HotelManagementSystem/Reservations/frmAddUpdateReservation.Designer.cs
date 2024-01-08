namespace HotelManagementSystem.Reservations
{
    partial class frmAddUpdateReservation
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlPersonCardWithFilter1 = new HotelManagementSystem.People.Controls.ctrlPersonCardWithFilter();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tpReservationInfo = new System.Windows.Forms.TabPage();
            this.dtpReservedForDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.nudNumberOfPeople = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cbAvailableRooms = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cbRoomTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.guna2ImageButton10 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label14 = new System.Windows.Forms.Label();
            this.tcReservationInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpPersonalInfo.SuspendLayout();
            this.tpReservationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).BeginInit();
            this.tcReservationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblTitle.Location = new System.Drawing.Point(299, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 46);
            this.lblTitle.TabIndex = 164;
            this.lblTitle.Text = "Add New Reservation";
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(18, 12);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(911, 454);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnPersonSelected += new System.EventHandler<int>(this.ctrlPersonCardWithFilter1_OnPersonSelected);
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 54);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(946, 534);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 22;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnNext.FillColor2 = System.Drawing.Color.RosyBrown;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::HotelManagementSystem.Properties.Resources.right_arrow;
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNext.Location = new System.Drawing.Point(749, 478);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 162;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpReservationInfo
            // 
            this.tpReservationInfo.BackColor = System.Drawing.Color.White;
            this.tpReservationInfo.Controls.Add(this.dtpReservedForDate);
            this.tpReservationInfo.Controls.Add(this.lblCreatedByUser);
            this.tpReservationInfo.Controls.Add(this.guna2ImageButton6);
            this.tpReservationInfo.Controls.Add(this.label9);
            this.tpReservationInfo.Controls.Add(this.lblReservationStatus);
            this.tpReservationInfo.Controls.Add(this.guna2ImageButton5);
            this.tpReservationInfo.Controls.Add(this.label7);
            this.tpReservationInfo.Controls.Add(this.guna2ImageButton4);
            this.tpReservationInfo.Controls.Add(this.nudNumberOfPeople);
            this.tpReservationInfo.Controls.Add(this.label5);
            this.tpReservationInfo.Controls.Add(this.guna2ImageButton3);
            this.tpReservationInfo.Controls.Add(this.label4);
            this.tpReservationInfo.Controls.Add(this.guna2ImageButton2);
            this.tpReservationInfo.Controls.Add(this.cbAvailableRooms);
            this.tpReservationInfo.Controls.Add(this.label1);
            this.tpReservationInfo.Controls.Add(this.guna2ImageButton1);
            this.tpReservationInfo.Controls.Add(this.cbRoomTypes);
            this.tpReservationInfo.Controls.Add(this.label3);
            this.tpReservationInfo.Controls.Add(this.lblReservationID);
            this.tpReservationInfo.Controls.Add(this.guna2ImageButton10);
            this.tpReservationInfo.Controls.Add(this.label14);
            this.tpReservationInfo.Location = new System.Drawing.Point(4, 54);
            this.tpReservationInfo.Name = "tpReservationInfo";
            this.tpReservationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservationInfo.Size = new System.Drawing.Size(946, 534);
            this.tpReservationInfo.TabIndex = 1;
            this.tpReservationInfo.Text = "Reservation Info";
            // 
            // dtpReservedForDate
            // 
            this.dtpReservedForDate.BorderRadius = 20;
            this.dtpReservedForDate.BorderThickness = 1;
            this.dtpReservedForDate.Checked = true;
            this.dtpReservedForDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.dtpReservedForDate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.dtpReservedForDate.ForeColor = System.Drawing.Color.White;
            this.dtpReservedForDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpReservedForDate.Location = new System.Drawing.Point(500, 213);
            this.dtpReservedForDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpReservedForDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpReservedForDate.Name = "dtpReservedForDate";
            this.dtpReservedForDate.Size = new System.Drawing.Size(197, 40);
            this.dtpReservedForDate.TabIndex = 239;
            this.dtpReservedForDate.Value = new System.DateTime(2023, 11, 17, 0, 0, 0, 0);
            this.dtpReservedForDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpReservedForDate_Validating);
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByUser.Location = new System.Drawing.Point(518, 395);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(56, 25);
            this.lblCreatedByUser.TabIndex = 238;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton6.Image = global::HotelManagementSystem.Properties.Resources.settings;
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton6.Location = new System.Drawing.Point(442, 390);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton6.TabIndex = 237;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(285, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 236;
            this.label9.Text = "Created By User :";
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.AutoSize = true;
            this.lblReservationStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblReservationStatus.ForeColor = System.Drawing.Color.Black;
            this.lblReservationStatus.Location = new System.Drawing.Point(519, 332);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(56, 25);
            this.lblReservationStatus.TabIndex = 235;
            this.lblReservationStatus.Text = "[????]";
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton5.Image = global::HotelManagementSystem.Properties.Resources.question;
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton5.Location = new System.Drawing.Point(445, 335);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton5.TabIndex = 234;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(361, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 233;
            this.label7.Text = "Status :";
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.Image = global::HotelManagementSystem.Properties.Resources.guests;
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton4.Location = new System.Drawing.Point(442, 274);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton4.TabIndex = 232;
            // 
            // nudNumberOfPeople
            // 
            this.nudNumberOfPeople.BackColor = System.Drawing.Color.Transparent;
            this.nudNumberOfPeople.BorderRadius = 22;
            this.nudNumberOfPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumberOfPeople.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.nudNumberOfPeople.Location = new System.Drawing.Point(500, 272);
            this.nudNumberOfPeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNumberOfPeople.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfPeople.Name = "nudNumberOfPeople";
            this.nudNumberOfPeople.Size = new System.Drawing.Size(175, 40);
            this.nudNumberOfPeople.TabIndex = 231;
            this.nudNumberOfPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(265, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 230;
            this.label5.Text = "Number Of People :";
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton3.Image = global::HotelManagementSystem.Properties.Resources.time_management;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.Location = new System.Drawing.Point(442, 221);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.TabIndex = 228;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(266, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 227;
            this.label4.Text = "Reserved For Date :";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.Image = global::HotelManagementSystem.Properties.Resources.key;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.Location = new System.Drawing.Point(445, 166);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.TabIndex = 226;
            // 
            // cbAvailableRooms
            // 
            this.cbAvailableRooms.BackColor = System.Drawing.Color.Transparent;
            this.cbAvailableRooms.BorderRadius = 22;
            this.cbAvailableRooms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAvailableRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvailableRooms.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAvailableRooms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAvailableRooms.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cbAvailableRooms.ForeColor = System.Drawing.Color.Black;
            this.cbAvailableRooms.ItemHeight = 35;
            this.cbAvailableRooms.Location = new System.Drawing.Point(500, 157);
            this.cbAvailableRooms.Name = "cbAvailableRooms";
            this.cbAvailableRooms.Size = new System.Drawing.Size(197, 41);
            this.cbAvailableRooms.TabIndex = 225;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(281, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 224;
            this.label1.Text = "Available Rooms :";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::HotelManagementSystem.Properties.Resources.room_door;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Location = new System.Drawing.Point(445, 103);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.TabIndex = 223;
            // 
            // cbRoomTypes
            // 
            this.cbRoomTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbRoomTypes.BorderRadius = 22;
            this.cbRoomTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoomTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoomTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoomTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cbRoomTypes.ForeColor = System.Drawing.Color.Black;
            this.cbRoomTypes.ItemHeight = 35;
            this.cbRoomTypes.Location = new System.Drawing.Point(500, 95);
            this.cbRoomTypes.Name = "cbRoomTypes";
            this.cbRoomTypes.Size = new System.Drawing.Size(197, 41);
            this.cbRoomTypes.TabIndex = 222;
            this.cbRoomTypes.SelectedIndexChanged += new System.EventHandler(this.cbRoomTypes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(321, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 221;
            this.label3.Text = "Room Type :";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblReservationID.ForeColor = System.Drawing.Color.Red;
            this.lblReservationID.Location = new System.Drawing.Point(519, 41);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(56, 25);
            this.lblReservationID.TabIndex = 168;
            this.lblReservationID.Text = "[????]";
            // 
            // guna2ImageButton10
            // 
            this.guna2ImageButton10.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton10.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton10.Image = global::HotelManagementSystem.Properties.Resources.id;
            this.guna2ImageButton10.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton10.ImageRotate = 0F;
            this.guna2ImageButton10.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton10.Location = new System.Drawing.Point(445, 45);
            this.guna2ImageButton10.Name = "guna2ImageButton10";
            this.guna2ImageButton10.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton10.TabIndex = 167;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(295, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 23);
            this.label14.TabIndex = 166;
            this.label14.Text = "Reservation ID :";
            // 
            // tcReservationInfo
            // 
            this.tcReservationInfo.Controls.Add(this.tpPersonalInfo);
            this.tcReservationInfo.Controls.Add(this.tpReservationInfo);
            this.tcReservationInfo.ItemSize = new System.Drawing.Size(180, 50);
            this.tcReservationInfo.Location = new System.Drawing.Point(13, 69);
            this.tcReservationInfo.Name = "tcReservationInfo";
            this.tcReservationInfo.SelectedIndex = 0;
            this.tcReservationInfo.Size = new System.Drawing.Size(954, 592);
            this.tcReservationInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservationInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservationInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcReservationInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcReservationInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservationInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservationInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservationInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReservationInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.tcReservationInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservationInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservationInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tcReservationInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReservationInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcReservationInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservationInfo.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcReservationInfo.TabIndex = 163;
            this.tcReservationInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservationInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 22;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnSave.FillColor2 = System.Drawing.Color.RosyBrown;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::HotelManagementSystem.Properties.Resources.save1;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(769, 668);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 166;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 22;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnClose.FillColor2 = System.Drawing.Color.RosyBrown;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::HotelManagementSystem.Properties.Resources.cancel1;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(569, 668);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 165;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddUpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 727);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tcReservationInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Reservation";
            this.Load += new System.EventHandler(this.frmAddUpdateReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpReservationInfo.ResumeLayout(false);
            this.tpReservationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).EndInit();
            this.tcReservationInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcReservationInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tpReservationInfo;
        private System.Windows.Forms.Label lblReservationID;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton10;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ComboBox cbRoomTypes;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ComboBox cbAvailableRooms;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumberOfPeople;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCreatedByUser;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReservationStatus;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpReservedForDate;
    }
}