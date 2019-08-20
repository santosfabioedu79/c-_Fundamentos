using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Model;
using Business;

namespace WebFormsAula01.Paginas.Montadora
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MontadoraBLL montBLL = new MontadoraBLL();

            gridViewMontadora.DataSource = montBLL.Buscar();
            gridViewMontadora.DataBind();
        }

        protected void gridViewMontadora_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
        }
    }
}