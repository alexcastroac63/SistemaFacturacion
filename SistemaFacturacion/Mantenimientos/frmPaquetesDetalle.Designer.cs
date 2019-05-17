namespace SistemaFacturacion.Mantenimientos
{
    partial class frmPaquetesDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblTotalTras = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.btnELiminar = new DevComponents.DotNetBar.ButtonX();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtNotas = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label8 = new System.Windows.Forms.Label();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnRecibir = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvDatos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtLote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtCosto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.txtCantidad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtArticulo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Panel1.SuspendLayout();
            this.ToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.White;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "VENTAS",
            "AJUSTES",
            "MISCELANEOS",
            "INVENTARIO",
            "COMPRAS"});
            this.cmbTipo.Location = new System.Drawing.Point(47, 68);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(127, 23);
            this.cmbTipo.TabIndex = 113;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(13, 70);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(28, 13);
            this.Label12.TabIndex = 112;
            this.Label12.Text = "Tipo";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.lblTotalTras);
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Controls.Add(this.btnELiminar);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Location = new System.Drawing.Point(402, 520);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(447, 36);
            this.Panel1.TabIndex = 111;
            // 
            // lblTotalTras
            // 
            this.lblTotalTras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTras.AutoSize = true;
            this.lblTotalTras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTras.Location = new System.Drawing.Point(376, 11);
            this.lblTotalTras.Name = "lblTotalTras";
            this.lblTotalTras.Size = new System.Drawing.Size(48, 16);
            this.lblTotalTras.TabIndex = 89;
            this.lblTotalTras.Text = "$ 0.00";
            this.lblTotalTras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(297, 11);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(44, 16);
            this.Label11.TabIndex = 88;
            this.Label11.Text = "Total";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnELiminar
            // 
            this.btnELiminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnELiminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnELiminar.Location = new System.Drawing.Point(172, 4);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(25, 23);
            this.btnELiminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnELiminar.TabIndex = 87;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(25, 11);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(106, 16);
            this.Label7.TabIndex = 86;
            this.Label7.Text = "Eliminar Linea";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Location = new System.Drawing.Point(12, 101);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(59, 13);
            this.Label10.TabIndex = 110;
            this.Label10.Text = "Referencia";
            // 
            // txtNotas
            // 
            // 
            // 
            // 
            this.txtNotas.Border.Class = "TextBoxBorder";
            this.txtNotas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(77, 101);
            this.txtNotas.MaxLength = 200;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(758, 22);
            this.txtNotas.TabIndex = 109;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(481, 124);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(37, 13);
            this.Label9.TabIndex = 108;
            this.Label9.Text = "Precio";
            // 
            // txtPrecio
            // 
            // 
            // 
            // 
            this.txtPrecio.Border.Class = "TextBoxBorder";
            this.txtPrecio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(475, 140);
            this.txtPrecio.MaxLength = 12;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(67, 22);
            this.txtPrecio.TabIndex = 107;
            // 
            // txtDocumento
            // 
            // 
            // 
            // 
            this.txtDocumento.Border.Class = "TextBoxBorder";
            this.txtDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(263, 68);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(174, 20);
            this.txtDocumento.TabIndex = 106;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Location = new System.Drawing.Point(195, 70);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(62, 13);
            this.Label8.TabIndex = 105;
            this.Label8.Text = "Documento";
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnRecibir,
            this.ToolStripSeparator1,
            this.btnCerrar});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(899, 25);
            this.ToolStrip2.TabIndex = 104;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::SistemaFacturacion.Properties.Resources.save_as_16;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 22);
            this.btnSave.Text = "Guardar";
            // 
            // btnRecibir
            // 
            this.btnRecibir.Image = global::SistemaFacturacion.Properties.Resources.accept;
            this.btnRecibir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(64, 22);
            this.btnRecibir.Text = "Aplicar";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.Image = global::SistemaFacturacion.Properties.Resources.Exit16x16;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 22);
            this.btnCerrar.Text = "Cerrar";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(711, 140);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(99, 22);
            this.dtpFecha.TabIndex = 103;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Linea,
            this.Articulo,
            this.Descripcion,
            this.Cantidad,
            this.Lote,
            this.Vence,
            this.Costo,
            this.Total,
            this.Existencia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDatos.Location = new System.Drawing.Point(0, 164);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(886, 350);
            this.dgvDatos.TabIndex = 102;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            this.Linea.Visible = false;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // Vence
            // 
            this.Vence.HeaderText = "Vence";
            this.Vence.Name = "Vence";
            this.Vence.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Visible = false;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 70;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            this.Existencia.Width = 60;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Location = new System.Drawing.Point(624, 124);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(28, 13);
            this.Label6.TabIndex = 101;
            this.Label6.Text = "Lote";
            // 
            // txtLote
            // 
            // 
            // 
            // 
            this.txtLote.Border.Class = "TextBoxBorder";
            this.txtLote.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(627, 140);
            this.txtLote.MaxLength = 13;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(67, 22);
            this.txtLote.TabIndex = 92;
            this.txtLote.Text = "ND";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(556, 126);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(34, 13);
            this.Label5.TabIndex = 100;
            this.Label5.Text = "Costo";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(713, 124);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 13);
            this.Label4.TabIndex = 99;
            this.Label4.Text = "Vence";
            // 
            // txtCosto
            // 
            // 
            // 
            // 
            this.txtCosto.Border.Class = "TextBoxBorder";
            this.txtCosto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(548, 140);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(73, 22);
            this.txtCosto.TabIndex = 98;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(406, 124);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 13);
            this.Label3.TabIndex = 97;
            this.Label3.Text = "Cantidad";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(183, 124);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 96;
            this.Label2.Text = "Descripcion";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(29, 124);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 13);
            this.Label1.TabIndex = 95;
            this.Label1.Text = "Articulo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Location = new System.Drawing.Point(837, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(46, 23);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 93;
            this.btnGuardar.Text = "Guardar";
            // 
            // txtCantidad
            // 
            // 
            // 
            // 
            this.txtCantidad.Border.Class = "TextBoxBorder";
            this.txtCantidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(400, 140);
            this.txtCantidad.MaxLength = 12;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(67, 22);
            this.txtCantidad.TabIndex = 91;
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.Border.Class = "TextBoxBorder";
            this.txtDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(119, 140);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(275, 22);
            this.txtDescripcion.TabIndex = 94;
            // 
            // txtArticulo
            // 
            // 
            // 
            // 
            this.txtArticulo.Border.Class = "TextBoxBorder";
            this.txtArticulo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.Location = new System.Drawing.Point(4, 140);
            this.txtArticulo.MaxLength = 20;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(110, 22);
            this.txtArticulo.TabIndex = 90;
            // 
            // frmPaquetesDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 597);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.ToolStrip2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtArticulo);
            this.Name = "frmPaquetesDetalle";
            this.Text = "frmPaquetesDetalle";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbTipo;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblTotalTras;
        internal System.Windows.Forms.Label Label11;
        private DevComponents.DotNetBar.ButtonX btnELiminar;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNotas;
        internal System.Windows.Forms.Label Label9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrecio;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDocumento;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripButton btnSave;
        internal System.Windows.Forms.ToolStripButton btnRecibir;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btnCerrar;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvDatos;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Vence;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Total;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        internal System.Windows.Forms.Label Label6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLote;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCosto;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        public DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCantidad;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescripcion;
        public DevComponents.DotNetBar.Controls.TextBoxX txtArticulo;

    }
}