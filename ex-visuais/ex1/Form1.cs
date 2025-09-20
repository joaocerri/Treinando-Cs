using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class FrmMain : Form
    {
        int counter;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            counter = 0;

           lblCliques.Text = counter.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
        }

    }
}
