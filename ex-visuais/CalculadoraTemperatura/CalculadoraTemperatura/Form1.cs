using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTemperatura
{
    public partial class Form1 : Form
    {
        double temp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "0.0";
            txt2.Text = "0.0";
            rdb1.Checked = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt1.Text = "0.0";
            txt2.Text = "0.0";
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Celsius";
            lbl2.Text = "Fahrenheit";
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Fahrenheit";
            lbl2.Text = "Celsius";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            temp = double.Parse(txt1.Text);
            if (rdb1.Checked)
            {
                temp = (9 * temp + 160) / 5;
                txt2.Text = temp.ToString();
            }
            else if (rdb2.Checked) {
                temp = (5 * temp - 160) / 9;
                txt2.Text = temp.ToString();
            }
        }
    }
}
