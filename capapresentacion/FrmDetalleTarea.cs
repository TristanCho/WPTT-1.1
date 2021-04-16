using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacion
{
    public partial class FrmDetalleTarea : Form
    {
        public FrmDetalleTarea()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void habilitar(bool valor)
        {
            this.txtIdTarea.ReadOnly = true;
            this.txtTituloTarea.ReadOnly = true;
            //this.txtnombre.ReadOnly = !valor;
            //this.txtapellidos.ReadOnly = !valor;
            //this.txtdocumento.ReadOnly = !valor;
            //this.txtdireccion.ReadOnly = !valor;
            //this.cbosexo.Enabled = valor;
            //this.cbotipodocumento.Enabled = valor;
            //this.dtfechanacimiento.Enabled = valor;

        }
    }
}
