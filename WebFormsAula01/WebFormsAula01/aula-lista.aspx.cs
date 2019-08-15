﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsAula01
{
    public partial class aula_lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lstEmails.Items.Add(txtEmail.Text);
            ddlEmail.Items.Add(txtEmail.Text);
            txtEmail.Text = string.Empty;
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
            string itemSelecionado = lstEmails.SelectedValue;
            lstEmails.Items.Remove(itemSelecionado);
            txtEmail.Text = string.Empty;
        }
    }
}