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
    public partial class frmUnidadMedida : Form
    {
       
        public frmUnidadMedida()
        {
            InitializeComponent();
        }

        private void frmUnidadMedida_Load(object sender, EventArgs e)
        {
            datos();
            BLOQUEAR(false);
        }
        public void datos()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".UNIDAD_MEDIDA", Principal.CadenaConex))
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
            BLOQUEAR(true);


            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Principal.EDIT = true;
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("Seguro que dese eliminar?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 {
                     ACCION("DELETE");
                 }
             }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
             datos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Principal.EDIT == true)
            {
                ACCION("UPDATE");
            }
            else
            {
                ACCION("INSERT");
            }
           
        }
             public void ACCION( string accion )
        {
        try
            {
                using (SqlConnection connection = new SqlConnection(Principal.CadenaConex))
                {
                    SqlCommand cmd = new SqlCommand(Principal.EMPRESA + ".UNIDAD_MEDIDA_ACCION", connection);
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ACCION", accion);
                    cmd.Parameters.AddWithValue("@UNIDAD", txtCodigo.Text);

                    if (accion == "UPDATE" || accion == "INSERT") {
                        cmd.Parameters.AddWithValue("@DESCRIPCION", txtNombre.Text);
                       
                    
                    }


                    cmd.ExecuteNonQuery();
                    BLOQUEAR(false);
                    MessageBox.Show(accion + " CORRECTAMENTE");
                    datos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar conectar a la bd" + ex);

            }

        }
          public void BLOQUEAR(Boolean TIPO)
             {
                 txtCodigo.Enabled = TIPO;
                 txtNombre.Enabled = TIPO;
                 

             }

          private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void dgvDatos_SelectionChanged(object sender, EventArgs e)
          {
              try
              {
                  if (dgvDatos.CurrentRow != null)
                  {
                      txtCodigo.Text = dgvDatos.CurrentRow.Cells["UNIDAD_MEDIDA"].Value.ToString();
                      txtNombre.Text = dgvDatos.CurrentRow.Cells["DESCRIPCION"].Value.ToString();

                  }
              }

              catch (Exception a)
              {

              }
          }
        
    }
}
