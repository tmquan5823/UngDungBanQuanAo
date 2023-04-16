using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BillDAL : Database
    {

        public List<BillDetail> GetBillDetailListById(int idBill)
        {
            List<BillDetail> list = new List<BillDetail>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = @"SELECT * FROM BillDetail WHERE BillID = @Id";
            sqlcmd.Connection = sqlCon;
            sqlcmd.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = idBill;
            SqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {
                BillDetail billDetail = new BillDetail();
                billDetail.BillID = reader.GetInt32(0);
                billDetail.SizeID = reader.GetInt32(1);
                billDetail.BuyQuantity = reader.GetInt32(2);
                billDetail.Price = reader.GetInt32(3);
                list.Add(billDetail);
            }
            reader.Close();
            return list;
        }
        public List<Bill> GetBillListByUserId(int userId)
        {
            List<Bill> list = new List<Bill>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "SELECT * FROM Bill WHERE UserID = @UserId;";
            sqlcmd.Connection = sqlCon;
            sqlcmd.Parameters.Add("UserId", System.Data.SqlDbType.Int).Value = userId;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Bill bill = new Bill();
                bill.BillID = reader.GetInt32(0);
                bill.UserID = reader.GetInt32(1);
                bill.TotalPrice = reader.GetInt32(2);
                bill.BuyDate = reader.GetDateTime(3);
                bill.paymentMethod = reader.GetString(4);
                bill.status = reader.GetString(5);
                bill.Tel = reader.GetString(6);
                bill.Address = reader.GetString(7);
                bill.receiver = reader.GetString(8);
                list.Add(bill);

            }
            reader.Close();
            return list;
        }
        public void RemoveDetailBillById(int billId)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = @"DELETE BillDetail WHERE BillID = @id;";
            sqlcmd.Connection = sqlCon;
            sqlcmd.Parameters.Add("UserId", System.Data.SqlDbType.Int).Value = billId;
            sqlcmd.ExecuteNonQuery();
        }

        public void RemoveBillById(int Id)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = @"DELETE Bill WHERE BillID = @Id;";
            sqlcmd.Connection = sqlCon;
            sqlcmd.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = Id;
            sqlcmd.ExecuteNonQuery();
        }


        public void AddBillByUserId(Bill bill)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = @"
            INSERT INTO Bill(UserID, TotalPrice, BuyDate, PaymentMethod, Billstatus, Tel, Address, Receiver)
            VALUES(bill.UserID, bill.TotalPrice, bill.BuyDate, bill.paymentMethod,bill.status, bill.Tel, bill.Address, bill.receiver); ";
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public void AddBillDetailByBillId(BillDetail billDetail)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = @"
             INSERT INTO BillDetail(BillID, SizeID, BuyQuatity, Price) 
             VALUES(billDetail.BillID, billDetail.SizeID, billDetail.BuyQuantity, billDetail.Price);";
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }

        /*
                public void UpdateDetailByBillId(BillDetailDTO billDetail)
                {
                    OpenConnection();
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.CommandType = System.Data.CommandType.Text;
                    sqlcmd.CommandText = "UPDATE UserInfo SET Tel  = '" + A.Tel + "', Email = '" + A.Email + "' , DateOfBirth = '" + A.DateOfBirth.ToString("yyyy-MM-dd") + "', Sex = '" + A.Sex + "', UserName = '" + A.UserName + "' WHERE UserID = " + A.UserID;
                    sqlcmd.Connection = sqlCon;
                    sqlcmd.ExecuteNonQuery();
                    return;
                }
        */

    }
}
