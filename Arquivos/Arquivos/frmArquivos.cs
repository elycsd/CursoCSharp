using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arquivos
{
    public partial class frmArquivos : Form
    {
        public frmArquivos()
        {
            InitializeComponent();
        }

        private void btnGravar_TextChanged(object sender, EventArgs e)
        {
            //this.AcceptButton = btnGravar;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            #region Explicação da classe StreamWriter
            /*Para criar um arquivo num diretorio, precisamos criar uma instancia
            da classe StreamWriter, pertencente ao namespace System.IO, usando a 
            sobrecarga especifica ao que desejamos fazer com o arquivo.
            Neste caso usaremos a sobrecarga 6, onde devemos informar o 
            caminho completo do arquivo, 
            bool append(true para adcionar conteudo, false para sobrescrever)
            */
            #endregion
            StreamWriter arquivo = new StreamWriter(@"C:\ProgramTests\Arquivo.txt", true, Encoding.Default);
            if (txtLinha.Text != "")
            {
                arquivo.WriteLine(txtLinha.Text);
                txtLinha.Text = "";
                txtLinha.Focus();
            }
            arquivo.Dispose(); //este método elimina elimina o streamwriter da memoria do computador
        }

        private void frmArquivos_Load(object sender, EventArgs e)
        {
            txtLinha.Focus();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            lsbTexto.Items.Clear(); //limpar o listBox antes de adicionar o conteudo

            #region Explicação da classe  StreamReader
            /*Para ler arquivos de um diretorio usamos a classe StreamReader do namespace System.IO.
            Devemos passar como parametro o caminho do arquivo e preferencialmente o Encoding(codificação)
            */
            #endregion
            StreamReader arquivo = new StreamReader(@"C:\ProgramTests\Arquivo.txt", Encoding.Default);
            while (!arquivo.EndOfStream)
            {
                lsbTexto.Items.Add(arquivo.ReadLine());
            }
            arquivo.Dispose();
        }
    }
}
