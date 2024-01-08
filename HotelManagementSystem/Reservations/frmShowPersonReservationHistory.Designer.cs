namespace HotelManagementSystem.Reservations
{
    partial class frmShowPersonReservationHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcReservations = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpReservations = new System.Windows.Forms.TabPage();
            this.dgvReservationsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ctrlPersonCard1 = new HotelManagementSystem.People.Controls.ctrlPersonCard();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tcReservations.SuspendLayout();
            this.tpReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblTitle.Location = new System.Drawing.Point(310, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(349, 46);
            this.lblTitle.TabIndex = 281;
            this.lblTitle.Text = "Reservations History";
            // 
            // tcReservations
            // 
            this.tcReservations.Controls.Add(this.tpReservations);
            this.tcReservations.ItemSize = new System.Drawing.Size(180, 50);
            this.tcReservations.Location = new System.Drawing.Point(21, 399);
            this.tcReservations.Name = "tcReservations";
            this.tcReservations.SelectedIndex = 0;
            this.tcReservations.Size = new System.Drawing.Size(895, 301);
            this.tcReservations.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservations.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservations.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcReservations.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcReservations.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservations.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservations.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservations.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReservations.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.tcReservations.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservations.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcReservations.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservations.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcReservations.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcReservations.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tcReservations.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcReservations.TabIndex = 282;
            this.tcReservations.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcReservations.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpReservations
            // 
            this.tpReservations.BackColor = System.Drawing.Color.White;
            this.tpReservations.Controls.Add(this.dgvReservationsList);
            this.tpReservations.Location = new System.Drawing.Point(4, 54);
            this.tpReservations.Name = "tpReservations";
            this.tpReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tpReservations.Size = new System.Drawing.Size(887, 243);
            this.tpReservations.TabIndex = 0;
            this.tpReservations.Text = "Reservations History";
            // 
            // dgvReservationsList
            // 
            this.dgvReservationsList.AllowUserToAddRows = false;
            this.dgvReservationsList.AllowUserToDeleteRows = false;
            this.dgvReservationsList.AllowUserToOrderColumns = true;
            this.dgvReservationsList.AllowUserToResizeColumns = false;
            this.dgvReservationsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvReservationsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservationsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvReservationsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservationsList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservationsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservationsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvReservationsList.Location = new System.Drawing.Point(3, 3);
            this.dgvReservationsList.MultiSelect = false;
            this.dgvReservationsList.Name = "dgvReservationsList";
            this.dgvReservationsList.ReadOnly = true;
            this.dgvReservationsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservationsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservationsList.RowHeadersVisible = false;
            this.dgvReservationsList.RowHeadersWidth = 50;
            this.dgvReservationsList.RowTemplate.Height = 35;
            this.dgvReservationsList.Size = new System.Drawing.Size(881, 237);
            this.dgvReservationsList.TabIndex = 16;
            this.dgvReservationsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvReservationsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvReservationsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReservationsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReservationsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReservationsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReservationsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservationsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvReservationsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvReservationsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReservationsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvReservationsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReservationsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReservationsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvReservationsList.ThemeStyle.ReadOnly = true;
            this.dgvReservationsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvReservationsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservationsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvReservationsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReservationsList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvReservationsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvReservationsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvReservationsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvReservationsList_DataBindingComplete);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(21, 62);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(895, 326);
            this.ctrlPersonCard1.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(736, 704);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 283;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowPersonReservationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 760);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcReservations);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlPersonCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPersonReservationHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations History";
            this.Load += new System.EventHandler(this.frmShowPersonReservationHistory_Load);
            this.tcReservations.ResumeLayout(false);
            this.tpReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcReservations;
        private System.Windows.Forms.TabPage tpReservations;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReservationsList;
    }
}