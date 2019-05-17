using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SistemaFacturacion.Mantenimientos
{
    public partial class frmListadoProductos : Form
    {
        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void frmListadoProductos_Load(object sender, EventArgs e)
        {
            datos();
        }

        public void datos()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".SELECT_ARTICULO", Principal.CadenaConex))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(ds);
                    dgvDatos.DataSource = ds.Tables[0];
                    dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    dgvDatos.ScrollBars = ScrollBars.Both;
                    dgvDatos.ForeColor = System.Drawing.Color.DarkBlue;
                    dgvDatos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Principal.EDIT = false;
            Mantenimientos.frmProductos frm = new Mantenimientos.frmProductos();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Principal.EDIT = true;
            Mantenimientos.frmProductos frm = new Mantenimientos.frmProductos();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            datos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ACCION("DELETE");

        }
        public void ACCION(string accion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Principal.CadenaConex))
                {
                    SqlCommand comm = new SqlCommand(Principal.EMPRESA + ".ARTICULO_ACCION", connection);
                    connection.Open();
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@ACCION", accion);
                    comm.Parameters.AddWithValue("@ARTICULO", dgvDatos.CurrentRow.Cells["ARTICULO"].Value.ToString());


                    comm.ExecuteNonQuery();

                    MessageBox.Show(accion + " CORRECTAMENTE");

                    datos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar conectar a la bd" + ex);

            }

        }
    }
}
