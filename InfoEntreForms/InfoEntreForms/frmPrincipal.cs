using System;
using System.Windows.Forms;

namespace InfoEntreForms
{
    public partial class frmPrincipal : Form
    {
        string nome = null;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (lblNome.Text!= "")
            {
                nome = lblNome.Text;
            }
            frmSecundario formulario = new frmSecundario(nome);
            formulario.ShowDialog();

            /*A linha de codigo abaixo só será executada após
             o formulario secundario ser fechado*/
            MessageBox.Show("Seção encerrada.");
            if (formulario.Nome != null)
                lblNome.Text = formulario.Nome;
        }
    }
}
