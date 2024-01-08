namespace HotelManagementSystem.Orders
{
    partial class frmAddGuestOrder
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
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tpBookingInfo = new System.Windows.Forms.TabPage();
            this.ctrlBookingInfoWithFilter1 = new HotelManagementSystem.Orders.ctrlBookingInfoWithFilter();
            this.tpOrderInfo = new System.Windows.Forms.TabPage();
            this.lbl = new System.Windows.Forms.Label();
            this.flpSelectedItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectItem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblListType = new System.Windows.Forms.Label();
            this.dgvList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tcOrderInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.gbOrderType = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDining = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label = new System.Windows.Forms.Label();
            this.rbRoomService = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpBookingInfo.SuspendLayout();
            this.tpOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tcOrderInfo.SuspendLayout();
            this.gbOrderType.SuspendLayout();
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
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnSave.FillColor2 = System.Drawing.Color.RosyBrown;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::HotelManagementSystem.Properties.Resources.save1;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(803, 912);
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
            this.btnClose.Location = new System.Drawing.Point(603, 912);
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
            this.lblTitle.Location = new System.Drawing.Point(356, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 46);
            this.lblTitle.TabIndex = 164;
            this.lblTitle.Text = "Add New Order";
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
            this.btnNext.Location = new System.Drawing.Point(766, 652);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 162;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpBookingInfo
            // 
            this.tpBookingInfo.BackColor = System.Drawing.Color.White;
            this.tpBookingInfo.Controls.Add(this.ctrlBookingInfoWithFilter1);
            this.tpBookingInfo.Controls.Add(this.btnNext);
            this.tpBookingInfo.Location = new System.Drawing.Point(4, 54);
            this.tpBookingInfo.Name = "tpBookingInfo";
            this.tpBookingInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookingInfo.Size = new System.Drawing.Size(966, 707);
            this.tpBookingInfo.TabIndex = 0;
            this.tpBookingInfo.Text = "Booking Info";
            // 
            // ctrlBookingInfoWithFilter1
            // 
            this.ctrlBookingInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlBookingInfoWithFilter1.FilterEnabled = true;
            this.ctrlBookingInfoWithFilter1.Location = new System.Drawing.Point(19, 14);
            this.ctrlBookingInfoWithFilter1.Name = "ctrlBookingInfoWithFilter1";
            this.ctrlBookingInfoWithFilter1.Size = new System.Drawing.Size(927, 631);
            this.ctrlBookingInfoWithFilter1.TabIndex = 163;
            this.ctrlBookingInfoWithFilter1.OnBookingSelected += new System.EventHandler<int>(this.ctrlBookingInfoWithFilter1_OnBookingSelected);
            // 
            // tpOrderInfo
            // 
            this.tpOrderInfo.BackColor = System.Drawing.Color.White;
            this.tpOrderInfo.Controls.Add(this.lbl);
            this.tpOrderInfo.Controls.Add(this.flpSelectedItems);
            this.tpOrderInfo.Controls.Add(this.btnSelectItem);
            this.tpOrderInfo.Controls.Add(this.lblListType);
            this.tpOrderInfo.Controls.Add(this.dgvList);
            this.tpOrderInfo.Location = new System.Drawing.Point(4, 54);
            this.tpOrderInfo.Name = "tpOrderInfo";
            this.tpOrderInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderInfo.Size = new System.Drawing.Size(966, 707);
            this.tpOrderInfo.TabIndex = 1;
            this.tpOrderInfo.Text = "Order Info";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lbl.Location = new System.Drawing.Point(11, 311);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(161, 28);
            this.lbl.TabIndex = 169;
            this.lbl.Text = "Selected Items :";
            // 
            // flpSelectedItems
            // 
            this.flpSelectedItems.AutoScroll = true;
            this.flpSelectedItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSelectedItems.Location = new System.Drawing.Point(11, 348);
            this.flpSelectedItems.Name = "flpSelectedItems";
            this.flpSelectedItems.Size = new System.Drawing.Size(945, 341);
            this.flpSelectedItems.TabIndex = 168;
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.BorderRadius = 22;
            this.btnSelectItem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectItem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.btnSelectItem.FillColor2 = System.Drawing.Color.RosyBrown;
            this.btnSelectItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectItem.ForeColor = System.Drawing.Color.White;
            this.btnSelectItem.Image = global::HotelManagementSystem.Properties.Resources.cursor__1_;
            this.btnSelectItem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSelectItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectItem.Location = new System.Drawing.Point(415, 265);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(180, 45);
            this.btnSelectItem.TabIndex = 167;
            this.btnSelectItem.Text = "Select Item";
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // lblListType
            // 
            this.lblListType.AutoSize = true;
            this.lblListType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblListType.Location = new System.Drawing.Point(11, 19);
            this.lblListType.Name = "lblListType";
            this.lblListType.Size = new System.Drawing.Size(204, 28);
            this.lblListType.TabIndex = 165;
            this.lblListType.Text = "Dining Menu Items :";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvList.Location = new System.Drawing.Point(11, 52);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 50;
            this.dgvList.RowTemplate.Height = 35;
            this.dgvList.Size = new System.Drawing.Size(945, 205);
            this.dgvList.TabIndex = 32;
            this.dgvList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvList.ThemeStyle.ReadOnly = true;
            this.dgvList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvList_DataBindingComplete);
            // 
            // tcOrderInfo
            // 
            this.tcOrderInfo.Controls.Add(this.tpBookingInfo);
            this.tcOrderInfo.Controls.Add(this.tpOrderInfo);
            this.tcOrderInfo.ItemSize = new System.Drawing.Size(180, 50);
            this.tcOrderInfo.Location = new System.Drawing.Point(11, 143);
            this.tcOrderInfo.Name = "tcOrderInfo";
            this.tcOrderInfo.SelectedIndex = 0;
            this.tcOrderInfo.Size = new System.Drawing.Size(974, 765);
            this.tcOrderInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcOrderInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcOrderInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcOrderInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcOrderInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcOrderInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.tcOrderInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcOrderInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tcOrderInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcOrderInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcOrderInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderInfo.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcOrderInfo.TabIndex = 163;
            this.tcOrderInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // gbOrderType
            // 
            this.gbOrderType.BorderColor = System.Drawing.Color.Silver;
            this.gbOrderType.Controls.Add(this.label1);
            this.gbOrderType.Controls.Add(this.rbDining);
            this.gbOrderType.Controls.Add(this.label);
            this.gbOrderType.Controls.Add(this.rbRoomService);
            this.gbOrderType.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.gbOrderType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbOrderType.ForeColor = System.Drawing.Color.White;
            this.gbOrderType.Location = new System.Drawing.Point(15, 54);
            this.gbOrderType.Name = "gbOrderType";
            this.gbOrderType.Size = new System.Drawing.Size(570, 81);
            this.gbOrderType.TabIndex = 169;
            this.gbOrderType.Text = "Order Type : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(365, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dining";
            // 
            // rbDining
            // 
            this.rbDining.CheckedState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rbDining.CheckedState.BorderThickness = 0;
            this.rbDining.CheckedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.rbDining.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDining.Location = new System.Drawing.Point(328, 47);
            this.rbDining.Name = "rbDining";
            this.rbDining.Size = new System.Drawing.Size(23, 23);
            this.rbDining.TabIndex = 25;
            this.rbDining.Text = "guna2CustomRadioButton2";
            this.rbDining.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDining.UncheckedState.BorderThickness = 5;
            this.rbDining.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDining.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbDining.CheckedChanged += new System.EventHandler(this.rbDining_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(109, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(120, 23);
            this.label.TabIndex = 24;
            this.label.Text = "Room Service";
            // 
            // rbRoomService
            // 
            this.rbRoomService.Checked = true;
            this.rbRoomService.CheckedState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.rbRoomService.CheckedState.BorderThickness = 0;
            this.rbRoomService.CheckedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.rbRoomService.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbRoomService.Location = new System.Drawing.Point(72, 46);
            this.rbRoomService.Name = "rbRoomService";
            this.rbRoomService.Size = new System.Drawing.Size(23, 23);
            this.rbRoomService.TabIndex = 23;
            this.rbRoomService.Text = "guna2CustomRadioButton2";
            this.rbRoomService.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbRoomService.UncheckedState.BorderThickness = 5;
            this.rbRoomService.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbRoomService.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbRoomService.CheckedChanged += new System.EventHandler(this.rbRoomService_CheckedChanged);
            // 
            // frmAddGuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 968);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbOrderType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcOrderInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddGuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Guest Order";
            this.Load += new System.EventHandler(this.frmAddGuestOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpBookingInfo.ResumeLayout(false);
            this.tpOrderInfo.ResumeLayout(false);
            this.tpOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tcOrderInfo.ResumeLayout(false);
            this.gbOrderType.ResumeLayout(false);
            this.gbOrderType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcOrderInfo;
        private System.Windows.Forms.TabPage tpBookingInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private System.Windows.Forms.TabPage tpOrderInfo;
        private Guna.UI2.WinForms.Guna2GroupBox gbOrderType;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbDining;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbRoomService;
        private ctrlBookingInfoWithFilter ctrlBookingInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvList;
        private System.Windows.Forms.Label lblListType;
        private Guna.UI2.WinForms.Guna2GradientButton btnSelectItem;
        private System.Windows.Forms.FlowLayoutPanel flpSelectedItems;
        private System.Windows.Forms.Label lbl;
    }
}