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
    public partial class frmPoupanca : Form
    {
        public frmPoupanca()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            DateTime previsaoSaque = Convert.ToDateTime(txtPrevSaque.Text);
            String nome = Convert.ToString(txtNome.Text);
            int totalMeses = Convert.ToInt32((previsaoSaque - DateTime.Today).TotalDays / 30);

            decimal saldo = Convert.ToDecimal(txtSaldo.Text);

            decimal taxa = 0.37M/100;     

            decimal resultado = (saldo * taxa * totalMeses) + saldo;

            for (int i = 0; i < totalMeses; i++)
            {
                saldo += (saldo * taxa);
            }

            MessageBox.Show($"{nome} O saldo corrigido para {previsaoSaque} será de: {saldo.ToString("C")}");
        }
    }
}
