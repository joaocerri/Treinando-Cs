namespace ex2
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
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblDividend = new System.Windows.Forms.Label();
            this.lblQuotient = new System.Windows.Forms.Label();
            this.lblRemainder = new System.Windows.Forms.Label();
            this.txtDividend = new System.Windows.Forms.TextBox();
            this.txtDivider = new System.Windows.Forms.TextBox();
            this.txtQuotient = new System.Windows.Forms.TextBox();
            this.txtRemainder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(152, 145);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(122, 32);
            this.btnClean.TabIndex = 0;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 145);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 32);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDivider
            // 
            this.lblDivider.AutoSize = true;
            this.lblDivider.Location = new System.Drawing.Point(24, 49);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(50, 16);
            this.lblDivider.TabIndex = 2;
            this.lblDivider.Text = "Divider";
            // 
            // lblDividend
            // 
            this.lblDividend.AutoSize = true;
            this.lblDividend.Location = new System.Drawing.Point(24, 24);
            this.lblDividend.Name = "lblDividend";
            this.lblDividend.Size = new System.Drawing.Size(61, 16);
            this.lblDividend.TabIndex = 3;
            this.lblDividend.Text = "Dividend";
            // 
            // lblQuotient
            // 
            this.lblQuotient.AutoSize = true;
            this.lblQuotient.Location = new System.Drawing.Point(24, 77);
            this.lblQuotient.Name = "lblQuotient";
            this.lblQuotient.Size = new System.Drawing.Size(56, 16);
            this.lblQuotient.TabIndex = 4;
            this.lblQuotient.Text = "Quotient";
            // 
            // lblRemainder
            // 
            this.lblRemainder.AutoSize = true;
            this.lblRemainder.Location = new System.Drawing.Point(24, 105);
            this.lblRemainder.Name = "lblRemainder";
            this.lblRemainder.Size = new System.Drawing.Size(74, 16);
            this.lblRemainder.TabIndex = 5;
            this.lblRemainder.Text = "Remainder";
            // 
            // txtDividend
            // 
            this.txtDividend.Location = new System.Drawing.Point(136, 21);
            this.txtDividend.Name = "txtDividend";
            this.txtDividend.Size = new System.Drawing.Size(138, 22);
            this.txtDividend.TabIndex = 6;
            // 
            // txtDivider
            // 
            this.txtDivider.Location = new System.Drawing.Point(136, 49);
            this.txtDivider.Name = "txtDivider";
            this.txtDivider.Size = new System.Drawing.Size(138, 22);
            this.txtDivider.TabIndex = 7;
            // 
            // txtQuotient
            // 
            this.txtQuotient.Enabled = false;
            this.txtQuotient.Location = new System.Drawing.Point(136, 77);
            this.txtQuotient.Name = "txtQuotient";
            this.txtQuotient.Size = new System.Drawing.Size(138, 22);
            this.txtQuotient.TabIndex = 8;
            // 
            // txtRemainder
            // 
            this.txtRemainder.Enabled = false;
            this.txtRemainder.Location = new System.Drawing.Point(136, 105);
            this.txtRemainder.Name = "txtRemainder";
            this.txtRemainder.Size = new System.Drawing.Size(138, 22);
            this.txtRemainder.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 189);
            this.Controls.Add(this.txtRemainder);
            this.Controls.Add(this.txtQuotient);
            this.Controls.Add(this.txtDivider);
            this.Controls.Add(this.txtDividend);
            this.Controls.Add(this.lblRemainder);
            this.Controls.Add(this.lblQuotient);
            this.Controls.Add(this.lblDividend);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClean);
            this.Location = new System.Drawing.Point(12, 133);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblDividend;
        private System.Windows.Forms.Label lblQuotient;
        private System.Windows.Forms.Label lblRemainder;
        private System.Windows.Forms.TextBox txtDividend;
        private System.Windows.Forms.TextBox txtDivider;
        private System.Windows.Forms.TextBox txtQuotient;
        private System.Windows.Forms.TextBox txtRemainder;
    }
}

