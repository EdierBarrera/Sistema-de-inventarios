namespace SiCapaPrecentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.menuajustes = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuVenta = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuRegistarcompra = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerdetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.menuajustes,
            this.menuventas,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menureportes,
            this.menuacercade});
            this.Menu.Location = new System.Drawing.Point(0, 28);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 5);
            this.Menu.Size = new System.Drawing.Size(839, 74);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.IconSize = 50;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(122, 69);
            this.menuusuario.Text = "Usuarios";
            this.menuusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click);
            // 
            // menuajustes
            // 
            this.menuajustes.AutoSize = false;
            this.menuajustes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCategoria,
            this.SubMenuProducto});
            this.menuajustes.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuajustes.IconColor = System.Drawing.Color.Black;
            this.menuajustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuajustes.IconSize = 50;
            this.menuajustes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuajustes.Name = "menuajustes";
            this.menuajustes.Size = new System.Drawing.Size(80, 69);
            this.menuajustes.Text = "Ajustes";
            this.menuajustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuCategoria
            // 
            this.SubMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuCategoria.IconColor = System.Drawing.Color.Black;
            this.SubMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuCategoria.Name = "SubMenuCategoria";
            this.SubMenuCategoria.Size = new System.Drawing.Size(180, 22);
            this.SubMenuCategoria.Text = "Categoria";
            this.SubMenuCategoria.Click += new System.EventHandler(this.SubMenuCategoria_Click);
            // 
            // SubMenuProducto
            // 
            this.SubMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuProducto.IconColor = System.Drawing.Color.Black;
            this.SubMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuProducto.Name = "SubMenuProducto";
            this.SubMenuProducto.Size = new System.Drawing.Size(180, 22);
            this.SubMenuProducto.Text = "Producto";
            this.SubMenuProducto.Click += new System.EventHandler(this.SubMenuProducto_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuVenta,
            this.SubMenuDetalleVenta});
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 50;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(80, 69);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuVenta
            // 
            this.SubmenuVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuVenta.IconColor = System.Drawing.Color.Black;
            this.SubmenuVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuVenta.Name = "SubmenuVenta";
            this.SubmenuVenta.Size = new System.Drawing.Size(128, 22);
            this.SubmenuVenta.Text = "Registar";
            this.SubmenuVenta.Click += new System.EventHandler(this.SubmenuVenta_Click);
            // 
            // SubMenuDetalleVenta
            // 
            this.SubMenuDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.SubMenuDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuDetalleVenta.Name = "SubMenuDetalleVenta";
            this.SubMenuDetalleVenta.Size = new System.Drawing.Size(128, 22);
            this.SubMenuDetalleVenta.Text = "Ver detalle";
            this.SubMenuDetalleVenta.Click += new System.EventHandler(this.SubMenuDetalleVenta_Click);
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistarcompra,
            this.SubMenuVerdetalleCompra});
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.IconSize = 50;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(122, 69);
            this.menucompras.Text = "Compras";
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuRegistarcompra
            // 
            this.SubMenuRegistarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRegistarcompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuRegistarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRegistarcompra.Name = "SubMenuRegistarcompra";
            this.SubMenuRegistarcompra.Size = new System.Drawing.Size(162, 22);
            this.SubMenuRegistarcompra.Text = "Registar Compra";
            this.SubMenuRegistarcompra.Click += new System.EventHandler(this.SubMenuRegistarventa_Click);
            // 
            // SubMenuVerdetalleCompra
            // 
            this.SubMenuVerdetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerdetalleCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerdetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerdetalleCompra.Name = "SubMenuVerdetalleCompra";
            this.SubMenuVerdetalleCompra.Size = new System.Drawing.Size(162, 22);
            this.SubMenuVerdetalleCompra.Text = "Ver detalle";
            this.SubMenuVerdetalleCompra.Click += new System.EventHandler(this.SubMenuVerdetalleCompra_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 50;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(80, 69);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 50;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(122, 69);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedor_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 50;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(122, 69);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.IconSize = 50;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(80, 69);
            this.menuacercade.Text = "Acerda de";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuacercade.Click += new System.EventHandler(this.menuacercade_Click);
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.SkyBlue;
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(839, 28);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            this.MenuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuTitulo_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "STOCK MASTER";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 102);
            this.Contenedor.MinimumSize = new System.Drawing.Size(100, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(839, 352);
            this.Contenedor.TabIndex = 3;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.SkyBlue;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(626, 9);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(57, 16);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.SkyBlue;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(676, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(67, 16);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "lblnombre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Location = new System.Drawing.Point(0, 436);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(839, 18);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 454);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menuajustes;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblnombre;
        private FontAwesome.Sharp.IconMenuItem SubMenuCategoria;
        private FontAwesome.Sharp.IconMenuItem SubMenuProducto;
        private FontAwesome.Sharp.IconMenuItem SubmenuVenta;
        private FontAwesome.Sharp.IconMenuItem SubMenuDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistarcompra;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerdetalleCompra;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

