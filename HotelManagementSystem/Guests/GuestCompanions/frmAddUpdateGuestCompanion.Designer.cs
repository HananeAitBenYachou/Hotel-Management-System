namespace HotelManagementSystem.Guests.GuestCompanions
{
    partial class frmAddUpdateGuestCompanion
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
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlPersonCardWithFilter1 = new HotelManagementSystem.People.Controls.ctrlPersonCardWithFilter();
            this.tpGuestInfo = new System.Windows.Forms.TabPage();
            this.tpGuestCompanionInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter2 = new HotelManagementSystem.People.Controls.ctrlPersonCardWithFilter();
            this.tcUserInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpBookingInfo = new System.Windows.Forms.TabPage();
            this.ctrlBookingInfo1 = new HotelManagementSystem.Bookings.Controls.ctrlBookingInfo();
            this.lblGuestCompanionID = new System.Windows.Forms.Label();
            this.guna2ImageButton10 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpGuestInfo.SuspendLayout();
            this.tpGuestCompanionInfo.SuspendLayout();
            this.tcUserInfo.SuspendLayout();
            this.tpBookingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnSave.Location = new System.Drawing.Point(814, 712);
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
            this.btnClose.Location = new System.Drawing.Point(614, 712);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 165;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblTitle.Location = new System.Drawing.Point(260, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(452, 46);
            this.lblTitle.TabIndex = 164;
            this.lblTitle.Text = "Add New GuestCompanion";
            this.lblTitle.TextChanged += new System.EventHandler(this.lblTitle_TextChanged);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = false;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(40, 52);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(911, 454);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpGuestInfo
            // 
            this.tpGuestInfo.BackColor = System.Drawing.Color.White;
            this.tpGuestInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpGuestInfo.Location = new System.Drawing.Point(4, 54);
            this.tpGuestInfo.Name = "tpGuestInfo";
            this.tpGuestInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpGuestInfo.Size = new System.Drawing.Size(977, 577);
            this.tpGuestInfo.TabIndex = 0;
            this.tpGuestInfo.Text = "Guest Info";
            // 
            // tpGuestCompanionInfo
            // 
            this.tpGuestCompanionInfo.BackColor = System.Drawing.Color.White;
            this.tpGuestCompanionInfo.Controls.Add(this.lblGuestCompanionID);
            this.tpGuestCompanionInfo.Controls.Add(this.guna2ImageButton10);
            this.tpGuestCompanionInfo.Controls.Add(this.label14);
            this.tpGuestCompanionInfo.Controls.Add(this.ctrlPersonCardWithFilter2);
            this.tpGuestCompanionInfo.Location = new System.Drawing.Point(4, 54);
            this.tpGuestCompanionInfo.Name = "tpGuestCompanionInfo";
            this.tpGuestCompanionInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpGuestCompanionInfo.Size = new System.Drawing.Size(977, 577);
            this.tpGuestCompanionInfo.TabIndex = 1;
            this.tpGuestCompanionInfo.Text = "Companion Info";
            // 
            // ctrlPersonCardWithFilter2
            // 
            this.ctrlPersonCardWithFilter2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter2.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter2.FilterEnabled = true;
            this.ctrlPersonCardWithFilter2.Location = new System.Drawing.Point(34, 94);
            this.ctrlPersonCardWithFilter2.Name = "ctrlPersonCardWithFilter2";
            this.ctrlPersonCardWithFilter2.Size = new System.Drawing.Size(911, 454);
            this.ctrlPersonCardWithFilter2.TabIndex = 1;
            this.ctrlPersonCardWithFilter2.OnPersonSelected += new System.EventHandler<int>(this.ctrlPersonCardWithFilter2_OnPersonSelected);
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tpBookingInfo);
            this.tcUserInfo.Controls.Add(this.tpGuestInfo);
            this.tcUserInfo.Controls.Add(this.tpGuestCompanionInfo);
            this.tcUserInfo.ItemSize = new System.Drawing.Size(180, 50);
            this.tcUserInfo.Location = new System.Drawing.Point(13, 68);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(985, 635);
            this.tcUserInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcUserInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcUserInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcUserInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcUserInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcUserInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.tcUserInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcUserInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcUserInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tcUserInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcUserInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcUserInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcUserInfo.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcUserInfo.TabIndex = 163;
            this.tcUserInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcUserInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpBookingInfo
            // 
            this.tpBookingInfo.Controls.Add(this.ctrlBookingInfo1);
            this.tpBookingInfo.Location = new System.Drawing.Point(4, 54);
            this.tpBookingInfo.Name = "tpBookingInfo";
            this.tpBookingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookingInfo.Size = new System.Drawing.Size(977, 577);
            this.tpBookingInfo.TabIndex = 2;
            this.tpBookingInfo.Text = "Booking Info";
            this.tpBookingInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlBookingInfo1
            // 
            this.ctrlBookingInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlBookingInfo1.Location = new System.Drawing.Point(34, 15);
            this.ctrlBookingInfo1.Name = "ctrlBookingInfo1";
            this.ctrlBookingInfo1.Size = new System.Drawing.Size(923, 545);
            this.ctrlBookingInfo1.TabIndex = 0;
            // 
            // lblGuestCompanionID
            // 
            this.lblGuestCompanionID.AutoSize = true;
            this.lblGuestCompanionID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGuestCompanionID.ForeColor = System.Drawing.Color.Red;
            this.lblGuestCompanionID.Location = new System.Drawing.Point(292, 37);
            this.lblGuestCompanionID.Name = "lblGuestCompanionID";
            this.lblGuestCompanionID.Size = new System.Drawing.Size(62, 28);
            this.lblGuestCompanionID.TabIndex = 165;
            this.lblGuestCompanionID.Text = "[????]";
            // 
            // guna2ImageButton10
            // 
            this.guna2ImageButton10.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton10.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton10.Image = global::HotelManagementSystem.Properties.Resources.id;
            this.guna2ImageButton10.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton10.ImageRotate = 0F;
            this.guna2ImageButton10.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.Location = new System.Drawing.Point(254, 38);
            this.guna2ImageButton10.Name = "guna2ImageButton10";
            this.guna2ImageButton10.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton10.TabIndex = 164;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.4F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(45, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 25);
            this.label14.TabIndex = 163;
            this.label14.Text = "Guest Companion ID :";
            // 
            // frmAddUpdateGuestCompanion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 765);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tcUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateGuestCompanion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update GuestCompanion";
            this.Load += new System.EventHandler(this.frmAddUpdateGuestCompanion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpGuestInfo.ResumeLayout(false);
            this.tpGuestCompanionInfo.ResumeLayout(false);
            this.tpGuestCompanionInfo.PerformLayout();
            this.tcUserInfo.ResumeLayout(false);
            this.tpBookingInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tpGuestInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tpGuestCompanionInfo;
        private System.Windows.Forms.TabPage tpBookingInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter2;
        private Bookings.Controls.ctrlBookingInfo ctrlBookingInfo1;
        private System.Windows.Forms.Label lblGuestCompanionID;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton10;
        private System.Windows.Forms.Label label14;
    }
}