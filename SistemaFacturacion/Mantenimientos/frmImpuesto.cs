﻿using System;
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
    public partial class frmImpuesto : Form
    {
       
        public frmImpuesto()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            datos();
        }

        private void frmImpuesto_Load(object sender, EventArgs e)
        {
            datos();
            BLOQUEAR(false);
        }
        public void BLOQUEAR(Boolean TIPO)
        {
            txtCodigo.Enabled = TIPO;
            txtNombre.Enabled = TIPO;
            txtPorc.Enabled = TIPO;
        }
        public void datos()
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(Principal.EMPRESA + ".SELECT_IMPUESTO", Principal.CadenaConex))
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

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatos.CurrentRow != null)
                {
                    txtCodigo.Text = dgvDatos.CurrentRow.Cells["IMPUESTO"].Value.ToString();
                    txtNombre.Text = dgvDatos.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                    txtPorc.Text = dgvDatos.CurrentRow.Cells["PORCENTAJE"].Value.ToString();

                }
            }

            catch (Exception a)
            {

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BLOQUEAR(true);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPorc.Text = "";
        }


        public void ACCION(string accion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Principal.CadenaConex))
                {
                    SqlCommand cmd = new SqlCommand(Principal.EMPRESA + ".IMPUESTO_ACCION", connection);
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ACCION", accion);
                    cmd.Parameters.AddWithValue("@IMPUESTO", txtCodigo.Text);

                    if (accion == "UPDATE" || accion == "INSERT")
                    {
                        cmd.Parameters.AddWithValue("@DESCRIPCION", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@IMP", txtPorc.Text);

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Principal.EDIT = true;
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;
            txtPorc.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que dese eliminar?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ACCION("DELETE");
            }
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

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
