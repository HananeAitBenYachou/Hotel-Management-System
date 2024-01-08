namespace HotelManagementSystem.Orders.Controls
{
    partial class frmShowOrderItems
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
            this.tcOrderItems = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpOrderItems = new System.Windows.Forms.TabPage();
            this.dgvOrderItemsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tcOrderItems.SuspendLayout();
            this.tpOrderItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // tcOrderItems
            // 
            this.tcOrderItems.Controls.Add(this.tpOrderItems);
            this.tcOrderItems.ItemSize = new System.Drawing.Size(180, 50);
            this.tcOrderItems.Location = new System.Drawing.Point(21, 95);
            this.tcOrderItems.Name = "tcOrderItems";
            this.tcOrderItems.SelectedIndex = 0;
            this.tcOrderItems.Size = new System.Drawing.Size(895, 301);
            this.tcOrderItems.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcOrderItems.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderItems.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tcOrderItems.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcOrderItems.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderItems.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcOrderItems.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderItems.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcOrderItems.TabButtonIdleState.ForeColor = System.Drawing.Color.Silver;
            this.tcOrderItems.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderItems.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcOrderItems.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderItems.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcOrderItems.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcOrderItems.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tcOrderItems.TabButtonSize = new System.Drawing.Size(180, 50);
            this.tcOrderItems.TabIndex = 294;
            this.tcOrderItems.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.tcOrderItems.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpOrderItems
            // 
            this.tpOrderItems.BackColor = System.Drawing.Color.White;
            this.tpOrderItems.Controls.Add(this.dgvOrderItemsList);
            this.tpOrderItems.Location = new System.Drawing.Point(4, 54);
            this.tpOrderItems.Name = "tpOrderItems";
            this.tpOrderItems.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrderItems.Size = new System.Drawing.Size(887, 243);
            this.tpOrderItems.TabIndex = 0;
            this.tpOrderItems.Text = "Orders Items";
            // 
            // dgvOrderItemsList
            // 
            this.dgvOrderItemsList.AllowUserToAddRows = false;
            this.dgvOrderItemsList.AllowUserToDeleteRows = false;
            this.dgvOrderItemsList.AllowUserToOrderColumns = true;
            this.dgvOrderItemsList.AllowUserToResizeColumns = false;
            this.dgvOrderItemsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvOrderItemsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvOrderItemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderItemsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderItemsList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderItemsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItemsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvOrderItemsList.Location = new System.Drawing.Point(3, 3);
            this.dgvOrderItemsList.MultiSelect = false;
            this.dgvOrderItemsList.Name = "dgvOrderItemsList";
            this.dgvOrderItemsList.ReadOnly = true;
            this.dgvOrderItemsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderItemsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrderItemsList.RowHeadersVisible = false;
            this.dgvOrderItemsList.RowHeadersWidth = 50;
            this.dgvOrderItemsList.RowTemplate.Height = 35;
            this.dgvOrderItemsList.Size = new System.Drawing.Size(881, 237);
            this.dgvOrderItemsList.TabIndex = 16;
            this.dgvOrderItemsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvOrderItemsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvOrderItemsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrderItemsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrderItemsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrderItemsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrderItemsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderItemsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvOrderItemsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvOrderItemsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrderItemsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvOrderItemsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrderItemsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderItemsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvOrderItemsList.ThemeStyle.ReadOnly = true;
            this.dgvOrderItemsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvOrderItemsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrderItemsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvOrderItemsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrderItemsList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvOrderItemsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvOrderItemsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrderItemsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrderItemsList_DataBindingComplete);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.lblTitle.Location = new System.Drawing.Point(350, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 46);
            this.lblTitle.TabIndex = 293;
            this.lblTitle.Text = "Order Items";
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
            this.btnClose.Location = new System.Drawing.Point(736, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 45);
            this.btnClose.TabIndex = 295;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowOrderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 473);
            this.Controls.Add(this.tcOrderItems);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowOrderItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Order Items";
            this.Load += new System.EventHandler(this.frmShowOrderItems_Load);
            this.tcOrderItems.ResumeLayout(false);
            this.tpOrderItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItemsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcOrderItems;
        private System.Windows.Forms.TabPage tpOrderItems;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrderItemsList;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
    }
}