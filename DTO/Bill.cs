using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        public int BillID { set; get; }
        public int UserID { set; get; }
        public int TotalPrice { set; get; }
        public DateTime BuyDate { set; get; }
        public string paymentMethod { set; get; }
        public string status { set; get; }
        public string Tel { set; get; }
        public string Address { set; get; }
        public string receiver { set; get; }
        public Bill(int BillID, int UserID, int TotalPrice, DateTime BuyDate, string paymentMethod, string status, string Tel, string Address, string Receiver)
        {
            this.BillID = BillID;
            this.UserID = UserID;
            this.TotalPrice = TotalPrice;
            this.BuyDate = BuyDate;
            this.paymentMethod = paymentMethod;
            this.status = status;
            this.Tel = Tel;
            this.Address = Address;
            this.receiver = receiver;
        }
        public Bill() { }
    }
}
