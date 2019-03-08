namespace MDIForms
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAbrirChild1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrirChild2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbrirChild1,
            this.mnuAbrirChild2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAbrirChild1
            // 
            this.mnuAbrirChild1.Name = "mnuAbrirChild1";
            this.mnuAbrirChild1.Size = new System.Drawing.Size(82, 20);
            this.mnuAbrirChild1.Text = "Abrir Child1";
            this.mnuAbrirChild1.Click += new System.EventHandler(this.mnuAbrirChild1_Click);
            // 
            // mnuAbrirChild2
            // 
            this.mnuAbrirChild2.Name = "mnuAbrirChild2";
            this.mnuAbrirChild2.Size = new System.Drawing.Size(82, 20);
            this.mnuAbrirChild2.Text = "Abrir Child2";
            this.mnuAbrirChild2.Click += new System.EventHandler(this.mnuAbrirChild2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "MDIParent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrirChild1;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrirChild2;
    }
}

