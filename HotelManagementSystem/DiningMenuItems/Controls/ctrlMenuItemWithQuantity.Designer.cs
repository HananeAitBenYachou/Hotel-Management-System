namespace HotelManagementSystem.MenuItems
{
    partial class ctrlMenuItemWithQuantity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctrlMenuItemInfo1 = new HotelManagementSystem.MenuItems.ctrlMenuItemInfo();
            this.nudQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlMenuItemInfo1
            // 
            this.ctrlMenuItemInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlMenuItemInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlMenuItemInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlMenuItemInfo1.Name = "ctrlMenuItemInfo1";
            this.ctrlMenuItemInfo1.Size = new System.Drawing.Size(285, 283);
            this.ctrlMenuItemInfo1.TabIndex = 0;
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.nudQuantity.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nudQuantity.BorderRadius = 22;
            this.nudQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nudQuantity.Location = new System.Drawing.Point(25, 211);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(114, 48);
            this.nudQuantity.TabIndex = 180;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveToolStripMenuItem});
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(230, 74);
            // 
            // RemoveToolStripMenuItem
            // 
            this.RemoveToolStripMenuItem.BackColor = System.Drawing.Color.DarkOrange;
            this.RemoveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RemoveToolStripMenuItem.Image = global::HotelManagementSystem.Properties.Resources.minus_button;
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(229, 42);
            this.RemoveToolStripMenuItem.Text = "&Remove";
            this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // ctrlMenuItemWithQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.ContextMenuStrip1;
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.ctrlMenuItemInfo1);
            this.Name = "ctrlMenuItemWithQuantity";
            this.Size = new System.Drawing.Size(285, 283);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlMenuItemInfo ctrlMenuItemInfo1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuantity;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
    }
}
