using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
                    
                    account.AccountID = reader.GetInt32(3);
                    account.UserRole = reader.GetString(2);
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

        public Boolean ChangeAccountPassword(Account A, string pass)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "update ACCOUNT set UserPassword = '" + pass + "' where UserAccount = '" + A.UserAccount + "'";
            sqlcmd.Connection = sqlCon;
            int kq = sqlcmd.ExecuteNonQuery();
            if (kq > 0) { return true; }
            return false;
        }

        public Account getAccountById(int ID)
        {
            Account app = new Account();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "SELECT * FROM Account WHERE AccountID  = " + ID + "";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                app.AccountID = reader.GetInt32(0);
                app.UserRole = reader.GetString(1);
                app.UserAccount = reader.GetString(2);
                app.UserPassword = reader.GetString(3);
            }
            reader.Close();
            return app;
        } 
        }
    }
