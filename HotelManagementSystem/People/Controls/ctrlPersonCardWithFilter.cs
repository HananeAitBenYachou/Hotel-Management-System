using Guna.UI2.WinForms;
using Hotel_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        //Define an event handler with parameters
        public event EventHandler<int> OnPersonSelected;
        
        //Create a protected virtual method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            OnPersonSelected?.Invoke(this,PersonID);
        }


        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }

            get
            {
                return _FilterEnabled;
            }
        }

        public int PersonID
        {
            get
            {
                return ctrlPersonCard1.PersonID;
            }

        }
        public clsPerson SelectedPerson
        {
            get
            {
                return ctrlPersonCard1.SelectedPerson;
            }
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid , please put the mouse over the red icon(s) to see the error", "Validation Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _FindPerson();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.OnPersonAdded += PersonAddedEvent;
            frm.ShowDialog();
        }

        private void PersonAddedEvent(object sender, int PersonID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();
            _FindPerson();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.ResetText();
            FilterFocus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required ! cannot be left blank");
                return;
            }

            else
            {
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Person ID")
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public void FilterFocus()
        {
            txtFilterValue.Select();
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Text = PersonID.ToString();    
            _FindPerson();
        }

        private void _FindPerson()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonData(int.Parse(txtFilterValue.Text.Trim()));
                    break;

                case "National No":
                    ctrlPersonCard1.LoadPersonData(txtFilterValue.Text.Trim());
                    break;
            }

            if(OnPersonSelected != null && FilterEnabled)
            {
                PersonSelected(ctrlPersonCard1.PersonID);
            }

        }

    }
}
