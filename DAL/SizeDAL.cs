using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAL
{
    public class SizeDAL : Database
    {
        public static SizeDAL Instance = new SizeDAL();
        public List<SizeClothes> getListByClothesID(int ID)
        {
            List<SizeClothes> list = new List<SizeClothes>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Size WHERE ClothesID = " + ID;
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                SizeClothes app = new SizeClothes();
                app.SizeID = reader.GetInt32(0);
                app.NameSize = reader.GetString(1);
                app.quantity = reader.GetInt32(2);
                app.clothesID = reader.GetInt32(3);
                list.Add(app);
            }
            reader.Close();
            return list;
        }
        public SizeClothes getById(int ID)
        {
            SizeClothes app = new SizeClothes();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Size where SizeID = " + ID + "";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                app.SizeID = reader.GetInt32(0);
                app.NameSize = reader.GetString(1);
                app.quantity = reader.GetInt32(2);
                app.clothesID = reader.GetInt32(3);
            }
            reader.Close();
            return app;
        }
        public void RemoveSize(int id)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "delete Size WHERE SizeID = " + id;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public void AddSize(SizeClothes u)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "insert into Size (NameSize, Quantity, ClothesID) values('" + u.NameSize + "', " + u.quantity + ", " + u.clothesID + ")";
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public void UpdateUserInfo(SizeClothes A)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "UPDATE Size SET NameSize  = '" + A.NameSize + "', Quantity = " + A.quantity + " , ClothesID = " + A.clothesID + " WHERE SizeID = " + A.SizeID;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
            return;
        }

        public int numberOfClothes(int id)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Size where ClothesID =" + id;
            sqlcmd.Connection = sqlCon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            int count = 0;
            while (reader.Read()) {
                count += reader.GetInt32(2);
            }
            reader.Close();
            return count;
        }

        public SizeClothes getNumberBySizeAndClothesID(string Size, int ID)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Size where ClothesID = " + ID + " AND NameSize = '" + Size + "'" ;
            sqlcmd.Connection = sqlCon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            SizeClothes app = new SizeClothes();
            while (reader.Read())
            {
                app.SizeID = reader.GetInt32(0);
                app.NameSize = reader.GetString(1);
                app.quantity = reader.GetInt32(2);
                app.clothesID = reader.GetInt32(3);
            }
            reader.Close();
            return app;

        }

        public void updateNumberOfSize(string Size, int cloID, int quantity)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "UPDATE Size SET Quantity  = " + quantity + " WHERE NameSize = '" + Size  + "' AND ClothesID = " + cloID ;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
            return;
        }
    }
}
