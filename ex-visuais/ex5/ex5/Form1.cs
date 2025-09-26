using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5
{
    public partial class Form1 : Form
    {
        double capital, juros, periodos, montante, valorJuros;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeriodos.Clear();
            txtJuros.Clear();
            txtCapital.Clear();
            txtMontante.Clear();
            txtTipoJuros.Clear();
            txtValorJuros.Clear();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbSimples.Checked = true;
        }

        private void rdbCompostos_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoJuros.Text = "Composto";
        }

        private void rdbSimples_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoJuros.Text = "Simples";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           capital = Convert.ToDouble(txtCapital.Text);
           juros = Convert.ToDouble(txtJuros.Text) / 100;
           periodos = Convert.ToDouble(txtPeriodos.Text);

           if(rdbSimples.Checked)
           {
               montante = capital * (1 + juros * periodos);
               valorJuros = montante - capital;
           }
           else
           {
               montante = capital * Math.Pow((1 + juros), periodos);
               valorJuros = montante - capital;
            }
           txtValorJuros.Text = $"{valorJuros:C2}";
           txtMontante.Text = $" {montante:C2}";
        }
    }
}
