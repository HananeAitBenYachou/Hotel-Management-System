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

namespace HotelManagementSystem.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private int _PersonID = -1;

        private clsPerson _Person; 

        public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }

        public clsPerson SelectedPerson
        {
            get
            {
                return _Person;
            }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void ResetPersonInfo()
        {
            //reset the controls in the form to their default values

            PersonImage.ImageLocation = null;
            PersonImage.Image = Resources.male;
            genderIcon.Image = Resources.man;
                 
            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblGender.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblEmail.Text = "[????]";
            lblAddress.Text = "[????]";
            lblPhoneNo.Text = "[????]";
            lblBirthDate.Text = "[????]";
            lblCountry.Text = "[????]"; 
        }

        private void _LoadDefaultPersonImage(string Gender)
        {
            genderIcon.Image = (Gender == "Male") ? Resources.man : Resources.woman;
            PersonImage.Image = (Gender == "Male") ? Resources.male : Resources.female;
        }

        private void _LoadPersonImageIfExists()
        {
          
            if (_Person.PersonalImagePath != "")
            {
                if(File.Exists(_Person.PersonalImagePath))
                {
                    PersonImage.ImageLocation = _Person.PersonalImagePath;
                }
                else
                {
                    MessageBox.Show("Error : Person image is not found !","Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }

        private void _LoadPersonData()
        {
            _PersonID = _Person.PersonID;

            lblPersonID.Text = _PersonID.ToString();
            lblFullName.Text = _Person.FullName;
            lblGender.Text = _Person.Gender == 'M' ? "Male" : "Female";
            lblNationalNo.Text = _Person.NationalNo;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblPhoneNo.Text = _Person.Phone;
            lblBirthDate.Text = _Person.BirthDate.ToShortDateString();
            lblCountry.Text = _Person.CountryInfo.CountryName;

            _LoadDefaultPersonImage(lblGender.Text);
            _LoadPersonImageIfExists();

            llbEditPersonInfo.Enabled = true;
        }

        public void LoadPersonData(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person == null)
            {
                MessageBox.Show($"No Person with ID = {PersonID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //If no person is found with this PersonID , then reset to the controls default values
                ResetPersonInfo();
                return;
            }

            _LoadPersonData();
        }

        public void LoadPersonData(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                MessageBox.Show($"No Person with NationalNo = {NationalNo} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //If no person is found with this NationalNo , then reset to the controls default values
                ResetPersonInfo();
                return;
            }

            _LoadPersonData();
        }

        private void llbEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            LoadPersonData(_PersonID);
        }

    }
}
