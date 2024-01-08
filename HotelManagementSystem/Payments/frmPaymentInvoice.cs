using Hotel_BusinessLayer;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Payments
{
    public partial class frmPaymentInvoice : Form
    {
        private int _PaymentID = -1;

        private clsPayment _Payment;

        private Bitmap Image;
        public frmPaymentInvoice(int PaymentID)
        {
            InitializeComponent();
            _PaymentID = PaymentID;
        }
        private void _LoadInvoiceData()
        {
          

            Random random = new Random();

            lblInvoiceID.Text = random.Next(1, 10000).ToString();
            lblInvoiceDate.Text = DateTime.Now.ToString();

            lblPaymentID.Text = _Payment.PaymentID.ToString();
            lblBookingID.Text = _Payment.BookingID.ToString();
            lblPaymentDate.Text = _Payment.PaymentDate.ToString();
            lblPaidAmount.Text = _Payment.PaidAmount.ToString();
            lblGuestName.Text = _Payment.BookingInfo.GuestInfo.PersonInfo.FullName.ToString();
            lblPhone.Text = _Payment.BookingInfo.GuestInfo.PersonInfo.Phone.ToString();
            lblEmail.Text = _Payment.BookingInfo.GuestInfo.PersonInfo.Email.ToString();
            lblAddress.Text = _Payment.BookingInfo.GuestInfo.PersonInfo.Address.ToString();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            panel.Controls.Remove(btnPrint);

            _PrintInvoice(this.panel);
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            _Payment = clsPayment.Find(_PaymentID);

            if (_Payment == null)
            {
                MessageBox.Show($"No Payment with ID = {_PaymentID} was found !", "Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            _LoadInvoiceData();
        }

        private void _PrintInvoice(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel = pnl;

            _GetPrintArea(pnl);

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", this.Width, this.Height);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument_PrintPage(object sender , PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;

            int horizontalOffset = (pageArea.Width - this.Width+150) / 2;
            int verticalOffset = (pageArea.Height - this.Height) / 2;

            e.Graphics.DrawImage(Image, horizontalOffset, verticalOffset);
        }

        private void _GetPrintArea(Panel pnl)
        {      
            Image = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(Image, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

    }
}
