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
    public partial class frmExistencias : Form
    {
        public frmExistencias()
        {
            InitializeComponent();
        }

        private void frmExistencias_Load(object sender, EventArgs e)
        {
            datos();
        }


        // llena grid
        public void datos()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".SELECT_EXISTENCIAS", Principal.CadenaConex))
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
    }

}
