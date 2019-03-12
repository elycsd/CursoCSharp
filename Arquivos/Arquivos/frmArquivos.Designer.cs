namespace Arquivos
{
    partial class frmArquivos
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
            this.lsbTexto = new System.Windows.Forms.ListBox();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbTexto
            // 
            this.lsbTexto.FormattingEnabled = true;
            this.lsbTexto.Location = new System.Drawing.Point(13, 13);
            this.lsbTexto.Name = "lsbTexto";
            this.lsbTexto.Size = new System.Drawing.Size(318, 225);
            this.lsbTexto.TabIndex = 0;
            // 
            // txtLinha
            // 
            this.txtLinha.Location = new System.Drawing.Point(13, 248);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(318, 20);
            this.txtLinha.TabIndex = 0;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(13, 275);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(138, 46);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.TextChanged += new System.EventHandler(this.btnGravar_TextChanged);
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(193, 275);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(138, 46);
            this.btnLer.TabIndex = 3;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // frmArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 333);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtLinha);
            this.Controls.Add(this.lsbTexto);
            this.Name = "frmArquivos";
            this.Text = "Arquivos";
            this.Load += new System.EventHandler(this.frmArquivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbTexto;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLer;
    }
}

