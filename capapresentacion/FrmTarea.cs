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
    public partial class FrmTarea : Form
    {
        public FrmPrincipal frmparent;
        public FrmTarea()
        {
            InitializeComponent();
            
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {

        }

        public void mostrartareas()
        {
            this.dataListTareas.DataSource = NTareas.mostrarproyectos();
           // this.ocultarcolumnas();
           // this.btnEliminarProyecto.Visible = true;
          //  this.lblTotal.Text = "Número de proyectos: " + Convert.ToString(dataListProyectos.Rows.Count);
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmparent.lanzarNuevoProyecto(new FrmDetalleTarea());
        }

        private void label_añadir_Click(object sender, EventArgs e)
        {

        }



        private void dataListProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  
    }
}
