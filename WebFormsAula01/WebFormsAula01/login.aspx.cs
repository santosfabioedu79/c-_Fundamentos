using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsAula01
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string usuario = "admin";
        string senha = "admin";

        (string usuario, string senha) Login;
        protected void submit_Click(object sender, EventArgs e)
        {
            Login.usuario = "admim";
            Login.senha = "admin";

            UsuarioBLL usuarioBll = new UsuarioBLL();

            if (usuarioBll.Logar(txtLogin.Text, txtLogin.Text))
            {

                Session[Util.Util.SessaoUsuarioLogado] = usuarioBll.UsuarioLogado;

                Response.Redirect("/Paginas/Principal.aspx");
            }
            else
            {
                lblMensagem.Text = "Usuario e senha incorretos";
            }    
        }
    }
}