namespace SistemaFacturacion.Mantenimientos
{
    partial class frmListadoProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label12 = new System.Windows.Forms.Label();
            this.cmbTipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem4 = new DevComponents.Editors.ComboItem();
            this.ComboItem5 = new DevComponents.Editors.ComboItem();
            this.txtFiltro = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.btFiltro = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(15, 28);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(28, 13);
            this.Label12.TabIndex = 100;
            this.Label12.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DisplayMember = "Text";
            this.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 14;
            this.cmbTipo.Items.AddRange(new object[] {
            this.ComboItem4,
            this.ComboItem5});
            this.cmbTipo.Location = new System.Drawing.Point(49, 28);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 20);
            this.cmbTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbTipo.TabIndex = 99;
            this.cmbTipo.Text = "DESCRIPCION";
            // 
            // ComboItem4
            // 
            this.ComboItem4.Text = "DESCRIPCION";
            // 
            // ComboItem5
            // 
            this.ComboItem5.Text = "ARTICULO";
            // 
            // txtFiltro
            // 
            // 
            // 
            // 
            this.txtFiltro.Border.Class = "TextBoxBorder";
            this.txtFiltro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFiltro.Location = new System.Drawing.Point(176, 28);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(295, 20);
            this.txtFiltro.TabIndex = 98;
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar,
            this.btnExcel,
            this.btFiltro,
            this.ToolStripSeparator1,
            this.btnCerrar,
            this.btnActualizar});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(871, 25);
            this.ToolStrip2.TabIndex = 97;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SistemaFacturacion.Properties.Resources.add_file_16;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::SistemaFacturacion.Properties.Resources.Edit_16;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::SistemaFacturacion.Properties.Resources.delete_16;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::SistemaFacturacion.Properties.Resources.Excel_2007_16;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(53, 22);
            this.btnExcel.Text = "Excel";
            // 
            // btFiltro
            // 
            this.btFiltro.Image = global::SistemaFacturacion.Properties.Resources.filtro;
            this.btFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(54, 22);
            this.btFiltro.Text = "Filtro";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 22);
            this.btnCerrar.Text = "Cerrar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::SistemaFacturacion.Properties.Resources.Recycle_Refresh_simple_16;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(6, 54);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(853, 353);
            this.dgvDatos.TabIndex = 96;
            // 
            // frmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 410);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.ToolStrip2);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmListadoProductos";
            this.Text = "frmListadoProductos";
            this.Load += new System.EventHandler(this.frmListadoProductos_Load);
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label12;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cmbTipo;
        internal DevComponents.Editors.ComboItem ComboItem4;
        internal DevComponents.Editors.ComboItem ComboItem5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtFiltro;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripButton btnNuevo;
        internal System.Windows.Forms.ToolStripButton btnModificar;
        internal System.Windows.Forms.ToolStripButton btnEliminar;
        internal System.Windows.Forms.ToolStripButton btnExcel;
        internal System.Windows.Forms.ToolStripButton btFiltro;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btnCerrar;
        internal System.Windows.Forms.ToolStripButton btnActualizar;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
    }
}