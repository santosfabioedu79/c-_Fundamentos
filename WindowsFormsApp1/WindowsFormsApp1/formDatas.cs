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
    public partial class formDatas : Form
    {
        public formDatas()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(txtInformData.Text);
            var dataMes = Convert.ToDateTime(txtInformData.Text);
            int qtdeDias = Convert.ToInt32(txtQdteDias.Text);
            int qtdeMeses = Convert.ToInt32(txtQdteMeses.Text);
            data = data.AddDays(qtdeDias);

            lblQdteDias.Text = data.ToString("dddd - dd/MM/yyyy");

            //Exemplo 2
            //lblQdteMeses.Text = Convert.ToDateTime(txtInformData.Text).AddMonths(Convert.ToInt32(txtQdteMeses)).ToString("dd/MM/yyyy");

            dataMes = dataMes.AddMonths(qtdeMeses);
            lblQdteMeses.Text = dataMes.ToString("dd/MM/yyyy");

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtInformData.Text = string.Empty;
            txtQdteDias.Text = string.Empty;
            txtQdteMeses.Text = string.Empty;
            lblQdteDias.Text = string.Empty;
            lblQdteMeses.Text = string.Empty;
        }
    }
}
