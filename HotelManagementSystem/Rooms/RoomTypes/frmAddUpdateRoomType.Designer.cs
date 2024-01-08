namespace HotelManagementSystem.Rooms.RoomTypes
{
    partial class frmAddUpdateRoomType
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ImageButton6 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.nudRoomTypeCapacity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtRoomTypeTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPerNightPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRoomTypeID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomTypeCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblTitle.Location = new System.Drawing.Point(273, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 46);
            this.lblTitle.TabIndex = 195;
            this.lblTitle.Text = "Add New RoomType";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtPerNightPrice);
            this.guna2GroupBox1.Controls.Add(this.txtRoomTypeTitle);
            this.guna2GroupBox1.Controls.Add(this.nudRoomTypeCapacity);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton2);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton1);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txtDescription);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton4);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.btnSave);
            this.guna2GroupBox1.Controls.Add(this.guna2ImageButton3);
            this.guna2GroupBox1.Controls.Add(this.btnClose);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(16, 136);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(883, 422);
            this.guna2GroupBox1.TabIndex = 196;
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
            this.btnSave.Location = new System.Drawing.Point(465, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 159;
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
            this.btnClose.Location = new System.Drawing.Point(265, 350);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 158;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.Image = global::HotelManagementSystem.Properties.Resources.search1;
            this.guna2ImageButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.Location = new System.Drawing.Point(170, 228);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton4.TabIndex = 202;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(48, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 201;
            this.label8.Text = "Description :";
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton3.Image = global::HotelManagementSystem.Properties.Resources.performance;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton3.Location = new System.Drawing.Point(170, 80);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton3.TabIndex = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(68, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 199;
            this.label6.Text = "Capacity :";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.Silver;
            this.txtDescription.BorderRadius = 22;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(216, 218);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(584, 79);
            this.txtDescription.TabIndex = 203;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.Image = global::HotelManagementSystem.Properties.Resources.money;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.Location = new System.Drawing.Point(579, 80);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton2.TabIndex = 207;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(430, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 206;
            this.label9.Text = "Per-Night Price :";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::HotelManagementSystem.Properties.Resources.title;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Location = new System.Drawing.Point(170, 152);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.TabIndex = 205;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 204;
            this.label2.Text = "Room Type Title :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 199;
            this.label1.Text = "Room Type ID :";
            // 
            // guna2ImageButton6
            // 
            this.guna2ImageButton6.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton6.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton6.Image = global::HotelManagementSystem.Properties.Resources.id;
            this.guna2ImageButton6.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton6.ImageRotate = 0F;
            this.guna2ImageButton6.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton6.Location = new System.Drawing.Point(176, 96);
            this.guna2ImageButton6.Name = "guna2ImageButton6";
            this.guna2ImageButton6.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton6.TabIndex = 200;
            // 
            // nudRoomTypeCapacity
            // 
            this.nudRoomTypeCapacity.BackColor = System.Drawing.Color.Transparent;
            this.nudRoomTypeCapacity.BorderRadius = 22;
            this.nudRoomTypeCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudRoomTypeCapacity.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.nudRoomTypeCapacity.Location = new System.Drawing.Point(216, 73);
            this.nudRoomTypeCapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudRoomTypeCapacity.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudRoomTypeCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRoomTypeCapacity.Name = "nudRoomTypeCapacity";
            this.nudRoomTypeCapacity.Size = new System.Drawing.Size(169, 40);
            this.nudRoomTypeCapacity.TabIndex = 210;
            this.nudRoomTypeCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtRoomTypeTitle
            // 
            this.txtRoomTypeTitle.BorderColor = System.Drawing.Color.Silver;
            this.txtRoomTypeTitle.BorderRadius = 22;
            this.txtRoomTypeTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomTypeTitle.DefaultText = "";
            this.txtRoomTypeTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomTypeTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomTypeTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomTypeTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomTypeTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomTypeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtRoomTypeTitle.ForeColor = System.Drawing.Color.Black;
            this.txtRoomTypeTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomTypeTitle.Location = new System.Drawing.Point(216, 135);
            this.txtRoomTypeTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomTypeTitle.Multiline = true;
            this.txtRoomTypeTitle.Name = "txtRoomTypeTitle";
            this.txtRoomTypeTitle.PasswordChar = '\0';
            this.txtRoomTypeTitle.PlaceholderText = "";
            this.txtRoomTypeTitle.SelectedText = "";
            this.txtRoomTypeTitle.Size = new System.Drawing.Size(323, 63);
            this.txtRoomTypeTitle.TabIndex = 211;
            this.txtRoomTypeTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtRoomTypeTitle_Validating);
            // 
            // txtPerNightPrice
            // 
            this.txtPerNightPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPerNightPrice.BorderRadius = 22;
            this.txtPerNightPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPerNightPrice.DefaultText = "";
            this.txtPerNightPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPerNightPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPerNightPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPerNightPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPerNightPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPerNightPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPerNightPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPerNightPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPerNightPrice.Location = new System.Drawing.Point(627, 72);
            this.txtPerNightPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPerNightPrice.Multiline = true;
            this.txtPerNightPrice.Name = "txtPerNightPrice";
            this.txtPerNightPrice.PasswordChar = '\0';
            this.txtPerNightPrice.PlaceholderText = "";
            this.txtPerNightPrice.SelectedText = "";
            this.txtPerNightPrice.Size = new System.Drawing.Size(197, 40);
            this.txtPerNightPrice.TabIndex = 212;
            this.txtPerNightPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPerNightPrice_Validating);
            // 
            // lblRoomTypeID
            // 
            this.lblRoomTypeID.AutoSize = true;
            this.lblRoomTypeID.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblRoomTypeID.ForeColor = System.Drawing.Color.Red;
            this.lblRoomTypeID.Location = new System.Drawing.Point(227, 93);
            this.lblRoomTypeID.Name = "lblRoomTypeID";
            this.lblRoomTypeID.Size = new System.Drawing.Size(67, 30);
            this.lblRoomTypeID.TabIndex = 201;
            this.lblRoomTypeID.Text = "[????]";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 582);
            this.Controls.Add(this.lblRoomTypeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ImageButton6);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateRoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update RoomType";
            this.Load += new System.EventHandler(this.frmAddUpdateRoomType_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomTypeCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton6;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudRoomTypeCapacity;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomTypeTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtPerNightPrice;
        private System.Windows.Forms.Label lblRoomTypeID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}