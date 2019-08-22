﻿using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace webforms_aula1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        (string usuario, string senha) login;
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            login.usuario = "admin";
            login.senha = "admin";

            UsuarioBLL usuarioBll = new UsuarioBLL();
            if (usuarioBll.Logar(txtLogin.Text, txtSenha.Text))
            {

                Session[Util.Util.SessaoUsuarioLogado] = usuarioBll.UsuarioLogado;

                Response.Redirect("/Paginas/Principal.aspx");
            }
            else
            {
                lblMensagem.Text = "Usuario e/ou senha inválido";
            }


        }
    }
}