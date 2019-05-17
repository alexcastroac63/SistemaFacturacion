namespace SistemaFacturacion.Mantenimientos
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.dg_Usuarios_Grupos = new System.Windows.Forms.DataGridView();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btn_Permisos = new System.Windows.Forms.ToolStripButton();
            this.btnActivar = new System.Windows.Forms.ToolStripButton();
            this.btnDesactivar = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.chk_Usuarios = new System.Windows.Forms.CheckBox();
            this.chk_Grupos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Frecuencia = new System.Windows.Forms.ComboBox();
            this.dg_Permisos = new System.Windows.Forms.DataGridView();
            this.txt_Accion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Usuarios_Grupos)).BeginInit();
            this.ToolStrip2.SuspendLayout();
            this.toolStripContainer1.RightToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Permisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Usuarios_Grupos
            // 
            this.dg_Usuarios_Grupos.AllowUserToAddRows = false;
            this.dg_Usuarios_Grupos.AllowUserToDeleteRows = false;
            this.dg_Usuarios_Grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Usuarios_Grupos.Location = new System.Drawing.Point(12, 52);
            this.dg_Usuarios_Grupos.Name = "dg_Usuarios_Grupos";
            this.dg_Usuarios_Grupos.ReadOnly = true;
            this.dg_Usuarios_Grupos.Size = new System.Drawing.Size(573, 220);
            this.dg_Usuarios_Grupos.TabIndex = 1;
            this.dg_Usuarios_Grupos.DoubleClick += new System.EventHandler(this.dg_Usuarios_Grupos_DoubleClick);
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.BackColor = System.Drawing.Color.White;
            this.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btn_Permisos,
            this.btnActivar,
            this.btnDesactivar,
            this.btnExcel,
            this.ToolStripSeparator1,
            this.btnActualizar,
            this.btnGuardar});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 3);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(82, 201);
            this.ToolStrip2.TabIndex = 23;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SistemaFacturacion.Properties.Resources.add_file_16;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 20);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::SistemaFacturacion.Properties.Resources.Edit_16;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 20);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btn_Permisos
            // 
            this.btn_Permisos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Permisos.Image")));
            this.btn_Permisos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Permisos.Name = "btn_Permisos";
            this.btn_Permisos.Size = new System.Drawing.Size(80, 20);
            this.btn_Permisos.Text = "Permisos";
            this.btn_Permisos.Click += new System.EventHandler(this.btn_Permisos_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Image = ((System.Drawing.Image)(resources.GetObject("btnActivar.Image")));
            this.btnActivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(80, 20);
            this.btnActivar.Text = "Activar";
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Image = global::SistemaFacturacion.Properties.Resources.excel_26;
            this.btnDesactivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(80, 20);
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::SistemaFacturacion.Properties.Resources.Excel_2007_16;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 20);
            this.btnExcel.Text = "Excel";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(80, 6);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::SistemaFacturacion.Properties.Resources.Recycle_Refresh_simple_16;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 20);
            this.btnActualizar.Text = "Actualizar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::SistemaFacturacion.Properties.Resources.save_as_16;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 20);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(9, 220);
            this.toolStripContainer1.Location = new System.Drawing.Point(591, 52);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.Controls.Add(this.ToolStrip2);
            this.toolStripContainer1.Size = new System.Drawing.Size(91, 220);
            this.toolStripContainer1.TabIndex = 35;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // chk_Usuarios
            // 
            this.chk_Usuarios.AutoSize = true;
            this.chk_Usuarios.Checked = true;
            this.chk_Usuarios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Usuarios.Location = new System.Drawing.Point(36, 6);
            this.chk_Usuarios.Name = "chk_Usuarios";
            this.chk_Usuarios.Size = new System.Drawing.Size(67, 17);
            this.chk_Usuarios.TabIndex = 36;
            this.chk_Usuarios.Text = "Usuarios";
            this.chk_Usuarios.UseVisualStyleBackColor = true;
            this.chk_Usuarios.CheckStateChanged += new System.EventHandler(this.chk_Usuarios_CheckStateChanged);
            // 
            // chk_Grupos
            // 
            this.chk_Grupos.AutoSize = true;
            this.chk_Grupos.Location = new System.Drawing.Point(36, 29);
            this.chk_Grupos.Name = "chk_Grupos";
            this.chk_Grupos.Size = new System.Drawing.Size(60, 17);
            this.chk_Grupos.TabIndex = 37;
            this.chk_Grupos.Text = "Grupos";
            this.chk_Grupos.UseVisualStyleBackColor = true;
            this.chk_Grupos.CheckStateChanged += new System.EventHandler(this.chk_Grupos_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuario :";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.LightGray;
            this.txt_usuario.Enabled = false;
            this.txt_usuario.Location = new System.Drawing.Point(95, 294);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre :";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.LightGray;
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(95, 320);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(183, 20);
            this.txt_Nombre.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Estado :";
            // 
            // txt_Estado
            // 
            this.txt_Estado.BackColor = System.Drawing.Color.LightGray;
            this.txt_Estado.Enabled = false;
            this.txt_Estado.Location = new System.Drawing.Point(95, 346);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(100, 20);
            this.txt_Estado.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Frecuencia  :";
            // 
            // cb_Frecuencia
            // 
            this.cb_Frecuencia.FormattingEnabled = true;
            this.cb_Frecuencia.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120",
            "240",
            "0"});
            this.cb_Frecuencia.Location = new System.Drawing.Point(95, 372);
            this.cb_Frecuencia.Name = "cb_Frecuencia";
            this.cb_Frecuencia.Size = new System.Drawing.Size(100, 21);
            this.cb_Frecuencia.TabIndex = 39;
            this.cb_Frecuencia.Text = "60";
            // 
            // dg_Permisos
            // 
            this.dg_Permisos.AllowUserToAddRows = false;
            this.dg_Permisos.AllowUserToDeleteRows = false;
            this.dg_Permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Permisos.Location = new System.Drawing.Point(284, 294);
            this.dg_Permisos.Name = "dg_Permisos";
            this.dg_Permisos.ReadOnly = true;
            this.dg_Permisos.Size = new System.Drawing.Size(301, 113);
            this.dg_Permisos.TabIndex = 32;
            // 
            // txt_Accion
            // 
            this.txt_Accion.Location = new System.Drawing.Point(600, 323);
            this.txt_Accion.Name = "txt_Accion";
            this.txt_Accion.Size = new System.Drawing.Size(82, 20);
            this.txt_Accion.TabIndex = 40;
            this.txt_Accion.Visible = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(702, 421);
            this.Controls.Add(this.txt_Accion);
            this.Controls.Add(this.cb_Frecuencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_Grupos);
            this.Controls.Add(this.chk_Usuarios);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.dg_Permisos);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Usuarios_Grupos);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Usuarios_Grupos)).EndInit();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.toolStripContainer1.RightToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Permisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_Usuarios_Grupos;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripButton btnNuevo;
        internal System.Windows.Forms.ToolStripButton btnModificar;
        internal System.Windows.Forms.ToolStripButton btnDesactivar;
        internal System.Windows.Forms.ToolStripButton btnExcel;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btnActualizar;
        internal System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripButton btn_Permisos;
        private System.Windows.Forms.CheckBox chk_Usuarios;
        private System.Windows.Forms.CheckBox chk_Grupos;
        private System.Windows.Forms.ToolStripButton btnActivar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Frecuencia;
        private System.Windows.Forms.DataGridView dg_Permisos;
        private System.Windows.Forms.TextBox txt_Accion;
    }
}