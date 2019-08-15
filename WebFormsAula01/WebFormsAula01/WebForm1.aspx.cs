using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsAula01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario() == false)
            {
                lblNomeCompleto.Text = "Preecher todos os campos do formulário";
                return;//Retorno para sair do IF, para não ficar repetindo
            }
            lblNomeCompleto.Text = ExibirNomeCompleto(txtNome.Text, txtSobrenome.Text);
            LimparCampos();
        }
        private string ExibirNomeCompleto(string nome, string sobrenome)
        {
            string nomeCompleto = $"{txtNome.Text} {txtSobrenome.Text}";
            return nomeCompleto;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            lblNomeCompleto.Text = string.Empty;
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
        }

        private bool ValidarFormulario()
        {
            bool valido = true;
            if (txtNome.Text == string.Empty)
            {
                valido = false;
            }
            if (txtSobrenome.Text == string.Empty)
            {
                valido = false;

            }

            return valido;
        }
    }
}