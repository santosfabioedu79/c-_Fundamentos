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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Exibindo janela de mensagem na tela
            MessageBox.Show("O PALMEIRAS NÃO TEM MUNDIAL");   
                }

        private void Button2_Click(object sender, EventArgs e)
        {
            string nome = "Fábio", sobreNome = "Santos";
            //string nomeCompleto = nome + " " + sobreNome;
            string nomeCompleto = $"nome: {nome} Sobrenome: {sobreNome}";

            MessageBox.Show(nomeCompleto);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int numeroInteiro;
            string tipoTexto;
            decimal numeroDecimal;
            double numeroDecimalMenor;
            short numeroInteiroMenor;
            byte numeroInteiromenor;
            DateTime dataHora;
            bool verdadeiroOuFalso;
        }

        private void BtnForm2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void BtnForm3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnCalcPoupanca_Click(object sender, EventArgs e)
        {
            new frmPoupanca().Show();
        }

        private void Button3_Click_2(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new formDatas().Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            new frmEnum().Show();
        }

        private void BtnFrmArray_Click(object sender, EventArgs e)
        {
            new FrmArray().Show();
        }

        private void BtnArray2_Click(object sender, EventArgs e)
        {
            new frmAlunos().Show();
        }
    }
}
