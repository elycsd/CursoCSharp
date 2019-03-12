namespace PastasEArquivos
{
    partial class frmConfig
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lsbDados = new System.Windows.Forms.ListBox();
            this.btnListarArquivos = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(114, 318);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(90, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(259, 30);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(102, 20);
            this.dtpData.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(13, 318);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(90, 23);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lsbDados
            // 
            this.lsbDados.FormattingEnabled = true;
            this.lsbDados.Location = new System.Drawing.Point(13, 61);
            this.lsbDados.Name = "lsbDados";
            this.lsbDados.Size = new System.Drawing.Size(393, 225);
            this.lsbDados.TabIndex = 4;
            // 
            // btnListarArquivos
            // 
            this.btnListarArquivos.Location = new System.Drawing.Point(316, 318);
            this.btnListarArquivos.Name = "btnListarArquivos";
            this.btnListarArquivos.Size = new System.Drawing.Size(90, 23);
            this.btnListarArquivos.TabIndex = 6;
            this.btnListarArquivos.Text = "Listar Arquivos";
            this.btnListarArquivos.UseVisualStyleBackColor = true;
            this.btnListarArquivos.Click += new System.EventHandler(this.btnListarArquivos_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(215, 318);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 23);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 353);
            this.Controls.Add(this.btnListarArquivos);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lsbDados);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnGravar);
            this.Name = "frmConfig";
            this.Text = "Arquivos e Pastas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ListBox lsbDados;
        private System.Windows.Forms.Button btnListarArquivos;
        private System.Windows.Forms.Button btnApagar;
    }
}

