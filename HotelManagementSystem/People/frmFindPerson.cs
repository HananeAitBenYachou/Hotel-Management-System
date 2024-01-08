using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.People
{
    public partial class frmFindPerson : Form
    {
        //Create a delegate
        public delegate void PersonIDBackEventHandler(object sender , int PersonID);

        //Define an event using the delegate 
        
        public event PersonIDBackEventHandler PersonIDBack;

        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PersonIDBack?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
            this.Close();
        }

    }
}
