using System;
using System.Windows.Forms;

namespace InfoEntreForms
{
    public partial class frmSecundario : Form
    {
        public string Nome { get; set; }
        public frmSecundario(string nome)
        {
            InitializeComponent();
            txtNome.Text = nome;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Definir o valor a retornar
            if (txtNome.Text == "")
            {
                Nome = null;
            }
            else
            Nome = txtNome.Text;
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Fechar o form sem retornar nada
            Nome = null;
            this.Close();
        }

    }
}
