using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDetail
    {
        public int BillID { set; get; }
        public int SizeID { set; get; }
        public int BuyQuantity { set; get; }
        public int Price { set; get; }
        public BillDetail(int BillID, int SizeID, int BuyQuantity, int Price)
        {
            this.BillID = BillID;
            this.SizeID = SizeID;
            this.BuyQuantity = BuyQuantity;
            this.Price = Price;
        }
        public BillDetail() { }
    }
}
