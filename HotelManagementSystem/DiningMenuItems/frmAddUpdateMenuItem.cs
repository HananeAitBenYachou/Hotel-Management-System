using Hotel_BusinessLayer;
using HotelManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.DiningMenuItems
{
    public partial class frmAddUpdateMenuItem : Form
    {
        private enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode;

        private int _MenuItemID = -1;


        private clsMenuItem _MenuItem;

        public frmAddUpdateMenuItem(int MenuItemID)
        {
            InitializeComponent();
            _MenuItemID = MenuItemID;
            _Mode = enMode.Update;
        }

        public frmAddUpdateMenuItem()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void frmAddUpdateMenuItem_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadMenuItemData();
        }

        private void _LoadMenuItemData()
        {
            _MenuItem = clsMenuItem.Find(_MenuItemID);

            if (_MenuItem == null)
            {
                MessageBox.Show($"No MenuItem with ID = {_MenuItemID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblItemID.Text = _MenuItem.ItemID.ToString();
            txtItemName.Text = _MenuItem.ItemName;
            txtPrice.Text = _MenuItem.Price.ToString();
            txtDescription.Text = _MenuItem.Description;
            cbItemType.SelectedIndex = cbItemType.FindString(_MenuItem.ItemTypeText);

            if (_MenuItem.ImagePath != "")
                ItemImage.ImageLocation = _MenuItem.ImagePath;

            llbRemoveImage.Visible = (_MenuItem.ImagePath != "");
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New MenuItem";
                _MenuItem = new clsMenuItem();
            }

            else
            {
                lblTitle.Text = "Update MenuItem";
            }

            this.Text = lblTitle.Text;

            lblItemID.Text = "[????]";
            txtItemName.Text = "[????]";
            txtPrice.Text = "[????]";
            txtDescription.Text = "[????]";
            cbItemType.SelectedIndex = 0;

            llbRemoveImage.Visible = (ItemImage.ImageLocation != null);
        }

        private void txtItemName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtItemName, "This field is required ! cannot be left blank");
                return;
            }

            else if (_MenuItem.ItemName != txtItemName.Text && clsMenuItem.IsMenuItemExist(txtItemName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtItemName, "This MenuItem already exists !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtItemName, null);
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsNumber(txtPrice.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "Invalid Number !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtPrice, null);
            }
        }

        private bool _HandleItemImage()
        {
            if(_MenuItem.ImagePath != ItemImage.ImageLocation)
            {
                if(_MenuItem.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_MenuItem.ImagePath);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                if(ItemImage.ImageLocation != null)
                {
                    string sourceFile = ItemImage.ImageLocation;

                    string destinationFolder = @"C:\Hotel-MenuItems-Images\";

                    if(!clsUtility.CopyImageToProjectImagesFolder(destinationFolder,ref sourceFile))
                    {
                        MessageBox.Show("Error occured while copying the image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    ItemImage.ImageLocation = sourceFile;
                    return true;
                }
            }

            return true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_HandleItemImage())
                return;

            _MenuItem.ItemName = txtItemName.Text;
            _MenuItem.Price = Convert.ToSingle(txtPrice.Text);
            _MenuItem.Description = txtDescription.Text != "" ? txtDescription.Text : "";
            _MenuItem.ItemType = (clsMenuItem.enItemTypes)(cbItemType.SelectedIndex + 1);
            _MenuItem.ImagePath = ItemImage.ImageLocation != null ? ItemImage.ImageLocation : "";

            if (_MenuItem.Save())
            {
                MessageBox.Show("MenuItem Data saved successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;

                lblItemID.Text = _MenuItem.ItemID.ToString();

                lblTitle.Text = "Update MenuItem";
                this.Text = lblTitle.Text;
            }

            else
            {
                MessageBox.Show("Error: Data is not saved successfully.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ItemImage.ImageLocation = openFileDialog1.FileName;
                llbRemoveImage.Visible = true;
            }
        }

        private void llbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llbRemoveImage.Visible = false;
            ItemImage.ImageLocation = null;
            ItemImage.Image = Resources.questionMark;
        }


    }

}
