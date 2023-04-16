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
        public Boolean CheckAccount(Account account)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select UserAccount, UserPassword, UserRole from Account where UserAccount = '" + account.UserAccount + "'";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetString(1) == account.UserAccount)
                {
                    account.UserRole = reader.GetString(2);
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            return false;
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
    }
}
