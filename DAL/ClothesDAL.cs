using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClothesDAL : Database
    {
        public static ClothesDAL instance = new ClothesDAL();
        

        public Boolean checkInputID(int ID)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select ClothesID from Clothes where ClothesID = " + ID ;
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetInt32(0) == ID)
                {
                    reader.Close();
                    return false;
                }
            }
            reader.Close();
            return true;
        }
        public List<Clothes> getList()
        {
            List<Clothes> list = new List<Clothes>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Clothes";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Clothes app = new Clothes();
                app.clothesName = reader.GetString(0);
                app.clothesID = reader.GetInt32(1);
                app.price = reader.GetInt32(2);
                app.origin = reader.GetString(3);
                app.color = reader.GetString(4);
                app.clothesDescription = reader.GetString(5);
                list.Add(app);
            }
            reader.Close();
            return list;
        }

        public List<Clothes> getListByValue(string Value)
        {
            List<Clothes> list = new List<Clothes>();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Clothes ORDER BY " + Value + " ASC";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Clothes app = new Clothes();
                app.clothesName = reader.GetString(0);
                app.clothesID = reader.GetInt32(1);
                app.price = reader.GetInt32(2);
                app.origin = reader.GetString(3);
                app.color = reader.GetString(4);
                app.clothesDescription = reader.GetString(5);
                list.Add(app);
            }
            reader.Close();
            return list;
        }

        public Clothes getById(int ID)
        {
            Clothes app = new Clothes();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Clothes where ClothesID = " + ID + "";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                app.clothesName = reader.GetString(0);
                app.clothesID = reader.GetInt32(1);
                app.price = reader.GetInt32(2);
                app.origin = reader.GetString(3);
                app.color = reader.GetString(4);
                app.clothesDescription = reader.GetString(5);
            }
            reader.Close();
            return app;
        }

        public Clothes getByName(string ID)
        {
            Clothes app = new Clothes();
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "select * from Clothes where ClothesName = '" + ID + "'";
            sqlcmd.Connection = sqlCon;

            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                app.clothesName = reader.GetString(0);
                app.clothesID = reader.GetInt32(1);
                app.price = reader.GetInt32(2);
                app.origin = reader.GetString(3);
                app.color = reader.GetString(4);
                app.clothesDescription = reader.GetString(5);
            }
            reader.Close();
            return app;
        }
        public void RemoveClothes(int id)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "delete Clothes WHERE ClothesID = " + id;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public void AddClothes(Clothes u)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "insert into Clothes (ClothesName, Price, Origin, Color, ClothesDescription) values( N'" + u.clothesName + "', " + u.price + ", N'" + u.origin + "', N'" + u.color + "', N'" + u.clothesDescription + "')";
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
        public void UpdateUserInfo(Clothes A)
        {
            OpenConnection();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = System.Data.CommandType.Text;
            sqlcmd.CommandText = "UPDATE Clothes SET ClothesName  = N'" + A.clothesName + "', Price = " + A.price + " , Origin = N'" + A.origin + "', Color = N'" + A.color + "', ClothesDescription = N'" + A.clothesDescription + "' WHERE ClothesID = " + A.clothesID;
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
            return;
        }
    }
}
