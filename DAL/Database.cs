using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        public string strCon = @"Data Source=LAPTOP-0IQ7Q3Q3;Initial Catalog=DOTNET;Integrated Security=True";
        //public string strCon = @"Data Source=DESKTOP-98HRCRQ\SQLEXPRESS;Initial Catalog=DOTNET;Integrated Security=True";
<<<<<<< HEAD
        //public string strCon = @"Data Source=LAPTOP-D43G7L68\SQLEXPRESS;Initial Catalog=DOTNET;Integrated Security=True";
=======
         public string strCon = @"Data Source=LAPTOP-FAE46JCQ\QUOCMINH;Initial Catalog=DOTNET;User ID=sa;Password=123456";
>>>>>>> a73b1f0a267558ea67d4d8ff0e00d28fb59ff003


        public SqlConnection sqlCon = null;
        public void OpenConnection()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
        }
    }
}
