namespace SistemaFacturacion
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoClasificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClasificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasYEntradasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.btnCerrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clasificacionesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.inventarioToolStripMenuItem.Text = "Mantenimientos";
            // 
            // clasificacionesToolStripMenuItem
            // 
            this.clasificacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoClasificacionesToolStripMenuItem,
            this.crearClasificacionesToolStripMenuItem,
            this.impuestosToolStripMenuItem,
            this.tiposDeProductosToolStripMenuItem,
            this.unidadDeMedidaToolStripMenuItem,
            this.itemsToolStripMenuItem});
            this.clasificacionesToolStripMenuItem.Name = "clasificacionesToolStripMenuItem";
            this.clasificacionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clasificacionesToolStripMenuItem.Text = "Productos";
            // 
            // tipoClasificacionesToolStripMenuItem
            // 
            this.tipoClasificacionesToolStripMenuItem.Name = "tipoClasificacionesToolStripMenuItem";
            this.tipoClasificacionesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tipoClasificacionesToolStripMenuItem.Text = "Nombre Clasificaciones";
            this.tipoClasificacionesToolStripMenuItem.Click += new System.EventHandler(this.tipoClasificacionesToolStripMenuItem_Click);
            // 
            // crearClasificacionesToolStripMenuItem
            // 
            this.crearClasificacionesToolStripMenuItem.Name = "crearClasificacionesToolStripMenuItem";
            this.crearClasificacionesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.crearClasificacionesToolStripMenuItem.Text = "Clasificaciones";
            this.crearClasificacionesToolStripMenuItem.Click += new System.EventHandler(this.crearClasificacionesToolStripMenuItem_Click);
            // 
            // impuestosToolStripMenuItem
            // 
            this.impuestosToolStripMenuItem.Name = "impuestosToolStripMenuItem";
            this.impuestosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.impuestosToolStripMenuItem.Text = "Impuestos";
            this.impuestosToolStripMenuItem.Click += new System.EventHandler(this.impuestosToolStripMenuItem_Click);
            // 
            // tiposDeProductosToolStripMenuItem
            // 
            this.tiposDeProductosToolStripMenuItem.Name = "tiposDeProductosToolStripMenuItem";
            this.tiposDeProductosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tiposDeProductosToolStripMenuItem.Text = "Tipos de productos";
            this.tiposDeProductosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeProductosToolStripMenuItem_Click);
            // 
            // unidadDeMedidaToolStripMenuItem
            // 
            this.unidadDeMedidaToolStripMenuItem.Name = "unidadDeMedidaToolStripMenuItem";
            this.unidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.unidadDeMedidaToolStripMenuItem.Text = "Unidad de Medida";
            this.unidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.itemsToolStripMenuItem.Text = "Listado de productos";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.existenciasToolStripMenuItem,
            this.salidasYEntradasDeInventarioToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.facturacionToolStripMenuItem.Text = "Inventario";
            // 
            // existenciasToolStripMenuItem
            // 
            this.existenciasToolStripMenuItem.Name = "existenciasToolStripMenuItem";
            this.existenciasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.existenciasToolStripMenuItem.Text = "Existencias";
            this.existenciasToolStripMenuItem.Click += new System.EventHandler(this.existenciasToolStripMenuItem_Click);
            // 
            // salidasYEntradasDeInventarioToolStripMenuItem
            // 
            this.salidasYEntradasDeInventarioToolStripMenuItem.Name = "salidasYEntradasDeInventarioToolStripMenuItem";
            this.salidasYEntradasDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.salidasYEntradasDeInventarioToolStripMenuItem.Text = "Salidas y entradas de inventario";
            this.salidasYEntradasDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.salidasYEntradasDeInventarioToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrar.Image = global::SistemaFacturacion.Properties.Resources.Exit16x16;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 20);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaFacturacion.Properties.Resources.agro;
            this.ClientSize = new System.Drawing.Size(813, 403);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearClasificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripMenuItem impuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoClasificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasYEntradasDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}