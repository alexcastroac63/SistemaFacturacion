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
    public partial class frmClasificaciones : Form
    {

        public frmClasificaciones()
        {
            InitializeComponent();
        }

        private void frmClasificaciones_Load(object sender, EventArgs e)
        {
            BLOQUEAR(false);
            datos();
            datosClasificaciones();
        }

      public void  BLOQUEAR(Boolean TIPO){
         txtCodigo.Enabled = TIPO;
            txtNombre.Enabled = TIPO;
            cmbTipo.Enabled = TIPO;

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            datos();
        }

       
        // llena grid
        public void datos() { 
         DataSet ds = new DataSet();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".SELECT_CLASIFICACION", Principal.CadenaConex))
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

        //listado de clasificaciones
        public void datosClasificaciones()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".CLASIFICACIONES", Principal.CadenaConex))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(ds);
                    for (int i = 0; i < ds.Tables[0].Columns.Count; i++) {
                        cmbTipo.Items.Add(ds.Tables[0].Rows[0][i].ToString());
                    }

                      
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }


        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            datos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         if(MessageBox.Show("Seguro que dese eliminar?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
             ACCION("DELETE");
            }
           
            }
    


        public void ACCION( string accion )
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Principal.CadenaConex))
                {
                    SqlCommand cmd = new SqlCommand(Principal.EMPRESA + ".CLASIFICACION_ACCION", connection);
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ACCION", accion);
                    cmd.Parameters.AddWithValue("@CLASIFICACION", txtCodigo.Text);

                    if (accion == "UPDATE" || accion == "INSERT") {
                        cmd.Parameters.AddWithValue("@DESCRIPCION", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@AGRUPACION", cmbTipo.SelectedIndex+1);
                    
                    }


                    cmd.ExecuteNonQuery();
                    BLOQUEAR(false);
                    MessageBox.Show(accion + " CORRECTAMENTE");
                    datos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
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
                    txtCodigo.Text = dgvDatos.CurrentRow.Cells["CLASIFICACION"].Value.ToString();
                    txtNombre.Text = dgvDatos.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                    cmbTipo.Text = dgvDatos.CurrentRow.Cells["AGRUPACIONES"].Value.ToString();
                  }
             }

            catch (Exception a ){
            
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Principal.EDIT = false;
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            cmbTipo.Enabled = true;

            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Principal.EDIT = true;
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;
            cmbTipo.Enabled = true;

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

        }
    

}
