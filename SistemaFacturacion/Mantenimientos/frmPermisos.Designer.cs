namespace SistemaFacturacion.Mantenimientos
{
    partial class frmPermisos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_Formularios = new System.Windows.Forms.DataGridView();
            this.dg_Permisos = new System.Windows.Forms.DataGridView();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Quitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Formularios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Permisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Formularios
            // 
            this.dg_Formularios.AllowUserToAddRows = false;
            this.dg_Formularios.AllowUserToDeleteRows = false;
            this.dg_Formularios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Formularios.Location = new System.Drawing.Point(12, 67);
            this.dg_Formularios.Name = "dg_Formularios";
            this.dg_Formularios.ReadOnly = true;
            this.dg_Formularios.Size = new System.Drawing.Size(306, 217);
            this.dg_Formularios.TabIndex = 0;
            // 
            // dg_Permisos
            // 
            this.dg_Permisos.AllowUserToAddRows = false;
            this.dg_Permisos.AllowUserToDeleteRows = false;
            this.dg_Permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Permisos.Location = new System.Drawing.Point(400, 67);
            this.dg_Permisos.Name = "dg_Permisos";
            this.dg_Permisos.ReadOnly = true;
            this.dg_Permisos.Size = new System.Drawing.Size(328, 217);
            this.dg_Permisos.TabIndex = 1;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(89, 13);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.ReadOnly = true;
            this.txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Usuario.TabIndex = 3;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(206, 13);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(342, 20);
            this.txt_Nombre.TabIndex = 4;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(324, 134);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.Location = new System.Drawing.Point(324, 178);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(75, 23);
            this.btn_Quitar.TabIndex = 6;
            this.btn_Quitar.Text = "Quitar";
            this.btn_Quitar.UseVisualStyleBackColor = true;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(752, 312);
            this.Controls.Add(this.btn_Quitar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.dg_Permisos);
            this.Controls.Add(this.dg_Formularios);
            this.Name = "frmPermisos";
            this.Text = "frmPermisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Formularios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Permisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Formularios;
        private System.Windows.Forms.DataGridView dg_Permisos;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Quitar;
    }
}