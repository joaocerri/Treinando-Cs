namespace ex4
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnLimpar;
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDivisao = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbSubtracao = new System.Windows.Forms.RadioButton();
            this.rbAdicao = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(17, 276);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(220, 57);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calculate";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDivisao);
            this.groupBox1.Controls.Add(this.rbMultiplicacao);
            this.groupBox1.Controls.Add(this.rbSubtracao);
            this.groupBox1.Controls.Add(this.rbAdicao);
            this.groupBox1.Location = new System.Drawing.Point(339, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rbDivisao
            // 
            this.rbDivisao.AutoSize = true;
            this.rbDivisao.Location = new System.Drawing.Point(46, 165);
            this.rbDivisao.Name = "rbDivisao";
            this.rbDivisao.Size = new System.Drawing.Size(74, 20);
            this.rbDivisao.TabIndex = 3;
            this.rbDivisao.TabStop = true;
            this.rbDivisao.Text = "Divisão";
            this.rbDivisao.UseVisualStyleBackColor = true;
            this.rbDivisao.CheckedChanged += new System.EventHandler(this.rbDivisao_CheckedChanged);
            // 
            // rbMultiplicacao
            // 
            this.rbMultiplicacao.AutoSize = true;
            this.rbMultiplicacao.Location = new System.Drawing.Point(46, 126);
            this.rbMultiplicacao.Name = "rbMultiplicacao";
            this.rbMultiplicacao.Size = new System.Drawing.Size(107, 20);
            this.rbMultiplicacao.TabIndex = 2;
            this.rbMultiplicacao.TabStop = true;
            this.rbMultiplicacao.Text = "Multiplicação";
            this.rbMultiplicacao.UseVisualStyleBackColor = true;
            this.rbMultiplicacao.CheckedChanged += new System.EventHandler(this.rbMultiplicacao_CheckedChanged);
            // 
            // rbSubtracao
            // 
            this.rbSubtracao.AutoSize = true;
            this.rbSubtracao.Location = new System.Drawing.Point(46, 85);
            this.rbSubtracao.Name = "rbSubtracao";
            this.rbSubtracao.Size = new System.Drawing.Size(90, 20);
            this.rbSubtracao.TabIndex = 1;
            this.rbSubtracao.TabStop = true;
            this.rbSubtracao.Text = "Subtração";
            this.rbSubtracao.UseVisualStyleBackColor = true;
            this.rbSubtracao.CheckedChanged += new System.EventHandler(this.rbSubtracao_CheckedChanged);
            // 
            // rbAdicao
            // 
            this.rbAdicao.AutoSize = true;
            this.rbAdicao.Location = new System.Drawing.Point(46, 46);
            this.rbAdicao.Name = "rbAdicao";
            this.rbAdicao.Size = new System.Drawing.Size(71, 20);
            this.rbAdicao.TabIndex = 0;
            this.rbAdicao.TabStop = true;
            this.rbAdicao.Text = "Adição";
            this.rbAdicao.UseVisualStyleBackColor = true;
            this.rbAdicao.CheckedChanged += new System.EventHandler(this.rbAdicao_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblOp);
            this.groupBox2.Location = new System.Drawing.Point(17, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(113, 33);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(197, 22);
            this.txtResultado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado da";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(6, 49);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(50, 16);
            this.lblOp.TabIndex = 3;
            this.lblOp.Text = "Adição";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNum2);
            this.groupBox3.Controls.Add(this.txtNum1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(17, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 138);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(113, 75);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(197, 22);
            this.txtNum2.TabIndex = 5;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(113, 29);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(197, 22);
            this.txtNum1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primeiro valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Segundo Valor:";
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            btnLimpar.Location = new System.Drawing.Point(260, 276);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new System.Drawing.Size(261, 57);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 354);
            this.Controls.Add(btnLimpar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMultiplicacao;
        private System.Windows.Forms.RadioButton rbSubtracao;
        private System.Windows.Forms.RadioButton rbAdicao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.RadioButton rbDivisao;
    }
}

