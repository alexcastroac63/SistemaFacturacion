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
    public partial class frmGeneralesInv : Form
    {
        public frmGeneralesInv()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGeneralesInv_Load(object sender, EventArgs e)
        {
            datosClasificaciones();
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
                    if (ds.Tables[0].Rows.Count > 0) { 

                       txtClasi1.Text = ds.Tables[0].Rows[0][0].ToString();
                       txtClasi2.Text = ds.Tables[0].Rows[0][1].ToString();
                       txtClasi3.Text = ds.Tables[0].Rows[0][2].ToString();
                       txtClasi4.Text = ds.Tables[0].Rows[0][3].ToString();
                       txtClasi5.Text = ds.Tables[0].Rows[0][4].ToString();

                    }

                       
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Principal.CadenaConex))
                {
                    SqlCommand cmd = new SqlCommand(Principal.EMPRESA + ".GLOBALES_CI_ACCION", connection);
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@C1", txtClasi1.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@C2", txtClasi2.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@C3", txtClasi3.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@C4", txtClasi4.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@C5", txtClasi5.Text.ToUpper());


                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }
    }
}
