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
    public partial class frmEnum : Form
    {
        public frmEnum()
        {
            InitializeComponent();
        }

        enum TimeEnum
        {
            Corinthians,
            Santos,
            SaoPaulo,
            Palmeiras,
            Portuguesa,
        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.ToLower(); // converte o dado entrada para minúsculo
            nome = nome.Trim(); //retira os espaços das extremidades

            TimeEnum time;

            if (nome == "fabio" || nome == "kleber" || nome == "rossi" || nome == "vivian")
            {
                time = TimeEnum.Corinthians;
            }
            else if (nome == "patrick" || nome == "erick")
            {
                time = TimeEnum.Palmeiras;
            }
            else if (nome == "victor" || nome == "genari")
            {
                time = TimeEnum.SaoPaulo;
            }
            else if (nome == "rogerio")
            {
                time = TimeEnum.Santos;
            }
            else
            {
                time = TimeEnum.Portuguesa;
            }

            switch (time)
            {
                case TimeEnum.Corinthians:
                    txtNome.Text = $"{nome} seu time de é campeões dos campeões";
                    break;
                case TimeEnum.Santos:
                    txtNome.Text = $"{nome} era uma vez o Pelé";
                    break;
                case TimeEnum.SaoPaulo:
                    txtNome.Text = $"{nome} seu time é de baitola";
                    break;
                case TimeEnum.Palmeiras:
                    txtNome.Text = $"{nome} seu time é de porquinhas";
                    break;
                case TimeEnum.Portuguesa:
                    txtNome.Text = $"{nome} seu time é de lusitano";
                    break;
                default:
                    txtNome.Text = $"{nome} você não tem time do coração";
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            
        }
    }
}
