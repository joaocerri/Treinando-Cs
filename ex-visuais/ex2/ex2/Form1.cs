using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            int dividend = int.Parse(txtDividend.Text);
            int divider = int.Parse(txtDivider.Text);
            
            int quotient = dividend / divider;
            int remainder = dividend % divider;

            txtQuotient.Text = quotient.ToString();
            txtRemainder.Text = remainder.ToString();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtDividend.Clear();
            txtDivider.Clear();
            txtQuotient.Clear();
            txtRemainder.Clear();
        }


    }
}
