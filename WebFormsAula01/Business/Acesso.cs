using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business
{
    public static class Acesso
    {
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=DESKTOP-NKD8A3K\SQLEXPRESS;
                                        Initial Catalog=dbCursoCsharp;
                                        Persist Security Info=True;
                                        User ID=sa;
                                        Password=cubo123*";

                conexao.Open();
                return conexao;
            }
        }

    }
}
