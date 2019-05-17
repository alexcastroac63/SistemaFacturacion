using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion.Mantenimientos
{
    public partial class frmListaPaquetes : Form
    {
        public frmListaPaquetes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Mantenimientos.frmListaPaquetes frm = new Mantenimientos.frmListaPaquetes();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

        }
    }
}
