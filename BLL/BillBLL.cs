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

        public string processMoney(int Money)
        {
            if (Money > 0 && Money <= 999)
            {
                return Money + ".000";
            }
            else if (Money >= 1000 && Money <= 9999)
            {
                int nghin = Money % 1000;
                int tram = (Money - nghin * 1000);
                return nghin + "." + proccess3Num(tram) + ".000";
            }
            else
            {
                int trieu = Money % 1000000;
                int nghin = (Money - trieu * 1000000) % 1000;
                int tram = (Money - nghin * 1000 - trieu * 1000000);
                if (nghin > 0) { }
                return trieu + "." + this.proccess3Num(nghin) + "." + this.proccess3Num(tram) + ".000";
            }
        }
        public string proccess3Num(int Num)
        {
            if (Num > 0 && Num < 10)
            {
                return "00" + Num;
            }
            else if (Num >= 10 && Num < 100)
            {
                return "0" + Num;
            }
            else
            {
                return Num + "";
            }
        }
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

        public List<Bill> getListBillByUserID(int ID)
        {
            return BillDAL.getInstance.GetBillListByUserId(ID);
        }
        public List<BillDetail> getListBillDetailsByBillID(int BillID)
        {
            return BillDAL.getInstance.GetBillDetailListById(BillID);
        }

    }
}