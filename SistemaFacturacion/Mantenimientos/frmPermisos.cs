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
    public partial class frmPermisos : Form
    {
        public static String Usuario, Nombre;
        public frmPermisos()
        {
            InitializeComponent();
        }


        private void frmPermisos_Load(object sender, EventArgs e)
        {
            txt_Usuario.Text = Usuario;
            txt_Nombre.Text = Nombre;
            Vista_Formularios(Principal.USUARIO);
            Vista_Formularios_Faltantes(Principal.USUARIO);
        }

        private void Vista_Formularios(String Usuario) {
            string sql;
            //Visualizacion de formularios
            sql = Principal.EMPRESA + ".FORMULARIOS_USUARIO '" + Usuario  +"','F'";

            SqlDataAdapter datos = new SqlDataAdapter(sql, Principal.CadenaConex);
            DataTable dt = new DataTable();
            try {

                datos.Fill(dt);
                dg_Formularios.DataSource = dt;
            }
            catch (InvalidCastException e) {
                MessageBox.Show(e.Message);
            }
        }


        private void Vista_Formularios_Faltantes(String Usuario)
        {
            string sql;
            //Visualizacion de formularios
            sql = Principal.EMPRESA + ".FORMULARIOS_USUARIO '" + Usuario + "','A'";

            SqlDataAdapter datos = new SqlDataAdapter(sql, Principal.CadenaConex);
            DataTable dt = new DataTable();
            try
            {

                datos.Fill(dt);
                dg_Permisos.DataSource = dt;
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Verifica si hay registros
            if (dg_Formularios.RowCount == 0 ){
                MessageBox.Show("No hay mas formularios por agregar", "Mensaje del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else {   //Llama funcion de agregado de permiso
            //Accion I= Insert
            Agregar_Quitar_Acceso(txt_Usuario.Text, dg_Formularios.CurrentRow.Cells["Cod_form"].Value.ToString(),"I");
            //Actualiza la vista de los formularios
            Vista_Formularios_Faltantes(txt_Usuario.Text);
            Vista_Formularios(txt_Usuario.Text); } 
         
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (dg_Permisos.RowCount == 0) {
                MessageBox.Show("No hay mas formularios por quitar", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
            //Llama funcion de eliminacion de acceso
            //Accion D= Delete 
            Agregar_Quitar_Acceso(txt_Usuario.Text, dg_Permisos.CurrentRow.Cells["Cod_form"].Value.ToString(), "D");
            //Actualiza la vista de los formularios
            Vista_Formularios_Faltantes(txt_Usuario.Text);
            Vista_Formularios(txt_Usuario.Text);

            }
            

        }

        private void Agregar_Quitar_Acceso(String Usuario, String formulario ,String Accion) {
            string sql;
            sql = Principal.EMPRESA + ".DEL_INS_PERMISO_USUARIO '"+Usuario + "','"+ formulario +"','" +  Accion +"'";

            //Proceso de delete o insert para los permisos sobre los formularios
            SqlConnection conex = new SqlConnection(Principal.CadenaConex);
            SqlCommand comando = new SqlCommand(sql, conex);

            conex.Open();
            try
            {
                comando.ExecuteNonQuery();
                conex.Close();
            }
            catch (InvalidCastException e) {
                conex.Close();
                MessageBox.Show(e.Message);
            }


        }

    }
}
