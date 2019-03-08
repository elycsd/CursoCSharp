using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Para tornar este form um MDIContainer, basta definir a 
             propriedade IsMdiContainer como true nas propriedades ou via código*/
            this.IsMdiContainer = true;
        }

        private void mnuAbrirChild1_Click(object sender, EventArgs e)
        {
            /*Ao clicar no botão do menu para abrir o Form Child 1,
             será criada uma instância do form e a sua propriedade 
             MdiParent é definida como this(este formulario)*/
            frmMDIChild1 form1 = new frmMDIChild1();
            form1.MdiParent = this;
            form1.Show();

        }

        private void mnuAbrirChild2_Click(object sender, EventArgs e)
        {
            /*Dado o fato de que um form é uma classe, em seu construtor foi inserido um argumento
             do tipo form que será repassado ao form Child 2 como seu ParentForm da seguinte forma:

             public MDIChild2(Form ParentForm)
          {
            InitializeComponent();
            this.MdiParent = ParentForm;
          }
             */
            frmMDIChild2 form2 = new frmMDIChild2(this);
            form2.Show();
        }
    }
}
