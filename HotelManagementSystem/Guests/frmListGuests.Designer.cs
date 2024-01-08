namespace HotelManagementSystem.Guests
{
    partial class frmListGuests
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
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGuestsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsGuests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReservationsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBookingsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPaymentsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.showOrdersHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestsList)).BeginInit();
            this.cmsGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilterByOptions
            // 
            this.cbFilterByOptions.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterByOptions.BorderRadius = 22;
            this.cbFilterByOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByOptions.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterByOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cbFilterByOptions.ForeColor = System.Drawing.Color.Black;
            this.cbFilterByOptions.ItemHeight = 35;
            this.cbFilterByOptions.Items.AddRange(new object[] {
            "None",
            "GuestID",
            "National No",
            "Full Name",
            "Gender",
            "Nationality",
            "Phone",
            "Email"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(136, 349);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(231, 41);
            this.cbFilterByOptions.TabIndex = 24;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.cbFilterByOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Filter By :";
            // 
            // dgvGuestsList
            // 
            this.dgvGuestsList.AllowUserToAddRows = false;
            this.dgvGuestsList.AllowUserToDeleteRows = false;
            this.dgvGuestsList.AllowUserToOrderColumns = true;
            this.dgvGuestsList.AllowUserToResizeColumns = false;
            this.dgvGuestsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvGuestsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuestsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvGuestsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuestsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGuestsList.ColumnHeadersHeight = 45;
            this.dgvGuestsList.ContextMenuStrip = this.cmsGuests;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGuestsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGuestsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvGuestsList.Location = new System.Drawing.Point(44, 412);
            this.dgvGuestsList.MultiSelect = false;
            this.dgvGuestsList.Name = "dgvGuestsList";
            this.dgvGuestsList.ReadOnly = true;
            this.dgvGuestsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuestsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGuestsList.RowHeadersVisible = false;
            this.dgvGuestsList.RowHeadersWidth = 50;
            this.dgvGuestsList.RowTemplate.Height = 35;
            this.dgvGuestsList.Size = new System.Drawing.Size(1213, 398);
            this.dgvGuestsList.TabIndex = 22;
            this.dgvGuestsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvGuestsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvGuestsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvGuestsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGuestsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGuestsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGuestsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGuestsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvGuestsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvGuestsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGuestsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvGuestsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGuestsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGuestsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvGuestsList.ThemeStyle.ReadOnly = true;
            this.dgvGuestsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvGuestsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGuestsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvGuestsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGuestsList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvGuestsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvGuestsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGuestsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGuestsList_DataBindingComplete);
            // 
            // cmsGuests
            // 
            this.cmsGuests.BackColor = System.Drawing.Color.White;
            this.cmsGuests.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cmsGuests.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cmsGuests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.showReservationsHistoryToolStripMenuItem,
            this.showBookingsHistoryToolStripMenuItem,
            this.showPaymentsHistoryToolStripMenuItem,
            this.showOrdersHistoryToolStripMenuItem});
            this.cmsGuests.Name = "contextMenuStrip1";
            this.cmsGuests.Size = new System.Drawing.Size(306, 284);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailsToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.patient;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(305, 42);
            this.showDetailsToolStripMenuItem.Text = "&Show Guest Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.user__2_;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(305, 42);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // showReservationsHistoryToolStripMenuItem
            // 
            this.showReservationsHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.showReservationsHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showReservationsHistoryToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.appointment;
            this.showReservationsHistoryToolStripMenuItem.Name = "showReservationsHistoryToolStripMenuItem";
            this.showReservationsHistoryToolStripMenuItem.Size = new System.Drawing.Size(305, 42);
            this.showReservationsHistoryToolStripMenuItem.Text = "Show Reservations History";
            this.showReservationsHistoryToolStripMenuItem.Click += new System.EventHandler(this.showReservationsHistoryToolStripMenuItem_Click);
            // 
            // showBookingsHistoryToolStripMenuItem
            // 
            this.showBookingsHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.showBookingsHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showBookingsHistoryToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.appointment;
            this.showBookingsHistoryToolStripMenuItem.Name = "showBookingsHistoryToolStripMenuItem";
            this.showBookingsHistoryToolStripMenuItem.Size = new System.Drawing.Size(305, 42);
            this.showBookingsHistoryToolStripMenuItem.Text = "Show Bookings History";
            this.showBookingsHistoryToolStripMenuItem.Click += new System.EventHandler(this.showBookingsHistoryToolStripMenuItem_Click);
            // 
            // showPaymentsHistoryToolStripMenuItem
            // 
            this.showPaymentsHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.showPaymentsHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showPaymentsHistoryToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.money;
            this.showPaymentsHistoryToolStripMenuItem.Name = "showPaymentsHistoryToolStripMenuItem";
            this.showPaymentsHistoryToolStripMenuItem.Size = new System.Drawing.Size(305, 42);
            this.showPaymentsHistoryToolStripMenuItem.Text = "Show Payments History";
            this.showPaymentsHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPaymentsHistoryToolStripMenuItem_Click);
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.BorderRadius = 22;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cbGender.ForeColor = System.Drawing.Color.Black;
            this.cbGender.ItemHeight = 40;
            this.cbGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(397, 345);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(231, 46);
            this.cbGender.StartIndex = 0;
            this.cbGender.TabIndex = 27;
            this.cbGender.Visible = false;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(485, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 59);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manage Guests";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationInterval = 0;
            this.guna2BorderlessForm1.BorderRadius = 45;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0D;
            this.guna2BorderlessForm1.DragEndTransparencyValue = 0.1D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderRadius = 22;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.IconLeft = global::HotelManagementSystem.Properties.Resources.search;
            this.txtFilterValue.Location = new System.Drawing.Point(397, 343);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(315, 50);
            this.txtFilterValue.TabIndex = 26;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::HotelManagementSystem.Properties.Resources.guests1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(479, 34);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(349, 184);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 21;
            this.guna2PictureBox1.TabStop = false;
            // 
            // showOrdersHistoryToolStripMenuItem
            // 
            this.showOrdersHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.showOrdersHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showOrdersHistoryToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.menu1;
            this.showOrdersHistoryToolStripMenuItem.Name = "showOrdersHistoryToolStripMenuItem";
            this.showOrdersHistoryToolStripMenuItem.Size = new System.Drawing.Size(305, 42);
            this.showOrdersHistoryToolStripMenuItem.Text = "Show Orders History";
            this.showOrdersHistoryToolStripMenuItem.Click += new System.EventHandler(this.showOrdersHistoryToolStripMenuItem_Click);
            // 
            // frmListGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 845);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGuestsList);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListGuests";
            this.Text = "frmListGuests";
            this.Load += new System.EventHandler(this.frmListGuests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestsList)).EndInit();
            this.cmsGuests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGuestsList;
        private System.Windows.Forms.ContextMenuStrip cmsGuests;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ToolStripMenuItem showReservationsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBookingsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPaymentsHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOrdersHistoryToolStripMenuItem;
    }
}