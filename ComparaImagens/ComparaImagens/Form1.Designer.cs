using System;

namespace ImageComparison
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnklbImagem1 = new System.Windows.Forms.LinkLabel();
            this.lnklbImagem2 = new System.Windows.Forms.LinkLabel();
            this.btnCompararImagens = new System.Windows.Forms.Button();
            this.pgBar1 = new System.Windows.Forms.ProgressBar();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.ofd2 = new System.Windows.Forms.OpenFileDialog();
            this.picImagem1 = new System.Windows.Forms.PictureBox();
            this.picImagem2 = new System.Windows.Forms.PictureBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lnklbImagem1
            // 
            this.lnklbImagem1.AutoSize = true;
            this.lnklbImagem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbImagem1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnklbImagem1.Location = new System.Drawing.Point(39, 25);
            this.lnklbImagem1.Name = "lnklbImagem1";
            this.lnklbImagem1.Size = new System.Drawing.Size(226, 21);
            this.lnklbImagem1.TabIndex = 0;
            this.lnklbImagem1.TabStop = true;
            this.lnklbImagem1.Text = "Selecionar Primeira Imagem";
            this.lnklbImagem1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbImagem1_LinkClicked);
            // 
            // lnklbImagem2
            // 
            this.lnklbImagem2.AutoSize = true;
            this.lnklbImagem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbImagem2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnklbImagem2.Location = new System.Drawing.Point(356, 25);
            this.lnklbImagem2.Name = "lnklbImagem2";
            this.lnklbImagem2.Size = new System.Drawing.Size(228, 21);
            this.lnklbImagem2.TabIndex = 1;
            this.lnklbImagem2.TabStop = true;
            this.lnklbImagem2.Text = "Selecionar Segunda Imagem";
            this.lnklbImagem2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbImagem2_LinkClicked);
            // 
            // btnCompararImagens
            // 
            this.btnCompararImagens.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCompararImagens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompararImagens.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnCompararImagens.Location = new System.Drawing.Point(43, 363);
            this.btnCompararImagens.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCompararImagens.Name = "btnCompararImagens";
            this.btnCompararImagens.Size = new System.Drawing.Size(293, 41);
            this.btnCompararImagens.TabIndex = 2;
            this.btnCompararImagens.Text = "Comparar Imagens";
            this.btnCompararImagens.UseVisualStyleBackColor = false;
            this.btnCompararImagens.Click += new System.EventHandler(this.btnCompararImagens_Click);
            // 
            // pgBar1
            // 
            this.pgBar1.Location = new System.Drawing.Point(43, 318);
            this.pgBar1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pgBar1.Name = "pgBar1";
            this.pgBar1.Size = new System.Drawing.Size(615, 35);
            this.pgBar1.TabIndex = 3;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // ofd2
            // 
            this.ofd2.FileName = "openFileDialog2";
            // 
            // picImagem1
            // 
            this.picImagem1.Location = new System.Drawing.Point(43, 51);
            this.picImagem1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picImagem1.Name = "picImagem1";
            this.picImagem1.Size = new System.Drawing.Size(293, 248);
            this.picImagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem1.TabIndex = 4;
            this.picImagem1.TabStop = false;
            // 
            // picImagem2
            // 
            this.picImagem2.Location = new System.Drawing.Point(360, 51);
            this.picImagem2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.picImagem2.Name = "picImagem2";
            this.picImagem2.Size = new System.Drawing.Size(293, 248);
            this.picImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem2.TabIndex = 4;
            this.picImagem2.TabStop = false;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEncerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnEncerrar.Location = new System.Drawing.Point(529, 363);
            this.btnEncerrar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(129, 41);
            this.btnEncerrar.TabIndex = 2;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnLimpar.Location = new System.Drawing.Point(360, 363);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 41);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(679, 415);
            this.Controls.Add(this.picImagem2);
            this.Controls.Add(this.picImagem1);
            this.Controls.Add(this.pgBar1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnCompararImagens);
            this.Controls.Add(this.lnklbImagem2);
            this.Controls.Add(this.lnklbImagem1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparando Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnklbImagem1;
        private System.Windows.Forms.LinkLabel lnklbImagem2;
        private System.Windows.Forms.Button btnCompararImagens;
        private System.Windows.Forms.ProgressBar pgBar1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.OpenFileDialog ofd2;
        private System.Windows.Forms.PictureBox picImagem1;
        private System.Windows.Forms.PictureBox picImagem2;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

