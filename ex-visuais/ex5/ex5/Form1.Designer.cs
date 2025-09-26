namespace ex5
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
            this.rdbSimples = new System.Windows.Forms.RadioButton();
            this.rdbCompostos = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Botão = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoJuros = new System.Windows.Forms.TextBox();
            this.txtValorJuros = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Botão.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbSimples
            // 
            this.rdbSimples.AutoSize = true;
            this.rdbSimples.Location = new System.Drawing.Point(12, 21);
            this.rdbSimples.Name = "rdbSimples";
            this.rdbSimples.Size = new System.Drawing.Size(113, 20);
            this.rdbSimples.TabIndex = 0;
            this.rdbSimples.TabStop = true;
            this.rdbSimples.Text = "Juros Simples";
            this.rdbSimples.UseVisualStyleBackColor = true;
            this.rdbSimples.CheckedChanged += new System.EventHandler(this.rdbSimples_CheckedChanged);
            // 
            // rdbCompostos
            // 
            this.rdbCompostos.AutoSize = true;
            this.rdbCompostos.Location = new System.Drawing.Point(12, 58);
            this.rdbCompostos.Name = "rdbCompostos";
            this.rdbCompostos.Size = new System.Drawing.Size(133, 20);
            this.rdbCompostos.TabIndex = 1;
            this.rdbCompostos.TabStop = true;
            this.rdbCompostos.Text = "Juros Compostos";
            this.rdbCompostos.UseVisualStyleBackColor = true;
            this.rdbCompostos.CheckedChanged += new System.EventHandler(this.rdbCompostos_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 60);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(133, 42);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 10);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 46);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPeriodos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCapital);
            this.groupBox1.Controls.Add(this.txtJuros);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 98);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor de Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de Periodos:";
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.Location = new System.Drawing.Point(178, 70);
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.Size = new System.Drawing.Size(84, 22);
            this.txtPeriodos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taxa de Juros (%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capital Inicial: ";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(178, 15);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(84, 22);
            this.txtCapital.TabIndex = 6;
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(178, 42);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(84, 22);
            this.txtJuros.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCompostos);
            this.groupBox2.Controls.Add(this.rdbSimples);
            this.groupBox2.Location = new System.Drawing.Point(286, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 98);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Juros";
            // 
            // Botão
            // 
            this.Botão.Controls.Add(this.btnLimpar);
            this.Botão.Controls.Add(this.btnCalcular);
            this.Botão.Location = new System.Drawing.Point(286, 133);
            this.Botão.Name = "Botão";
            this.Botão.Size = new System.Drawing.Size(158, 108);
            this.Botão.TabIndex = 14;
            this.Botão.TabStop = false;
            this.Botão.Text = " ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtMontante);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtTipoJuros);
            this.groupBox4.Controls.Add(this.txtValorJuros);
            this.groupBox4.Location = new System.Drawing.Point(12, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 98);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Montante: ";
            // 
            // txtMontante
            // 
            this.txtMontante.Enabled = false;
            this.txtMontante.Location = new System.Drawing.Point(119, 70);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(143, 22);
            this.txtMontante.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Juros: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tipo de Juros: ";
            // 
            // txtTipoJuros
            // 
            this.txtTipoJuros.Enabled = false;
            this.txtTipoJuros.Location = new System.Drawing.Point(119, 14);
            this.txtTipoJuros.Name = "txtTipoJuros";
            this.txtTipoJuros.Size = new System.Drawing.Size(143, 22);
            this.txtTipoJuros.TabIndex = 6;
            // 
            // txtValorJuros
            // 
            this.txtValorJuros.Enabled = false;
            this.txtValorJuros.Location = new System.Drawing.Point(119, 42);
            this.txtValorJuros.Name = "txtValorJuros";
            this.txtValorJuros.Size = new System.Drawing.Size(143, 22);
            this.txtValorJuros.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 253);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Botão);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Botão.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbSimples;
        private System.Windows.Forms.RadioButton rdbCompostos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeriodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Botão;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoJuros;
        private System.Windows.Forms.TextBox txtValorJuros;
    }
}

