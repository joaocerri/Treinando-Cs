using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(txtNum1.Text);
            double num2 = Double.Parse(txtNum2.Text);

            if(rbAdicao.Checked)
            {
                txtResultado.Text = (num1 + num2).ToString();
            }
            else if (rbSubtracao.Checked)
            {
                txtResultado.Text = (num1 - num2).ToString();
            }
            else if (rbMultiplicacao.Checked)
            {
                txtResultado.Text = (num1 * num2).ToString();
            }
            else if (rbDivisao.Checked)
            {
                txtResultado.Text = (num1 / num2).ToString();
            }
        }

        private void rbAdicao_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "Adição";
            txtResultado.Clear();
        }

        private void rbSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "Subtração";
            txtResultado.Clear();
        }

        private void rbMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "Multiplicação";
            txtResultado.Clear();
        }

        private void rbDivisao_CheckedChanged(object sender, EventArgs e)
        {
            lblOp.Text = "Divisão";
            txtResultado.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
        }
    }
}
