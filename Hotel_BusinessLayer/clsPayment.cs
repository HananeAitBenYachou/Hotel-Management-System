using Hotel_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_BusinessLayer
{
    public class clsPayment
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int PaymentID { get; private set; }
        public int BookingID { get; set; }
        public DateTime PaymentDate { get; set; }
        public float PaidAmount { get; set; }
        public int CreatedByUserID { get; set; }

        public clsBooking BookingInfo { get; }

        public clsPayment()
        {
            _Mode = enMode.AddNew;
            PaymentID = -1;
            BookingID = -1;
            PaymentDate = DateTime.Now;
            PaidAmount = -1;
            CreatedByUserID = -1;
        }
        private clsPayment(int PaymentID, int BookingID, DateTime PaymentDate, float PaidAmount, int CreatedByUserID)
        {
            _Mode = enMode.Update;
            this.PaymentID = PaymentID;
            this.BookingID = BookingID;
            this.PaymentDate = PaymentDate;
            this.PaidAmount = PaidAmount;
            this.CreatedByUserID = CreatedByUserID;
            BookingInfo = clsBooking.Find(BookingID);
        }

        public static clsPayment Find(int PaymentID)
        {
            int BookingID = -1;
            DateTime PaymentDate = DateTime.Now;
            float PaidAmount = -1;
            int CreatedByUserID = -1;

            bool IsFound = clsPaymentData.GetPaymentInfoByID(PaymentID, ref BookingID, ref PaymentDate, ref PaidAmount, ref CreatedByUserID);

            if (IsFound)
                return new clsPayment(PaymentID, BookingID, PaymentDate, PaidAmount, CreatedByUserID);
            else
                return null;
        }

        public static bool IsPaymentExist(int PaymentID)
        {
            return clsPaymentData.IsPaymentExist(PaymentID);
        }

        private bool _AddNewPayment()
        {
            PaymentID = clsPaymentData.AddNewPayment(BookingID, PaymentDate, PaidAmount, CreatedByUserID);
            return PaymentID != -1;
        }

        private bool _UpdatePayment()
        {
            return clsPaymentData.UpdatePaymentInfo(PaymentID, BookingID, PaymentDate, PaidAmount, CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePayment();

            }
            return false;
        }

        public static bool DeletePayment(int PaymentID)
        {
            return clsPaymentData.DeletePayment(PaymentID);
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentData.GetAllPayments();
        }

        public static DataTable GetAllPayments(int GuestID)
        {
            return clsPaymentData.GetAllPayments(GuestID);
        }

        public static int GetPaymentsCount()
        {
            return clsPaymentData.GetPaymentsCount();
        }

    }
}
