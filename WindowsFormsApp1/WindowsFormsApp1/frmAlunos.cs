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
    public partial class frmAlunos : Form
    {
        string[] alunos = new string[8];
        public frmAlunos()
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

            lstAluno.DataSource = alunos;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string[] listraFiltrada = new string[0];
            int i = 0;

            foreach (var aluno in alunos)
            {
                if (aluno.ToLower().Contains(txtNomeFiltro.Text.ToLower()))
                {
                    Array.Resize(ref listraFiltrada, listraFiltrada.Length + 1);
                    listraFiltrada[i] = aluno;
                    i++;
                }
            }

            lstAluno.DataSource = listraFiltrada;
        }
    }
}
