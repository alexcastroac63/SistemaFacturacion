using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.ShowDialog();

        }

        private void crearClasificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verifica el acceso al formulario
            if (Principal.Verifica_Permisos(Principal.USUARIO, "frmClasificaciones") == true) {
                    Mantenimientos.frmClasificaciones frm = new Mantenimientos.frmClasificaciones();
                    frm.ShowDialog();
            }


          

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void tiposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmTipoProducto frm = new Mantenimientos.frmTipoProducto();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
           
        }

        private void tipoClasificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmGeneralesInv frm = new Mantenimientos.frmGeneralesInv();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Mantenimientos.frmUnidadMedida frm = new Mantenimientos.frmUnidadMedida();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmImpuesto frm = new Mantenimientos.frmImpuesto();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmListadoProductos frm = new Mantenimientos.frmListadoProductos();
             frm.MdiParent = this;
             frm.WindowState = FormWindowState.Maximized;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();


          
        }

        private void salidasYEntradasDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmListaPaquetes frm = new Mantenimientos.frmListaPaquetes();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmExistencias frm = new Mantenimientos.frmExistencias();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmUsuarios frm = new Mantenimientos.frmUsuarios();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
    
}
