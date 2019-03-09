namespace ColorTrackBars
{
    partial class frmColors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColors));
            this.pctNormal = new System.Windows.Forms.PictureBox();
            this.pctInverso = new System.Windows.Forms.PictureBox();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblInverso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInverso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pctNormal
            // 
            this.pctNormal.Location = new System.Drawing.Point(13, 13);
            this.pctNormal.Name = "pctNormal";
            this.pctNormal.Size = new System.Drawing.Size(259, 93);
            this.pctNormal.TabIndex = 0;
            this.pctNormal.TabStop = false;
            // 
            // pctInverso
            // 
            this.pctInverso.Location = new System.Drawing.Point(272, 13);
            this.pctInverso.Name = "pctInverso";
            this.pctInverso.Size = new System.Drawing.Size(259, 93);
            this.pctInverso.TabIndex = 1;
            this.pctInverso.TabStop = false;
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(13, 168);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(439, 45);
            this.trbRed.TabIndex = 2;
            this.trbRed.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(13, 219);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(439, 45);
            this.trbGreen.TabIndex = 3;
            this.trbGreen.Scroll += new System.EventHandler(this.trbGreen_Scroll);
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(13, 270);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(439, 45);
            this.trbBlue.TabIndex = 4;
            this.trbBlue.Scroll += new System.EventHandler(this.trbBlue_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(469, 182);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(31, 16);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = "R:0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(468, 233);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(31, 16);
            this.lblGreen.TabIndex = 6;
            this.lblGreen.Text = "G:0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(468, 284);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(30, 16);
            this.lblBlue.TabIndex = 7;
            this.lblBlue.Text = "B:0";
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.Location = new System.Drawing.Point(12, 109);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(94, 16);
            this.lblNormal.TabIndex = 8;
            this.lblNormal.Text = "(R:0 G:0 B:0)";
            this.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInverso
            // 
            this.lblInverso.AutoSize = true;
            this.lblInverso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInverso.Location = new System.Drawing.Point(269, 109);
            this.lblInverso.Name = "lblInverso";
            this.lblInverso.Size = new System.Drawing.Size(142, 16);
            this.lblInverso.TabIndex = 9;
            this.lblInverso.Text = "(R:255 G:255 B:255)";
            this.lblInverso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 332);
            this.Controls.Add(this.lblInverso);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.trbGreen);
            this.Controls.Add(this.trbRed);
            this.Controls.Add(this.pctInverso);
            this.Controls.Add(this.pctNormal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmColors";
            this.Text = "Cores Opostas";
            this.Load += new System.EventHandler(this.frmColors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInverso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctNormal;
        private System.Windows.Forms.PictureBox pctInverso;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblInverso;
    }
}

