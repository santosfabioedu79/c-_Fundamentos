using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Business.Model;


namespace WebFormsAula01.Paginas.Montadora
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            MontadoraBLL montadoraBLL = new MontadoraBLL();
            montadoraModel model = new montadoraModel();

            model.Nome = txtNomeMontadora.Text;
            model.Logo = "teste.png";

            montadoraBLL.Salvar(model);

            Response.Redirect("./List.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("List.aspx");
        }
    }
}