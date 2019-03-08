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
    public partial class frmMDIChild2 : Form
    {
        public frmMDIChild2(Form ParentForm)
        {
            InitializeComponent();
            this.MdiParent = ParentForm;

            /*Forms filhos por padrão não iniciam centralizados no form pai,
             para contornar esta situação podemos usar a propriedade DisplayRectangle
             do form pai
             */

            int largura = ParentForm.DisplayRectangle.Width;
            int altura = ParentForm.DisplayRectangle.Height;
            this.Location = new Point(largura / 2 - this.Width / 2, altura / 2 - this.Height / 2);
            //Definir a propriedade StartPosition como manual
        }

        private void MDIChild2_Load(object sender, EventArgs e)
        {

        }
    }
}
