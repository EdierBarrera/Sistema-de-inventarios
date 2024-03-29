using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPrecentacion;
using FontAwesome.Sharp;


namespace SiCapaPrecentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form formularioActivo = null;

        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in Menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            lblnombre.Text = usuarioActual.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem Menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            Menu.BackColor = Color.Azure;
            MenuActivo = Menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;


            // Centra el formulario en la pantalla
            formulario.StartPosition = FormStartPosition.CenterScreen;

            formulario.BackColor = Color.SteelBlue;

            // Muestra el formulario secundario como modal
            formulario.ShowDialog();

            // Después de cerrar el formulario secundario, establece formularioActivo en null
            formularioActivo = null;
        }

        // Event handlers para abrir los formularios de menú
        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmusuario());
        }

        private void SubMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuajustes, new frmcategoria());
        }

        private void SubMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuajustes, new frmproducto());
        }

        private void SubmenuVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmventas());
        }

        private void SubMenuDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmdetalleventas());
        }

        private void SubMenuRegistarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmcompras());
        }

        private void SubMenuVerdetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmdetallecompras());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuclientes, new frmclientes());
        }

        private void menuproveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuproveedores, new frmproveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menureportes, new frmreportes());
        }

        private void MenuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuacercade, new frmacercade());
        }
    }
}