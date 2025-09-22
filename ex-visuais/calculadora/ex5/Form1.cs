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
    public partial class Calculadora : Form
    {
        double exibicao = 0;
        double resultado = 0;
        int operacao = 0;
        double num = 0;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
           txtExibicao.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtExibicao.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtExibicao.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtExibicao.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtExibicao.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtExibicao.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtExibicao.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtExibicao.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtExibicao.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtExibicao.Text += 6;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtExibicao.Clear();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = 1;
            resultado = double.Parse(txtExibicao.Text);
            txtExibicao.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtExibicao.Text);
            if (operacao == 1)
            {
                resultado += num;
                txtExibicao.Text = resultado.ToString();
            }
            else if (operacao == 2)
            {
                resultado -= num;
                txtExibicao.Text = resultado.ToString();
            }
            else if (operacao == 3) 
            {
                resultado = resultado*num;
                txtExibicao.Text = resultado.ToString();
            }
            else if (operacao == 4)
            {
                resultado = resultado / num;
                txtExibicao.Text = resultado.ToString();
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operacao = 2;
            resultado = double.Parse(txtExibicao.Text);
            txtExibicao.Clear();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacao = 3;
            resultado = double.Parse(txtExibicao.Text);
            txtExibicao.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacao = 4;
            resultado = double.Parse(txtExibicao.Text);
            txtExibicao.Clear();
        }
    }
}
