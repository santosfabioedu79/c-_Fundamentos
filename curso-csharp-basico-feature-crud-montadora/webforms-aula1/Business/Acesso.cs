using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Acesso
    {
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-NKD8A3K\SQLEXPRESS;
                                        Initial Catalog=dbCursoCsharp;
                                        Persist Security Info=True;
                                        User ID=sa;
                                        Password=cubo123*";
                conn.Open();

                return conn;
            }
        }
    }
}
