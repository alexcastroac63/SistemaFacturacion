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

namespace SistemaFacturacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //validar que este seleccionada base de datos
            if (cmbBase.Text == "") {
                MessageBox.Show("Seleccion base de datos");
                return;
            }
            //validar empresa
            if (cmbEmpresa.Text == "")
            {
                MessageBox.Show("Seleccion empresa");
                return;
            }

            //validar  usuario

            if (txtUser.Text == "")
            {
                MessageBox.Show("Ingrese usuario");
                return;
            }

            
            //validar
            if (validacion() == true) { frmPrincipal frm = new frmPrincipal(); frm.Show(); this.Hide(); }
            else
            { }
          


         }


        public Boolean validacion() {
            Principal.BASE = cmbBase.Text;
            Principal.EMPRESA = cmbEmpresa.Text;
            Principal.USUARIO = txtUser.Text.Trim();
            Principal.PASS = txtPass.Text.Trim();
            Principal.SERVIDOR = "192.168.0.13";

           Principal.CadenaConex = "Server=" + Principal.SERVIDOR + ";Database=" + Principal.BASE + ";User Id=" + Principal.USUARIO + ";Password=" + Principal.PASS + ";";
           // Principal.CadenaConex = "initial catalog = "+ Principal.BASE  +"; data source="+ Principal.SERVIDOR +";integrated security=false;";

            //VALIDAR
            DataTable ds = new DataTable();
            try
            {
                using (SqlConnection conex = new SqlConnection(Principal.CadenaConex))
                {
                    conex.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = conex;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LoginUsuario";
                    cmd.Parameters.AddWithValue("@User", txtUser.Text);
                    cmd.Parameters.AddWithValue("@Pass", txtPass.Text);


                    SqlDataReader dr = cmd.ExecuteReader();
                    ds.Load(dr);
                    cmd.Parameters.Clear();

                    if (ds.Rows.Count > 0)
                    {

                        if (ds.Rows[0][0].ToString().ToUpper() == txtPass.Text.ToUpper()) { return true; }
                        else
                        { MessageBox.Show("Contraseña incorrecta"); return false; }
                    }
                    else { MessageBox.Show("Usuario incorrecto"); return false; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar llenar el DataSet" + ex);
                return false; 
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
