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
using System.Data.SqlTypes;


namespace SistemaFacturacion.Mantenimientos
{
    public partial class frmUsuarios : Form
    {
       
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Limpia los campos para que se pueda crear el usuario
            //habilita los campos para que se puedan editar
            txt_usuario.Text = "";
            txt_usuario.Enabled = true;
            txt_usuario.BackColor = Color.White;
            txt_Nombre.Text = "";
            txt_Nombre.Enabled = true;
            txt_Nombre.BackColor = Color.White;
            txt_Estado.Text = "";
            txt_Estado.Enabled = true;
            txt_Estado.BackColor = Color.White;
            txt_Accion.Text = "Nuevo";
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            //llama la vista de los datos de usuarios por default
            Vista_Datos_UG("U");
             
        }

        private void Vista_Datos_UG(String tipo) {
            //SP de seleccion de usuarios o grupo
            String sql;
            sql =  Principal.EMPRESA + ".SELECT_USUARIO_GRUPOS '" +tipo  +"'";
            //Conexion 
            SqlDataAdapter comando = new SqlDataAdapter(sql, Principal.CadenaConex);
            DataTable dt = new DataTable();

            try {
                comando.Fill(dt);
                dg_Usuarios_Grupos.DataSource = dt;
            }
            catch (InvalidCastException e) {
                MessageBox.Show(e.Message);
            }


            

        }


        private void chk_Usuarios_CheckStateChanged(object sender, EventArgs e)
        {
       Vista_Datos_UG("U");
            chk_Grupos.Checked = false;
        }

        private void chk_Grupos_CheckStateChanged(object sender, EventArgs e)
        { Vista_Datos_UG("G");
            chk_Usuarios.Checked = false;

        }

        private void dg_Usuarios_Grupos_DoubleClick(object sender, EventArgs e)
        {
            //Verifica que tipo de datos estan seleccionados, solo se puede modificar los usuarios
            if (chk_Usuarios.Checked = true)
            {
                txt_usuario.Text = dg_Usuarios_Grupos.CurrentRow.Cells["USUARIO"].Value.ToString();
                txt_Nombre.Text= dg_Usuarios_Grupos.CurrentRow.Cells["NOMBRE"].Value.ToString();
                txt_Estado.Text= dg_Usuarios_Grupos.CurrentRow.Cells["ESTADO"].Value.ToString();
            }
            else {
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Habilita los datos para que se puedan editar
          
            txt_Nombre.Enabled = true;
            txt_Nombre.BackColor = Color.White;

            txt_usuario.Enabled = false;
            txt_usuario.BackColor = Color.LightGray;
            txt_Estado.Enabled = false;
            txt_Estado.BackColor= Color.LightGray; ;
            //establece accion
            txt_Accion.Text = "Modifica";
        }

        private void btn_Permisos_Click(object sender, EventArgs e)
        {
            //Apertura de formulario de permisos
            frmPermisos frm = new frmPermisos();
            frmPermisos.Usuario = dg_Usuarios_Grupos.CurrentRow.Cells["usuario"].Value.ToString();
            frmPermisos.Nombre = dg_Usuarios_Grupos.CurrentRow.Cells["Nombre"].Value.ToString();


            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();


        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            Act_Des_Usuario("D", Principal.USUARIO);
        }

        private void Act_Des_Usuario(String Accion, String Usuario) {
            string sql;
            string Accion_Sel;

            if (Accion == "a")
            {
                Accion_Sel = "Activado";
            }
            else {
                Accion_Sel = "Desactivado";
            }
                sql = Principal.EMPRESA + ".ACT_DES_USUARIO ";

            SqlConnection conex = new SqlConnection(Principal.CadenaConex);
            SqlCommand comando = new SqlCommand(sql, conex);

            comando.Parameters.AddWithValue("@ACCION", Accion);
            comando.Parameters.AddWithValue("@Usuario", Usuario);

            try {
                comando.ExecuteNonQuery();
                Vista_Datos_UG("U");
                MessageBox.Show("El usuario fue " + Accion_Sel, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidCastException e) {
                MessageBox.Show(e.Message);
            }




        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            Act_Des_Usuario("A", Principal.USUARIO);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            //Verifica si se creara un nuevo usuario o se actulizara el actual
            //Por medio del txt_Accion, el cual guarda el dato del click del Button
            if (txt_Accion.Text == "Nuevo") {
                //Si se creara un nuevo usuario se verifica que no este vacio algún campo
                if (Verifica_Campos_Usuarios() == true) {
                    //Verifica que no sea un usuario duplicado
                    if (Verifica_Usuario_Dub(txt_usuario.Text) == false)
                    {
                        //Funcion de creacion del usuario
                        creacion_usuario(txt_usuario.Text, txt_Nombre.Text, "I", "");
                    }   
                }
                //Actulizar
                else
                {
                    //Si la accion es actulizacion solo se verifica si el usario existe en la base
                    if (Verifica_Usuario_Dub(txt_usuario.Text) == true) {

                    }
                }
            }
        }

        private void creacion_usuario(String usuario, String nombre, String accion, String Pass)
        {
            string sql;
            sql = Principal.EMPRESA + ".INSERT_UPDATE_USUARIO '"+ usuario + "','" +nombre + "','"+accion +"'";
            SqlConnection conex = new SqlConnection(Principal.CadenaConex);
            SqlCommand comando = new SqlCommand(sql,conex);

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("El usuario fue creado ", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidCastException e) {
                MessageBox.Show(e.Message);
            }

        }

        private Boolean Verifica_Usuario_Dub(String usuario) {
            String sql;
            sql = Principal.EMPRESA + ".SELECT_USUARIO_GRUPOS 'S','"  + usuario  + "'";
            SqlDataAdapter comando = new SqlDataAdapter(sql, Principal.CadenaConex);
            DataTable dt = new DataTable();
            try
            {
                comando.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return true;
                }
                else {
                    MessageBox.Show("El usuario ya existe en la base de datos ","Mensaje del Sistema ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (InvalidCastException e) {
                MessageBox.Show(e.Message);
                return false;
            }


        }
        private Boolean Verifica_Campos_Usuarios() {
            //verifica si el usuario esta vacio
            if (txt_usuario.Text == ""|| txt_usuario.Text== null)
            {
                MessageBox.Show("El campo de usuario esta vacio ", "Mesaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else {
                if (txt_Nombre.Text == "" || txt_Nombre.Text == null)
                {
                    MessageBox.Show("El campo de nombre esta vacio ", "Mesaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    int result;
                    if (int.TryParse(cb_Frecuencia.Text,out result)== false) {
                        MessageBox.Show("El campo de frecuencia esta vacio ", "Mesaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
            }

        }
    }


    }


