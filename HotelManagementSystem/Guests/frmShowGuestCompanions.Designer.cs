namespace HotelManagementSystem.Guests
{
    partial class frmShowGuestCompanions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tpBookingInfo = new System.Windows.Forms.TabPage();
            this.ctrlBookingInfo1 = new HotelManagementSystem.Bookings.Controls.ctrlBookingInfo();
            this.tpCompanionsInfo = new System.Windows.Forms.TabPage();
            this.tabcontrol = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpBookings = new System.Windows.Forms.TabPage();
            this.dgvGuestCompanionsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ctrlPersonCard1 = new HotelManagementSystem.People.Controls.ctrlPersonCard();
            this.tcGuestCompanionsInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpBookingInfo.SuspendLayout();
            this.tpCompanionsInfo.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.tpBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestCompanionsList)).BeginInit();
            this.tcGuestCompanionsInfo.SuspendLayout();
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
            this.lblTitle.Location = new System.Drawing.Point(325, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 46);
            this.lblTitle.TabIndex = 164;
            this.lblTitle.Text = "Guest Companions";
            // 
            // tpBookingInfo
            // 
            this.tpBookingInfo.BackColor = System.Drawing.Color.White;
            this.tpBookingInfo.Controls.Add(this.ctrlBookingInfo1);
            this.tpBookingInfo.Location = new System.Drawing.Point(4, 54);
            this.tpBookingInfo.Name = "tpBookingInfo";
            this.tpBookingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookingInfo.Size = new System.Drawing.Size(1011, 628);
            this.tpBookingInfo.TabIndex = 0;
            this.tpBookingInfo.Text = "Booking Info";
            // 
            // ctrlBookingInfo1
            // 
            this.ctrlBookingInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlBookingInfo1.Location = new System.Drawing.Point(39, 50);
            this.ctrlBookingInfo1.Name = "ctrlBookingInfo1";
            this.ctrlBookingInfo1.Size = new System.Drawing.Size(923, 518);
            this.ctrlBookingInfo1.TabIndex = 0;
            // 
            // tpCompanionsInfo
            // 
            this.tpCompanionsInfo.BackColor = System.Drawing.Color.White;
            this.tpCompanionsInfo.Controls.Add(this.tabcontrol);
            this.tpCompanionsInfo.Controls.Add(this.ctrlPersonCard1);
            this.tpCompanionsInfo.Location = new System.Drawing.Point(4, 54);
            this.tpCompanionsInfo.Name = "tpCompanionsInfo";
            this.tpCompanionsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompanionsInfo.Size = new System.Drawing.Size(1011, 628);
            this.tpCompanionsInfo.TabIndex = 1;
            this.tpCompanionsInfo.Text = "Guest & Companions Info";
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tpBookings);
            this.tabcontrol.ItemSize = new System.Drawing.Size(180, 50);
            this.tabcontrol.Location = new System.Drawing.Point(61, 354);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(895, 254);
            this.tabcontrol.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabcontrol.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tabcontrol.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tabcontrol.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabcontrol.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tabcontrol.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabcontrol.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tabcontrol.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabcontrol.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.tabcontrol.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tabcontrol.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabcontrol.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tabcontrol.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabcontrol.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabcontrol.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tabcontrol.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tabcontrol.TabIndex = 287;
            this.tabcontrol.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tabcontrol.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpBookings
            // 
            this.tpBookings.BackColor = System.Drawing.Color.White;
            this.tpBookings.Controls.Add(this.dgvGuestCompanionsList);
            this.tpBookings.Location = new System.Drawing.Point(4, 54);
            this.tpBookings.Name = "tpBookings";
            this.tpBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookings.Size = new System.Drawing.Size(887, 196);
            this.tpBookings.TabIndex = 0;
            this.tpBookings.Text = "Bookings History";
            // 
            // dgvGuestCompanionsList
            // 
            this.dgvGuestCompanionsList.AllowUserToAddRows = false;
            this.dgvGuestCompanionsList.AllowUserToDeleteRows = false;
            this.dgvGuestCompanionsList.AllowUserToOrderColumns = true;
            this.dgvGuestCompanionsList.AllowUserToResizeColumns = false;
            this.dgvGuestCompanionsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvGuestCompanionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuestCompanionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvGuestCompanionsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuestCompanionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGuestCompanionsList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGuestCompanionsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGuestCompanionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGuestCompanionsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvGuestCompanionsList.Location = new System.Drawing.Point(3, 3);
            this.dgvGuestCompanionsList.MultiSelect = false;
            this.dgvGuestCompanionsList.Name = "dgvGuestCompanionsList";
            this.dgvGuestCompanionsList.ReadOnly = true;
            this.dgvGuestCompanionsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuestCompanionsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGuestCompanionsList.RowHeadersVisible = false;
            this.dgvGuestCompanionsList.RowHeadersWidth = 50;
            this.dgvGuestCompanionsList.RowTemplate.Height = 35;
            this.dgvGuestCompanionsList.Size = new System.Drawing.Size(881, 190);
            this.dgvGuestCompanionsList.TabIndex = 16;
            this.dgvGuestCompanionsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvGuestCompanionsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvGuestCompanionsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGuestCompanionsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGuestCompanionsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGuestCompanionsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGuestCompanionsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGuestCompanionsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvGuestCompanionsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvGuestCompanionsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGuestCompanionsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvGuestCompanionsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGuestCompanionsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGuestCompanionsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvGuestCompanionsList.ThemeStyle.ReadOnly = true;
            this.dgvGuestCompanionsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvGuestCompanionsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGuestCompanionsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvGuestCompanionsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGuestCompanionsList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvGuestCompanionsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvGuestCompanionsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGuestCompanionsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGuestCompanionsList_DataBindingComplete);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(61, 12);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(895, 326);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // tcGuestCompanionsInfo
            // 
            this.tcGuestCompanionsInfo.Controls.Add(this.tpBookingInfo);
            this.tcGuestCompanionsInfo.Controls.Add(this.tpCompanionsInfo);
            this.tcGuestCompanionsInfo.ItemSize = new System.Drawing.Size(300, 50);
            this.tcGuestCompanionsInfo.Location = new System.Drawing.Point(13, 69);
            this.tcGuestCompanionsInfo.Name = "tcGuestCompanionsInfo";
            this.tcGuestCompanionsInfo.SelectedIndex = 0;
            this.tcGuestCompanionsInfo.Size = new System.Drawing.Size(1019, 686);
            this.tcGuestCompanionsInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcGuestCompanionsInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcGuestCompanionsInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcGuestCompanionsInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcGuestCompanionsInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcGuestCompanionsInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcGuestCompanionsInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcGuestCompanionsInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcGuestCompanionsInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.tcGuestCompanionsInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcGuestCompanionsInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcGuestCompanionsInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tcGuestCompanionsInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcGuestCompanionsInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcGuestCompanionsInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcGuestCompanionsInfo.TabButtonSize = new System.Drawing.Size(300, 50);
            this.tcGuestCompanionsInfo.TabIndex = 163;
            this.tcGuestCompanionsInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcGuestCompanionsInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
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
            this.btnClose.Location = new System.Drawing.Point(852, 761);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 165;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowGuestCompanions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 817);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tcGuestCompanionsInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowGuestCompanions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Guest Companions";
            this.Load += new System.EventHandler(this.frmShowGuestCompanions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpBookingInfo.ResumeLayout(false);
            this.tpCompanionsInfo.ResumeLayout(false);
            this.tabcontrol.ResumeLayout(false);
            this.tpBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestCompanionsList)).EndInit();
            this.tcGuestCompanionsInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcGuestCompanionsInfo;
        private System.Windows.Forms.TabPage tpBookingInfo;
        private System.Windows.Forms.TabPage tpCompanionsInfo;
        private Bookings.Controls.ctrlBookingInfo ctrlBookingInfo1;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private Guna.UI2.WinForms.Guna2TabControl tabcontrol;
        private System.Windows.Forms.TabPage tpBookings;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGuestCompanionsList;
    }
}