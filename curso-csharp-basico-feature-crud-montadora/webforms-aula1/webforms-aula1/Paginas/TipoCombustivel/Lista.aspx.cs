using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Business.Model;

namespace webforms_aula1.Paginas.TipoCombustivel
{
    public partial class Lista : System.Web.UI.Page
    {
        TipoCombustivelBLL = new tipoCombustivelBLL.TipoCombustivelBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNovoTipo_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Add.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}