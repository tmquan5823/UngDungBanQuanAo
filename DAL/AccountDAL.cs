using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AccountDAL : Database
    {
        public static AccountDAL Instance = new AccountDAL();
        public Boolean CheckAccountPassword(Account account)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select UserAccount, UserPassword, UserRole, AccountID from ACCOUNT where UserAccount = '" + account.UserAccount   + "'";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetString(1) == account.UserPassword)
                {
                    account.UserRole = reader.GetString(2);
                    account.AccountID = reader.GetInt32(3);
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false;
        }

        public string CheckAccount(Account account)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Account where UserAccount = '" + account.UserAccount + "'"; 
            sqlcmd.Connection = sqlCon;
            SqlDataReader r = sqlcmd.ExecuteReader();
            if (r.Read())
            {
                if(r.GetString(2) == account.UserAccount)
                {
                    r.Close();
                    return "Tài khoản đã tồn tại!";
                }
            }
            r.Close();
            return "Đăng kí thành công!";
        }

        public void AddAccount(Account a)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "insert into Account(UserAccount, UserPassword, UserRole) values('" + a.UserAccount + "', '" + a.UserPassword + "', 'Customer')";
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public Boolean ChangeAccountPassword(Account a, string pass)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "update ACCOUNT set UserPassword = '" + pass +"' where UserAccount = '" + a.UserAccount + "'";
            sqlcmd.Connection = sqlCon;
            int kq = sqlcmd.ExecuteNonQuery();
            if(kq > 0) { return true; }
            return false;
        }
    }
}
