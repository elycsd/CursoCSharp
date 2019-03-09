using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string nomeArquivo1, nomeArquivo2;
        Bitmap img1, img2;
        int contador1 = 0, contador2 = 0;
        bool flag = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            pgBar1.Visible = false;
            picImagem1.Visible = true;
            picImagem2.Visible = true;
        }

        private void lnklbImagem1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofd1.FileName = "";
            ofd1.Title = "Imagens"; 
            ofd1.Filter = "Todas Imagens|*.jpg; *.bmp; *.png";
            pgBar1.Value = 0;
            pgBar1.Visible = false;

            ofd1.ShowDialog(); 
            if (ofd1.FileName.ToString() != "")
            {
                nomeArquivo1 = ofd1.FileName.ToString();
                picImagem1.Image = new Bitmap(nomeArquivo1);
            }
        }

        private void lnklbImagem2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofd2.FileName = ""; 
            ofd2.Title = "Imagens"; 
            ofd2.Filter = "Todas Imagens|*.jpg; *.bmp; *.png";
           

            ofd2.ShowDialog();
            if (ofd2.FileName.ToString() != "")
            {
                nomeArquivo2 = ofd2.FileName.ToString();
                picImagem2.Image = new Bitmap(nomeArquivo2);
            }
        }

        private void btnCompararImagens_Click(object sender, EventArgs e)
        {
            pgBar1.Visible = true;
            btnLimpar.Enabled = true;

            string img1_ref, img2_ref;
            img1 = new Bitmap(nomeArquivo1);
            img2 = new Bitmap(nomeArquivo2);

            pgBar1.Maximum = img1.Width;
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        img1_ref = img1.GetPixel(i, j).ToString();
                        img2_ref = img2.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {
                            contador2++;
                            flag = false;
                            break;
                        }
                        contador1++;
                    }
                    pgBar1.Value++;
                }

                if (flag == false)
                {
                    MessageBox.Show("As imagens n�o s�o as mesmas, " + contador2 + " pixels diferentes foram encontrados");
                }
                else
                {
                    MessageBox.Show("As imagens s�o as mesmas, " + contador1 + " pixels iguais foram encontrados, e  " + contador2 + " pixels incorretos foram encontrados");
                }
            }
            else
            {
                MessageBox.Show("As imagens n�o podem ser comparadas");
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            picImagem1.Image = null;
            picImagem2.Image = null;
            pgBar1.Value = 0;
        }
    }
}