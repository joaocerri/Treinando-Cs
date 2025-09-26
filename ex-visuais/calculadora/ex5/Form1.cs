using System;
using System.Data;
using System.Windows.Forms;

namespace ex5
{
    public partial class Calculadora : Form
    {
        string expressao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void AdicionarTexto(string texto)
        {
            expressao += texto;
            txtExibicao.Text = expressao;
        }

        private void btn0_Click(object sender, EventArgs e) => AdicionarTexto("0");
        private void btn1_Click(object sender, EventArgs e) => AdicionarTexto("1");
        private void btn2_Click(object sender, EventArgs e) => AdicionarTexto("2");
        private void btn3_Click(object sender, EventArgs e) => AdicionarTexto("3");
        private void btn4_Click(object sender, EventArgs e) => AdicionarTexto("4");
        private void btn5_Click(object sender, EventArgs e) => AdicionarTexto("5");
        private void btn6_Click(object sender, EventArgs e) => AdicionarTexto("6");
        private void btn7_Click(object sender, EventArgs e) => AdicionarTexto("7");
        private void btn8_Click(object sender, EventArgs e) => AdicionarTexto("8");
        private void btn9_Click(object sender, EventArgs e) => AdicionarTexto("9");

        private void btnSoma_Click(object sender, EventArgs e) => AdicionarTexto("+");
        private void btnSubtracao_Click(object sender, EventArgs e) => AdicionarTexto("-");
        private void btnMultiplicacao_Click(object sender, EventArgs e) => AdicionarTexto("*");
        private void btnDivisao_Click(object sender, EventArgs e) => AdicionarTexto("/");

        private void btnClean_Click(object sender, EventArgs e)
        {
            expressao = "";
            txtExibicao.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = new DataTable().Compute(expressao, null);
                txtExibicao.Text = resultado.ToString();
                expressao = resultado.ToString(); 
            }
            catch
            {
                txtExibicao.Text = "Erro";
                expressao = "";
            }
        }
    }
}
