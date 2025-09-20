using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOutras.Hide();
            txtOutras.Hide();
        }

        private void cbxOutras_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxOutras.Checked)
            {
                lblOutras.Show();
                txtOutras.Show();
            }
            else
            {
                lblOutras.Hide();
                txtOutras.Hide();
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string LinguagensSelecionadas = "";

            if(cbxCSharp.Checked)
            {
                LinguagensSelecionadas += cbxCSharp.Text + "; ";
            }
            if (cbxC.Checked)
            {
                LinguagensSelecionadas += cbxC.Text + "; ";
            }
            if (cbxJava.Checked)
            {
                LinguagensSelecionadas += cbxJava.Text + "; ";
            }
            if (cbxJavaScript.Checked)
            {
                LinguagensSelecionadas += cbxJavaScript.Text + "; ";
            }
            if (cbxOutras.Checked)
            {
                LinguagensSelecionadas += txtOutras.Text + "; ";
            }
            MessageBox.Show("Linguagens selecionadas: " + LinguagensSelecionadas);
        }
    }
}
