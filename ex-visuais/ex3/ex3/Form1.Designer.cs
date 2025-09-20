namespace ex3
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
            this.cbxC = new System.Windows.Forms.CheckBox();
            this.cbxCSharp = new System.Windows.Forms.CheckBox();
            this.cbxJava = new System.Windows.Forms.CheckBox();
            this.cbxJavaScript = new System.Windows.Forms.CheckBox();
            this.cbxOutras = new System.Windows.Forms.CheckBox();
            this.lblOutras = new System.Windows.Forms.Label();
            this.txtOutras = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxC
            // 
            this.cbxC.AutoSize = true;
            this.cbxC.Location = new System.Drawing.Point(145, 21);
            this.cbxC.Name = "cbxC";
            this.cbxC.Size = new System.Drawing.Size(38, 20);
            this.cbxC.TabIndex = 0;
            this.cbxC.Text = "C";
            this.cbxC.UseVisualStyleBackColor = true;
            // 
            // cbxCSharp
            // 
            this.cbxCSharp.AutoSize = true;
            this.cbxCSharp.Location = new System.Drawing.Point(6, 21);
            this.cbxCSharp.Name = "cbxCSharp";
            this.cbxCSharp.Size = new System.Drawing.Size(45, 20);
            this.cbxCSharp.TabIndex = 1;
            this.cbxCSharp.Text = "C#";
            this.cbxCSharp.UseVisualStyleBackColor = true;
            // 
            // cbxJava
            // 
            this.cbxJava.AutoSize = true;
            this.cbxJava.Location = new System.Drawing.Point(66, 39);
            this.cbxJava.Name = "cbxJava";
            this.cbxJava.Size = new System.Drawing.Size(59, 20);
            this.cbxJava.TabIndex = 2;
            this.cbxJava.Text = "Java";
            this.cbxJava.UseVisualStyleBackColor = true;
            // 
            // cbxJavaScript
            // 
            this.cbxJavaScript.AutoSize = true;
            this.cbxJavaScript.Location = new System.Drawing.Point(6, 74);
            this.cbxJavaScript.Name = "cbxJavaScript";
            this.cbxJavaScript.Size = new System.Drawing.Size(93, 20);
            this.cbxJavaScript.TabIndex = 3;
            this.cbxJavaScript.Text = "JavaScript";
            this.cbxJavaScript.UseVisualStyleBackColor = true;
            // 
            // cbxOutras
            // 
            this.cbxOutras.AutoSize = true;
            this.cbxOutras.Location = new System.Drawing.Point(132, 74);
            this.cbxOutras.Name = "cbxOutras";
            this.cbxOutras.Size = new System.Drawing.Size(68, 20);
            this.cbxOutras.TabIndex = 4;
            this.cbxOutras.Text = "Outras";
            this.cbxOutras.UseVisualStyleBackColor = true;
            this.cbxOutras.CheckedChanged += new System.EventHandler(this.cbxOutras_CheckedChanged);
            // 
            // lblOutras
            // 
            this.lblOutras.AutoSize = true;
            this.lblOutras.Location = new System.Drawing.Point(24, 130);
            this.lblOutras.Name = "lblOutras";
            this.lblOutras.Size = new System.Drawing.Size(172, 16);
            this.lblOutras.TabIndex = 5;
            this.lblOutras.Text = "Especifique as Linguagens:";
            // 
            // txtOutras
            // 
            this.txtOutras.Location = new System.Drawing.Point(14, 158);
            this.txtOutras.Name = "txtOutras";
            this.txtOutras.Size = new System.Drawing.Size(207, 22);
            this.txtOutras.TabIndex = 6;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(27, 191);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(160, 38);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxOutras);
            this.groupBox1.Controls.Add(this.cbxJavaScript);
            this.groupBox1.Controls.Add(this.cbxCSharp);
            this.groupBox1.Controls.Add(this.cbxJava);
            this.groupBox1.Controls.Add(this.cbxC);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 254);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtOutras);
            this.Controls.Add(this.lblOutras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxC;
        private System.Windows.Forms.CheckBox cbxCSharp;
        private System.Windows.Forms.CheckBox cbxJava;
        private System.Windows.Forms.CheckBox cbxJavaScript;
        private System.Windows.Forms.CheckBox cbxOutras;
        private System.Windows.Forms.Label lblOutras;
        private System.Windows.Forms.TextBox txtOutras;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

