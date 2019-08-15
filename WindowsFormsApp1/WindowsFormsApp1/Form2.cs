using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            bool valido = true;
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Preencher o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }

            if (txtSobrenome.Text == string.Empty)
            {
                MessageBox.Show("Preencher o Sobrenome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }

            if (txtDataNascimento.Text == string.Empty)
            {
                MessageBox.Show("Preencher a Data de Nascimento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }

            if (valido == false)
            {
                return;
            }

            string nome, sobreNome;
            DateTime dataNascimento;
            nome = txtNome.Text;
            sobreNome = txtSobrenome.Text;
            dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            
            MessageBox.Show($@"Nome: {nome} sobrenome: {sobreNome} 
                               dataNascimento: {dataNascimento}");
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
