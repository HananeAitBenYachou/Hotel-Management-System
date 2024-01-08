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

namespace HotelManagementSystem.Reservations
{
    public partial class frmShowPersonReservationHistory : Form
    {
        private int _PersonID;

        public frmShowPersonReservationHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmShowPersonReservationHistory_Load(object sender, EventArgs e)
        {
            clsPerson Person = clsPerson.Find(_PersonID);

            if (Person == null)
            {
                MessageBox.Show($"No Person with ID = {_PersonID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonCard1.LoadPersonData(_PersonID);
            dgvReservationsList.DataSource = clsReservation.GetAllReservations(_PersonID);

        }

        private void dgvReservationsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewColumn column in dgvReservationsList.Columns)
            {
                column.Width = 150;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
