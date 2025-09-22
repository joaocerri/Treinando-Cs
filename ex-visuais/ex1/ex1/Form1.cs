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
        int contador;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            contador++;
            lblCliques.Text = contador.ToString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            contador = 0;
        }
    }
}
