namespace HotelManagementSystem.Orders
{
    partial class ctrlBookingInfoWithFilter
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
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearchBooking = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlBookingInfo1 = new HotelManagementSystem.Bookings.Controls.ctrlBookingInfo();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Controls.Add(this.btnSearchBooking);
            this.gbFilter.Controls.Add(this.label12);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbFilter.ForeColor = System.Drawing.Color.Black;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(927, 104);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.Text = "Filter";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderColor = System.Drawing.Color.Silver;
            this.txtFilterValue.BorderRadius = 22;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFilterValue.ForeColor = System.Drawing.Color.Black;
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(354, 49);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Multiline = true;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(242, 41);
            this.txtFilterValue.TabIndex = 161;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // btnSearchBooking
            // 
            this.btnSearchBooking.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchBooking.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnSearchBooking.Image = global::HotelManagementSystem.Properties.Resources.booking;
            this.btnSearchBooking.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearchBooking.ImageRotate = 0F;
            this.btnSearchBooking.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchBooking.Location = new System.Drawing.Point(620, 41);
            this.btnSearchBooking.Name = "btnSearchBooking";
            this.btnSearchBooking.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchBooking.ShadowDecoration.Depth = 10;
            this.btnSearchBooking.Size = new System.Drawing.Size(50, 50);
            this.btnSearchBooking.TabIndex = 126;
            this.btnSearchBooking.Click += new System.EventHandler(this.btnSearchBooking_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 23);
            this.label12.TabIndex = 160;
            this.label12.Text = "Find By :";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BorderRadius = 22;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFilterBy.ItemHeight = 35;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Booking ID",
            "Reservation ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(124, 49);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(202, 41);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 159;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlBookingInfo1
            // 
            this.ctrlBookingInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlBookingInfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlBookingInfo1.Location = new System.Drawing.Point(0, 113);
            this.ctrlBookingInfo1.Name = "ctrlBookingInfo1";
            this.ctrlBookingInfo1.Size = new System.Drawing.Size(927, 518);
            this.ctrlBookingInfo1.TabIndex = 4;
            // 
            // ctrlBookingInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlBookingInfo1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlBookingInfoWithFilter";
            this.Size = new System.Drawing.Size(927, 631);
            this.Load += new System.EventHandler(this.ctrlBookingInfoWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearchBooking;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bookings.Controls.ctrlBookingInfo ctrlBookingInfo1;
    }
}
