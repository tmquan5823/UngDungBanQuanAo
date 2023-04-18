using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DAL
{
    public class UserInfoDAL : Database
    {
        public static UserInfoDAL getInstance = new UserInfoDAL();
        public int getIDByTelAndEmail(string Tel, string Email)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select UserID, Tel, Email from UserInfo where Tel = '" + Tel + "' AND Email = '" + Email + "'";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetString(1) == Tel && reader.GetString(2) == Email)
                {
                    int ID = reader.GetInt32(0);
                    reader.Close();
                    return ID;
                }
            }
            reader.Close();
            return -1;
        }

        public Boolean addUserInfo(UserInfo userInfo)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "insert into UserInfo(Tel, Email, DateOfBirth, Sex, UserName, AccountID, Address) values('" + userInfo.Tel + "','" + userInfo.Email + "','" + userInfo.DateOfBirth.ToString("yyyy/MM/dd") + "', N'" + userInfo.Sex + "', N'" + userInfo.UserName + "', " + userInfo.AccountID + ", N'" + userInfo.Address + "')";
            sqlcmd.Connection = sqlCon;
            int kq = sqlcmd.ExecuteNonQuery();
            if (kq > 0) return true;
            return false;
        }

        public List<UserInfo> getList()
        {
            List<UserInfo> list = new List<UserInfo>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from UserInfo";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                UserInfo app = new UserInfo();
                app.UserID = reader.GetInt32(0);
                app.Tel = reader.GetString(1);
                app.Email = reader.GetString(2);
                app.DateOfBirth = reader.GetDateTime(3);
                app.Sex = reader.GetString(4);
                app.UserName = reader.GetString(5);
                app.AccountID = reader.GetInt32(6);
                app.Address = reader.GetString(7);
                list.Add(app);
            }
            reader.Close();
            return list;
        }

        public UserInfo getById(int ID)
        {
            UserInfo app = new UserInfo();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from UserInfo where UserID = " + ID + "";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                app.UserID = reader.GetInt32(0);
                app.Tel = reader.GetString(1);
                app.Email = reader.GetString(2);
                app.DateOfBirth = reader.GetDateTime(3);
                app.Sex = reader.GetString(4);
                app.UserName = reader.GetString(5);
                app.AccountID = reader.GetInt32(6);
                app.Address = reader.GetString(7);
            }
            reader.Close();
            return app;
        }
        public UserInfo getByAccountId(int ID)
        {
            UserInfo app = new UserInfo();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from UserInfo where AccountID = " + ID;
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                app.UserID = reader.GetInt32(0);
                app.Tel = reader.GetString(1);
                app.Email = reader.GetString(2);
                app.DateOfBirth = reader.GetDateTime(3);
                app.Sex = reader.GetString(4);
                app.UserName = reader.GetString(5);
                app.AccountID = reader.GetInt32(6);
                app.Address = reader.GetString(7);
            }
            reader.Close();
            return app;
        }

        public void RemoveUserInfo(int id)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "delete UserInfo WHERE UserID = " + id;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }

        public Boolean AddUserInfo(UserInfo u)

        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "insert into UserInfo(Tel, Email, DateOfBirth, Sex, UserName, AccountID) values('" + u.Tel + "', '" + u.Email + "', '" + Convert.ToDateTime(u.DateOfBirth) + "', '" + u.Sex + "', '" + u.UserName + "', '" + u.AccountID + ")";
            sqlcmd.Connection = sqlCon;
            int kq = sqlcmd.ExecuteNonQuery();
            if (kq > 0) return true;
            else return false;
        }

        public Boolean UpdateUserInfo(UserInfo A)

        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "UPDATE UserInfo SET Tel  = '" + A.Tel + "', Email = '" + A.Email + "' , DateOfBirth = '" + A.DateOfBirth.ToString("yyyy-MM-dd") + "', Sex = '" + A.Sex + "', UserName = '" + A.UserName + "', Address = '" + A.Address + "' WHERE AccountId = " + A.AccountID;
            sqlcmd.Connection = sqlCon;
            int kq = sqlcmd.ExecuteNonQuery();
            if (kq > 0) return true;
            return false;
        }
        public Boolean CheckNewAccount(int accID)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from UserInfo where AccountID =" + accID;
            sqlcmd.Connection = sqlCon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            if(reader.Read()) { 
                if(reader.GetInt32(6) == accID)
                {
                    reader.Close();
                    return false;
                }
            }
            reader.Close();
            return true;
        }
    }
}
