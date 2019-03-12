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

namespace PastasEArquivos
{
    public partial class frmConfig : Form
    {
        /*A classe Environment fornece um conjunto de informações do ambiente
         de trabalho, tipo versão do sistema operacional, localização de pastas
         do usuário e etc.*/
        string pastaConfig = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string arquivoConfig = @"config.dat";
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarConfig();
            MessageBox.Show("Configurações gravadas com sucesso.");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            lsbDados.Items.Clear();
            if (!File.Exists(pastaConfig + @"\" + arquivoConfig))
            {
                GravarConfig();
            }
            StreamReader arquivo = new StreamReader(pastaConfig + @"\" + arquivoConfig, Encoding.Default);
            lsbDados.Items.Add(arquivo.ReadLine());
            lsbDados.Items.Add(arquivo.ReadLine());
            arquivo.Dispose();
        }
        private void GravarConfig()
        {
            if (!Directory.Exists(pastaConfig))
            {
                Directory.CreateDirectory(pastaConfig);
            }
            StreamWriter arquivo = new StreamWriter(pastaConfig + @"\" + arquivoConfig, false, Encoding.Default);
            arquivo.WriteLine(txtNome.Text);
            arquivo.WriteLine(dtpData.Value.ToShortDateString());
            arquivo.Dispose();
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            string caminhoDoArquivo = @"D:\teste\arquivo3.txt";
            if (File.Exists(caminhoDoArquivo))
                File.Delete(caminhoDoArquivo);
        }
        private void ApagarPasta()
        {
            if (Directory.Exists(@"D:\teste"))
            {
                Directory.Delete(@"D:\teste", true);
                /*Por padrão o método Delete apaga apenas diretórios vazios, o parametro true
                 serve para dizer se o metodo será executado recursivamente, apagando pastas
                 subpastas e arquivos.*/
            }
        }
        private void MetodosDaClasseFile()
        {
            File.Copy(@"c:\config.dat", @"c:\Config\config.dat"); //Copiar(pastaatual, destino)
            File.Delete(@"c:\Config\config.dat");//Deletar
            File.Create(@"c:\Config\config.dat"); //Cria ou sobrescreve um arquivo
            File.Move(@"c:\config.dat", @"c:\Config\config.dat"); //Mover(pastaatual, destino)
            File.Exists(@"c:\Config\config.dat"); //Cria ou sobrescreve um arquivo
        }
        private void MetodosDaClassePath()
        {
            string item = @"caminho completo do arquivo";
            Path.GetFileName(item);/*item possui o caminho completo do arquivo, 
                GetFileName retorna apenas o nome do arquivo*/
            Path.GetFileNameWithoutExtension(item);/*GetFileName retorna o nome sem extensão*/
            Path.GetExtension(item); //retorna apenas a extenxão do arquivo
            Path.HasExtension(item); /*bool que informa se o caminho possui uma extensão, 
            ideal para distinguir se corresponde a uma pasta ou  a um arquivo*/
            Path.GetDirectoryName(item);//retorna o nome do diretório
        }
        private void btnListarArquivos_Click(object sender, EventArgs e)
        {
            lsbDados.Items.Clear();
            string[] listaDeArquivos = Directory.GetFiles(@"D:\Udemy\Linguagem C#", "*.mp4");/*Poderia ser *.m*, 
            *t*.*(qualquer um que tenha a letra t no nome e de qualquer extensão)*/
            foreach (string item in listaDeArquivos)
            {
                lsbDados.Items.Add(Path.GetDirectoryName(item));
                lsbDados.Items.Add(Path.GetFileNameWithoutExtension(item));
            }
        }
    }
}
