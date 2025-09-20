namespace ex1
{
    partial class FrmMain
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblCliques = new System.Windows.Forms.Label();
            this.btnClique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Blue;
            this.lblMensagem.Location = new System.Drawing.Point(10, 8);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(122, 23);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Total Clicks: ";
            // 
            // lblCliques
            // 
            this.lblCliques.AutoSize = true;
            this.lblCliques.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliques.ForeColor = System.Drawing.Color.Red;
            this.lblCliques.Location = new System.Drawing.Point(156, 9);
            this.lblCliques.Name = "lblCliques";
            this.lblCliques.Size = new System.Drawing.Size(21, 24);
            this.lblCliques.TabIndex = 1;
            this.lblCliques.Text = "0";
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClique.Location = new System.Drawing.Point(45, 64);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(140, 40);
            this.btnClique.TabIndex = 2;
            this.btnClique.Text = "Press Me!!";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 118);
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.lblCliques);
            this.Controls.Add(this.lblMensagem);
            this.Name = "FrmMain";
            this.Text = "Clicks";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblCliques;
        private System.Windows.Forms.Button btnClique;
    }
}

