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
    public partial class FrmArray : Form
    {
        public FrmArray()
        {
            InitializeComponent();

            alunos[0] = "Rossi";
            alunos[1] = "Patrick";
            alunos[2] = "Vivian";
            alunos[3] = "Erick";
            alunos[4] = "Rogerio";
            alunos[5] = "Victor";
            alunos[6] = "Fabio";
            alunos[7] = "Genari";
        }

        string[] alunos = new string[8];

        private void BtnOK_Click(object sender, EventArgs e)
        {
            lblTamanhoArray.Text = "";
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] == null)
                {
                    alunos[i] = txtNome.Text;
                    txtNome.Text = string.Empty;
                    lblTamanhoArray.Text += $"{txtNome.Text} \r\n";
                    break;
                }
            }
            
            
        

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            #region Primeiro Item
            if (alunos.Length >= 1)
            {
                lblPrimeiroItem.Text = alunos[0];
            }
            #endregion

            #region Nome Letra R
            foreach (var aluno in alunos)
            {
                if (aluno.StartsWith("R"))
                {
                    lblNomeLetraR.Text += $"{aluno}, ";
                }
            }
            #endregion

            #region Desafio 1
            //Criar um array com alunos
            //Cujo o nome com a letra R



            #endregion
        }
    }
}
