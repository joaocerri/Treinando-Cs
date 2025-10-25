using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class Form1 : Form
    {
        bool vezDoX;
        int jogadas;
        public Form1()
        {
            InitializeComponent();
            vezDoX = true;
            jogadas = 0;
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            lblX.Text = "0";
            lblO.Text = "0";
            lblEmpate.Text = "0";
            LimparTabuleiro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblX.Text = "0";
            lblO.Text = "0";
            lblEmpate.Text = "0";
        }

        public void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "")
                return;

            btn.Text = vezDoX ? "X" : "O";
            jogadas++;

            if (VerificarVencedor())
            {
                if (vezDoX)
                    lblX.Text = (int.Parse(lblX.Text) + 1).ToString();

                else
                    lblO.Text = (int.Parse(lblO.Text) + 1).ToString();

                txtVencedor.Text = vezDoX ? "X VENCEU!!!" : "O VENCEU!!!";
                MessageBox.Show("O vencedor é: " + (vezDoX ? "X" : "O"));
                LimparTabuleiro();
                jogadas = 0;
            }


            else if (jogadas == 9)
            {     
                lblEmpate.Text = (int.Parse(lblEmpate.Text) + 1).ToString();
                MessageBox.Show("EMPATE!!!");
                txtVencedor.Text = "EMPATE";
                LimparTabuleiro();
            }
            else
                vezDoX = !vezDoX;
            lblStatus.Text = vezDoX ? "Vez do:  X" : "Vez do:  O";
        }
        public bool VerificarVencedor() 
        {
            string[,] matriz = new string[3, 3]
            {
                 {btn1.Text, btn2.Text, btn3.Text},
                 {btn4.Text, btn5.Text, btn6.Text},
                 {btn7.Text, btn8.Text, btn9.Text}
            };
            for(int i = 0; i < 3; i++)
            {
                if (matriz[i, 0] != "" && matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2]) 
                {
                    if (i == 0)
                        btn1.BackColor = btn2.BackColor = btn3.BackColor = Color.LightGreen;

                    else if (i == 1)
                        btn4.BackColor = btn5.BackColor = btn6.BackColor = Color.LightGreen;

                    else
                        btn7.BackColor = btn8.BackColor = btn9.BackColor = Color.LightGreen;
                    return true;
                }
                    
              
                if (matriz[0, i] != "" && matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i])
                {
                    if (i == 0)
                        btn1.BackColor = btn4.BackColor = btn7.BackColor = Color.LightGreen;

                    else if (i == 1)
                        btn2.BackColor = btn5.BackColor = btn8.BackColor = Color.LightGreen;

                    else
                        btn3.BackColor = btn6.BackColor = btn9.BackColor = Color.LightGreen;
                    return true;
                }    
                    

                /*if (matriz[i, 0] != "" && matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2])
                    return true;
                if (matriz[0, i] != "" && matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i])
                    return true;*/
            }
            if (matriz[0, 0] != "" && matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2])
            {
                btn1.BackColor = btn5.BackColor = btn9.BackColor = Color.LightGreen;
                return true;
            }
            if (matriz[0, 2] != "" && matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
            {
                btn3.BackColor = btn5.BackColor = btn7.BackColor = Color.LightGreen;
                return true;
            }

            return false;
        }

        public void LimparTabuleiro()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            txtVencedor.Text = "";
            btn1.BackColor = btn2.BackColor = btn3.BackColor = btn4.BackColor = btn5.BackColor = btn6.BackColor = btn7.BackColor = btn8.BackColor = btn9.BackColor = SystemColors.Control;

        }
    }
}
