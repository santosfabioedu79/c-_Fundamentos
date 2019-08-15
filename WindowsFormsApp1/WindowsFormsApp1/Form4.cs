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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento = DateTime.Parse(txtDataNascimento.Text);
            int idade = DateTime.Today.Year - dataNascimento.Year;

            if (DateTime.Today.Month < dataNascimento.Month)
            {
                idade--;
            }

                if (DateTime.Today.Month < dataNascimento.Month)
            {
                if (DateTime.Today.Day < dataNascimento.Day)
                {
                    idade--;
                }
            }

            MessageBox.Show(idade.ToString());
        }

        private void TxtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
