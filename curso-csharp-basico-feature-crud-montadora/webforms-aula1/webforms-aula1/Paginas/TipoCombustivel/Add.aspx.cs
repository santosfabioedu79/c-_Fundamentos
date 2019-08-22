﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Business.Model;

namespace webforms_aula1.Paginas.TipoCombustivel
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Lista.aspx");
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var tipoCombustivelBll = new TipoCombustivelBLL();
            tipoCombustivelBll.Salvar(new TipoCombustivelModel
            {
                Descricao = txtDescricao.Text
            });
        }
    }
}