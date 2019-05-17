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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            Clasi();
            TipoProducto();
            UnidadMedida();
            Impuestos();
        }
        public void Clasi()
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            DataSet ds4 = new DataSet();
            DataSet ds5 = new DataSet();

            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".CLASIFICACIONES", Principal.CadenaConex))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@AGRUPACION", 1);
                    da.Fill(ds1);
                    cmbClasi1.DataSource = ds1.Tables[0];
                    cmbClasi1.DisplayMember = "DESCRIPCION";
                    cmbClasi1.ValueMember = "CLASIFICACION";
       
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddWithValue("@AGRUPACION", 2);
                    da.Fill(ds2);
                    cmbClasi2.DataSource = ds2.Tables[0];
                    cmbClasi2.DisplayMember = "DESCRIPCION";
                    cmbClasi2.ValueMember = "CLASIFICACION";

                  
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddWithValue("@AGRUPACION", 3);
                    da.Fill(ds3);
                    cmbClasi3.DataSource = ds3.Tables[0];
                    cmbClasi3.DisplayMember = "DESCRIPCION";
                    cmbClasi3.ValueMember = "CLASIFICACION";

                   
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddWithValue("@AGRUPACION", 4);
                    da.Fill(ds4);
                    cmbClasi4.DataSource = ds4.Tables[0];
                    cmbClasi4.DisplayMember = "DESCRIPCION";
                    cmbClasi4.ValueMember = "CLASIFICACION";

                   
                    da.SelectCommand.Parameters.Clear();
                    da.SelectCommand.Parameters.AddWithValue("@AGRUPACION", 5);
                    da.Fill(ds5);
                    cmbClasi5.DataSource = ds5.Tables[0];
                    cmbClasi5.DisplayMember = "DESCRIPCION";
                    cmbClasi5.ValueMember = "CLASIFICACION";
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }

        public void TipoProducto()
        {
            DataSet ds1 = new DataSet();
          
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".SELECT_TIPO_PRODUCTO", Principal.CadenaConex))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(ds1);
                    cmbTipo.DataSource = ds1.Tables[0];
                    cmbTipo.DisplayMember = "NOMBRE";
                    cmbTipo.ValueMember = "TIPO";                       

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }


        public void UnidadMedida()
        {
            DataSet ds1 = new DataSet();

            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".UNIDAD_MEDIDA", Principal.CadenaConex))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(ds1);
                    cmbUnidad.DataSource = ds1.Tables[0];
                    cmbUnidad.DisplayMember = "DESCRIPCION";
                    cmbUnidad.ValueMember = "UNIDAD_MEDIDA";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }

        public void Impuestos()
        {
            DataSet ds1 = new DataSet();

            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".SELECT_IMPUESTO", Principal.CadenaConex))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(ds1);
                    cmbImpuesto.DataSource = ds1.Tables[0];
                    cmbImpuesto.DisplayMember = "DESCRIPCION";
                    cmbImpuesto.ValueMember = "IMPUESTO";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }

        public void Correlativo()
        {   
            DataSet ds = new DataSet();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".MAXART", Principal.CadenaConex))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@FILTRO", cmbClasi1.SelectedValue);
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        txtCodigo.Text = cmbClasi1.SelectedValue + String.Format("{0,4:X4}", ds.Tables[0].Rows[0][0]);
                   
                    }
                                      
                }
               
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }


        public void datosClasificaciones()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".CLASIFICACIONES", Principal.CadenaConex))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        lblClasi1.Text = ds.Tables[0].Rows[0][0].ToString();
                        lblClasi2.Text = ds.Tables[0].Rows[0][1].ToString();
                        lblClasi3.Text = ds.Tables[0].Rows[0][2].ToString();
                        lblClasi4.Text = ds.Tables[0].Rows[0][3].ToString();
                        lblClasi5.Text = ds.Tables[0].Rows[0][4].ToString();

                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);

            }
        }

        private void cmbClasi1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Correlativo();
            }
            catch (Exception a) { 
            
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             if (txtDescripcion.Text == "") {
            MessageBox.Show("Ingrese descripcion");
            return;

                }
             ACCION("INSERT");

       
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    comm.Parameters.AddWithValue("@ARTICULO", txtCodigo.Text.ToUpper());
                    comm.Parameters.AddWithValue("@DESCRIPCION", txtDescripcion.Text.ToUpper());
                    comm.Parameters.AddWithValue("@CLASIFICACION_1", cmbClasi1.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@CLASIFICACION_2", cmbClasi2.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@TIPO", cmbTipo.SelectedValue);
                    comm.Parameters.AddWithValue("@IMPUESTO", cmbImpuesto.SelectedValue);
                    comm.Parameters.AddWithValue("@ACTIVO", chkActivo.Checked);
                    comm.Parameters.AddWithValue("@USA_LOTES", chkUsaLote.Checked);
                    comm.Parameters.AddWithValue("@UNIDAD_MEDIDA", cmbUnidad.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@CTA1", txtcta1.Text.ToString());
                    comm.Parameters.AddWithValue("@CTA2", txtcta2.Text.ToString());
                    comm.Parameters.AddWithValue("@CTA3", txtcta3.Text.ToString());
                    comm.Parameters.AddWithValue("@CTA4", txtcta4.Text.ToString());
                    comm.Parameters.AddWithValue("@CTA5", txtcta5.Text.ToString());
                    comm.Parameters.AddWithValue("@CTA6", txtcta6.Text.ToString());
                    comm.Parameters.AddWithValue("@CTA7", txtcta7.Text.ToString());
                    
                    comm.ExecuteNonQuery();
                   
                    MessageBox.Show(accion + " CORRECTAMENTE");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar conectar a la bd" + ex);

            }

        }

    }
}
