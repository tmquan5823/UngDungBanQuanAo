using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BillBLL
    {
        public static BillBLL getInstance = new BillBLL();
        public Bill getBillByID(int ID)
        {
            return BillDAL.getInstance.getBillByID(ID);
        }
        public List<BillDetail> getBillDetailByBillID(int ID)
        {
            return BillDAL.getInstance.GetBillDetailListById(ID);
        }
        public List<Bill> getListByStatus(string Status)
        {
            return BillDAL.getInstance.getByCondition("BillStatus = '" + Status + "' ");
        }
        public List<Bill> getListBill()
        {
            return BillDAL.getInstance.getListBill();
        }
        public void updateBillStatus(int BillID, string Status)
        {
            BillDAL.getInstance.UpdateBillStatus(BillID, Status);
        }
        public List<Bill> getListBillByStatus(string Status)
        {
            return BillDAL.getInstance.getListBillByStatus(Status);
        }
        public int getTotalBillsByStatus(string Status)
        {
            return BillDAL.getInstance.getTotalBillsByStatus(Status);
        }
        public int getTotalPriceAllBills()
        {
            return BillDAL.getInstance.getTotalPriceAllBill();
        }
        
        
    }
}