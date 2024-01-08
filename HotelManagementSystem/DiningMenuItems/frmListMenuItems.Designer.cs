namespace HotelManagementSystem.MenuItems
{
    partial class frmListMenuItems
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbItemType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMenuItemsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbFilterByOptions = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDisplayOption = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddMenuItem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmsMenuItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItemsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.cmsMenuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 376);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1199, 440);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Visible = false;
            // 
            // cbItemType
            // 
            this.cbItemType.BackColor = System.Drawing.Color.Transparent;
            this.cbItemType.BorderRadius = 22;
            this.cbItemType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItemType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItemType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cbItemType.ForeColor = System.Drawing.Color.Black;
            this.cbItemType.ItemHeight = 40;
            this.cbItemType.Items.AddRange(new object[] {
            "All",
            "Food",
            "Beverage"});
            this.cbItemType.Location = new System.Drawing.Point(397, 309);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(231, 46);
            this.cbItemType.StartIndex = 0;
            this.cbItemType.TabIndex = 35;
            this.cbItemType.Visible = false;
            this.cbItemType.SelectedIndexChanged += new System.EventHandler(this.cbItemType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(490, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 59);
            this.label1.TabIndex = 28;
            this.label1.Text = "Manage Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Filter By :";
            // 
            // dgvMenuItemsList
            // 
            this.dgvMenuItemsList.AllowUserToAddRows = false;
            this.dgvMenuItemsList.AllowUserToDeleteRows = false;
            this.dgvMenuItemsList.AllowUserToOrderColumns = true;
            this.dgvMenuItemsList.AllowUserToResizeColumns = false;
            this.dgvMenuItemsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvMenuItemsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenuItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvMenuItemsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuItemsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenuItemsList.ColumnHeadersHeight = 45;
            this.dgvMenuItemsList.ContextMenuStrip = this.cmsMenuItems;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenuItemsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenuItemsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvMenuItemsList.Location = new System.Drawing.Point(44, 376);
            this.dgvMenuItemsList.MultiSelect = false;
            this.dgvMenuItemsList.Name = "dgvMenuItemsList";
            this.dgvMenuItemsList.ReadOnly = true;
            this.dgvMenuItemsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenuItemsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenuItemsList.RowHeadersVisible = false;
            this.dgvMenuItemsList.RowHeadersWidth = 50;
            this.dgvMenuItemsList.RowTemplate.Height = 35;
            this.dgvMenuItemsList.Size = new System.Drawing.Size(1199, 440);
            this.dgvMenuItemsList.TabIndex = 30;
            this.dgvMenuItemsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvMenuItemsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvMenuItemsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMenuItemsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMenuItemsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMenuItemsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMenuItemsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMenuItemsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvMenuItemsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvMenuItemsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMenuItemsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvMenuItemsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMenuItemsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMenuItemsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvMenuItemsList.ThemeStyle.ReadOnly = true;
            this.dgvMenuItemsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvMenuItemsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMenuItemsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvMenuItemsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMenuItemsList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvMenuItemsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvMenuItemsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMenuItemsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMenuItemsList_DataBindingComplete);
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
            "Item ID",
            "Item Name",
            "Item Type"});
            this.cbFilterByOptions.Location = new System.Drawing.Point(136, 313);
            this.cbFilterByOptions.Name = "cbFilterByOptions";
            this.cbFilterByOptions.Size = new System.Drawing.Size(231, 41);
            this.cbFilterByOptions.TabIndex = 32;
            this.cbFilterByOptions.SelectedIndexChanged += new System.EventHandler(this.cbFilterByOptions_SelectedIndexChanged);
            // 
            // cbDisplayOption
            // 
            this.cbDisplayOption.BackColor = System.Drawing.Color.Transparent;
            this.cbDisplayOption.BorderRadius = 22;
            this.cbDisplayOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDisplayOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisplayOption.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDisplayOption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDisplayOption.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cbDisplayOption.ForeColor = System.Drawing.Color.Black;
            this.cbDisplayOption.ItemHeight = 40;
            this.cbDisplayOption.Items.AddRange(new object[] {
            "List",
            "Flow"});
            this.cbDisplayOption.Location = new System.Drawing.Point(774, 308);
            this.cbDisplayOption.Name = "cbDisplayOption";
            this.cbDisplayOption.Size = new System.Drawing.Size(231, 46);
            this.cbDisplayOption.StartIndex = 0;
            this.cbDisplayOption.TabIndex = 36;
            this.cbDisplayOption.SelectedIndexChanged += new System.EventHandler(this.cbDisplayOption_SelectedIndexChanged);
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
            this.txtFilterValue.Location = new System.Drawing.Point(397, 307);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "Search ...";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(315, 50);
            this.txtFilterValue.TabIndex = 34;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::HotelManagementSystem.Properties.Resources.room_service2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(473, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(349, 184);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 29;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddMenuItem.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddMenuItem.Image = global::HotelManagementSystem.Properties.Resources.menu1;
            this.btnAddMenuItem.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddMenuItem.ImageRotate = 0F;
            this.btnAddMenuItem.Location = new System.Drawing.Point(1178, 292);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddMenuItem.ShadowDecoration.BorderRadius = 0;
            this.btnAddMenuItem.ShadowDecoration.Depth = 20;
            this.btnAddMenuItem.Size = new System.Drawing.Size(65, 65);
            this.btnAddMenuItem.TabIndex = 33;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // cmsMenuItems
            // 
            this.cmsMenuItems.BackColor = System.Drawing.Color.White;
            this.cmsMenuItems.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cmsMenuItems.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsMenuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.cmsMenuItems.Name = "contextMenuStrip1";
            this.cmsMenuItems.Size = new System.Drawing.Size(198, 38);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.fast_food;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.editToolStripMenuItem.Text = "&Edit Item Info";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // frmListMenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 845);
            this.Controls.Add(this.cbDisplayOption);
            this.Controls.Add(this.cbItemType);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMenuItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMenuItemsList);
            this.Controls.Add(this.cbFilterByOptions);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListMenuItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListMenuItems";
            this.Load += new System.EventHandler(this.frmListMenuItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItemsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.cmsMenuItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbItemType;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddMenuItem;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMenuItemsList;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterByOptions;
        private Guna.UI2.WinForms.Guna2ComboBox cbDisplayOption;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.ContextMenuStrip cmsMenuItems;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}