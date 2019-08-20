using Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Business
{
    public class MontadoraBLL
    {
        public void Salvar(montadoraModel model)
        {
            if (model.ID == 0) 
            {
                Adicionar(model);
                return;
            }
            Alterar(model);
        }

        private void Adicionar(montadoraModel model)
        {
            

            SqlCommand comando = new SqlCommand();
            comando.Connection = Acesso.Connection;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = $@"insert into Montadora (nome, logo) values ('{model.Nome}','{model.Logo}')";

            comando.ExecuteNonQuery();
            Acesso.Connection.Close();
        }

        private void Alterar(montadoraModel model)
        {

        }

        public DataSet Buscar()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Acesso.Connection;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from montadora";

            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Acesso.Connection.Close();
            return ds;
        }

    }
}
