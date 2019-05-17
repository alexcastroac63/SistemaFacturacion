using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    class Principal
    {
        public static string BASE, SERVIDOR, USUARIO, PASS, EMPRESA;

        public static string CadenaConex;
        public static Boolean EDIT;

        public static Boolean Verifica_Permisos(String Usuario,String Formulario) {
                    //Llama SP de verifiacion de permisos para el formulario
                    String sql;
                    sql = EMPRESA + ".SELECT_PERMISO_USUARIO '" + USUARIO + "' ,'"+ Formulario + "'";

                    SqlDataAdapter datos = new SqlDataAdapter(sql, CadenaConex);
                    DataTable dt  = new DataTable();

                    //Llenado de datos para verificacion de acceso
                    try {
                                datos.Fill(dt);
                                //Verifica si hay accesso
                                if (dt.Rows.Count == 0) {
                                        MessageBox.Show("El usuario actual no tine accesso a este formulario, si requiere acceso favor solictar este", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                        return false;
                                       
                }
                                else {
                  
                                        return true;
                                }
                    }
                    catch (InvalidCastException e) {
                                MessageBox.Show(e.Message);
                                return false;
                    }
  
        } 
    }


}
