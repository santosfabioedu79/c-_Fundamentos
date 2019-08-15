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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int valorInteiro;
            decimal valorDecimal;
            DateTime data;

            valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            valorInteiro = int.Parse(txtValorInteiro.Text);

            valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);
            data = Convert.ToDateTime(txtData.Text);
        }


        private void BtnSomar1_Click(object sender, EventArgs e)
        {
            int inteiro = Convert.ToInt32(txtValorInteiro.Text);
            decimal valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);

            decimal resultado;
            resultado = inteiro + valorDecimal;

            MessageBox.Show($"O Resultado da soma é: {resultado}");
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            int inteiro = Convert.ToInt32(txtValorInteiro.Text);
            decimal valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);

            decimal resultado;
            resultado = inteiro - valorDecimal;

            MessageBox.Show($"O Resultado da subtração é: {resultado}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnFormula_Click(object sender, EventArgs e)
        {
            //Dividir valor inteiro com o valor decimal
            //Multiplicar o reaultado por 1,5 e exbir
            //e Exibir uma mensagem de Alerta

            int inteiro = Convert.ToInt32(txtValorInteiro.Text);
            decimal valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);

            decimal multiplicar = 1.5M;
            decimal resultado;
            resultado = ((inteiro/valorDecimal)*multiplicar);

            MessageBox.Show($"O Resultado da mutiplicação é: {resultado}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
