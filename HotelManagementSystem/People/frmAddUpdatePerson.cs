using Guna.UI2.WinForms;
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

namespace HotelManagementSystem.People
{
    public partial class frmAddUpdatePerson : Form
    {
        //Define an event handler with parameters
        public event EventHandler<int> OnPersonAdded;

        //Create a protected virtual method to raise the event with a parameter
        protected virtual void PersonAdded(int PersonID)
        {
            OnPersonAdded?.Invoke(this, PersonID);
        }

        private enum enMode { AddNew = 0 , Update = 1};

        private enMode _Mode;

        private int _PersonID = -1;

        private clsPerson _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;
        }

        private void _LoadPersonData()
        {
            // Load the person data from the database
            _Person = clsPerson.Find(_PersonID);

            //Check if the Person was found
            if(_Person == null)
            {
                MessageBox.Show($"No Person with ID = {_PersonID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //If no person is found with this PersonID , close the form
                this.Close();
                return;
            }

            //fill the controls with the Person data
            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName.Trim();
            txtLastName.Text = _Person.LastName.Trim();
            txtNationalNo.Text = _Person.NationalNo.Trim();
            txtEmail.Text = _Person.Email.Trim();
            txtAddress.Text = _Person.Address.Trim();
            txtPhoneNo.Text = _Person.Phone.Trim();
            
            dtpBirthDate.Value = _Person.BirthDate;

            if (_Person.Gender == 'M')
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            cbCountries.SelectedIndex = cbCountries.FindString(_Person.CountryInfo.CountryName);

            if (_Person.PersonalImagePath != "")
                PersonImage.ImageLocation = _Person.PersonalImagePath;

            llbRemoveImage.Visible = (_Person.PersonalImagePath != "");
        }

        private bool _HandlePersonImage()
        {
            //This function will handle the person image changing process
            //In case the old image of the person is changed , we rename the new image with Guid and 
            //store it in images folder 

            if(_Person.PersonalImagePath != PersonImage.ImageLocation)
            {
                //delete the person's old image in case there is any 

                if (_Person.PersonalImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.PersonalImagePath);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                if (PersonImage.ImageLocation != null)
                {
                    //copy the new image to the images folder after renaming it

                    string DestinationFolder = @"C:\Hotel-People-Images\";
                    string SourceFile = PersonImage.ImageLocation;

                    if (!clsUtility.CopyImageToProjectImagesFolder(DestinationFolder,ref SourceFile))
                    {
                        MessageBox.Show("Error occured while copying the image","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    PersonImage.ImageLocation = SourceFile;
                    return true; 
                }
            }

           return true;
        }

        private void _SavePersonData()
        {
            if (!_HandlePersonImage())
            {
                return;
            }

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.Phone = txtPhoneNo.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.BirthDate = dtpBirthDate.Value;
            _Person.Gender = rbMale.Checked ? 'M' : 'F';
            _Person.NationalityCountryID = clsCountry.Find(cbCountries.Text).CountryID;
            _Person.PersonalImagePath = (PersonImage.ImageLocation != null) ? PersonImage.ImageLocation : "";

            if (_Person.Save())
            {
                MessageBox.Show($"Person Data Saved Successfully !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                lblTitle.Text = "Update Person";

                _PersonID = _Person.PersonID;
                lblPersonID.Text = _PersonID.ToString();

                //change the mode to update mode
                _Mode = enMode.Update;

                //Trigger the event to send data back to the caller
                if (OnPersonAdded != null)
                {
                    PersonAdded(_PersonID);
                }
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _FillCountriesInComboBox()
        {
            foreach(DataRow row in clsCountry.GetAllCountries().Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }

        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();

            if(_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }

            else
            {
                lblTitle.Text = "Update Person";
            }

            //reset the text value to empty for all the textboxes
            this.Text = lblTitle.Text;

            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtNationalNo.ResetText();
            txtEmail.ResetText();
            txtPhoneNo.ResetText();
            txtAddress.ResetText();

            //set the default country to Morocco
            cbCountries.SelectedIndex = cbCountries.FindString("Morocco");

            //set the maximum date to current date 
            dtpBirthDate.MaxDate = DateTime.Now;

            //shouldn't allow people older than 100 years 
            dtpBirthDate.MinDate = DateTime.Now.AddYears(-100);

            //set the default date to current date
            dtpBirthDate.Value = DateTime.Now;

            //set the default gender to male
            rbMale.Checked = true;

            //show the remove image link if there is no image sat for the person and show it if there is one
            llbRemoveImage.Visible = (PersonImage.Image != null);

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadPersonData();
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            Guna2TextBox TempTextBox = (Guna2TextBox)sender; 

            if(string.IsNullOrEmpty(TempTextBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TempTextBox, "This field is required ! cannot be left blank");
                return;
            }

            else
            {
                errorProvider1.SetError(TempTextBox, null);
            }
        }

        private void llbUploadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Load the selected image file
                PersonImage.Load(openFileDialog1.FileName);
                llbRemoveImage.Visible = true;
            }
        }

        private void llbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llbRemoveImage.Visible = false;

            PersonImage.ImageLocation = null;

            // reset the image to the default image according to the gender selected
            PersonImage.Image = rbMale.Checked ? Resources.male : Resources.female;

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "This field is required ! cannot be left blank");
                return;
            }

            else if(!clsValidation.ValidateEmailAddress(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format !");
                return;
            }

            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required ! cannot be left blank.");
                return;
            }

            else if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This NationalNo is already taken ! , please enter a valid one.");
                return;
            }

            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            //if there is no image set for the person we change the default image to male
            if (PersonImage.ImageLocation == null && rbMale.Checked)
                PersonImage.Image = Resources.male;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            //if there is no image set for the person we change the default image to female
            if (PersonImage.ImageLocation == null && rbFemale.Checked)
                PersonImage.Image = Resources.female;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _SavePersonData();
        }

    }
}
