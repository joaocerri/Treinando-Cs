using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{
    //https://www.youtube.com/watch?v=nRXGFfHBFBA
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            lblX.Text = "0";
            lblX.Text = "0";
            lblEmpate.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
