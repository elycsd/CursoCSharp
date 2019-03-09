using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorTrackBars
{
    public partial class frmColors : Form
    {
            Color colorNormal = Color.Black;
            Color colorInverso = Color.White;
        public frmColors()
        {
            InitializeComponent();
        }

        private void frmColors_Load(object sender, EventArgs e)
        {
            pctNormal.BackColor = colorNormal;
            pctInverso.BackColor = colorInverso;
        }

        private void trbRed_Scroll(object sender, EventArgs e)
        {
            lblRed.Text = "R:" + trbRed.Value.ToString();
            MostrarCor();
        }

        private void trbGreen_Scroll(object sender, EventArgs e)
        {
            lblGreen.Text = "G:" + trbGreen.Value.ToString();
            MostrarCor();
        }

        private void trbBlue_Scroll(object sender, EventArgs e)
        {
            lblBlue.Text = "B:" + trbBlue.Value.ToString();
            MostrarCor();
        }
        private void MostrarCor()
        {
           
            colorNormal = Color.FromArgb(trbRed.Value, trbGreen.Value, trbBlue.Value);
            colorInverso = Color.FromArgb(255-trbRed.Value, 255 - trbGreen.Value, 255 - trbBlue.Value);
            pctNormal.BackColor = colorNormal;
            pctInverso.BackColor = colorInverso;

            string normalColor = "(R:" + trbRed.Value.ToString() + 
                                 " G:" + trbGreen.Value.ToString() + 
                                 " B:" + trbBlue.Value.ToString() + ")";

            string inverseColor = "(R:" + (255-trbRed.Value).ToString() + 
                                  " G:" + (255 - trbGreen.Value).ToString() + 
                                  " B:" + (255 - trbBlue.Value).ToString()+ ")";
            lblNormal.Text = normalColor;
            lblInverso.Text = inverseColor;
        }
    }
}
