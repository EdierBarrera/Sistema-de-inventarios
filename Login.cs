using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

using CapaPrecentacion;
using SiCapaPrecentacion;

namespace CapaPrecentacion
{ 
    public partial class Login : Form
    {
     public Login()
     {
        InitializeComponent();
     }

      private void Login_Load(object sender, EventArgs e)
      {

      }

      private void btncancelar_Click(object sender, EventArgs e)
      {
            /*esto crierra el formulario login*/
       this.Close();
      }

      private void btningresar_Click(object sender, EventArgs     e)
      {
            /*esto oculta el formulario de login y abre el form inicio, y al serrar el form imicio se vuelve a mostrar el login*/

         List<Usuario> TEST = new CNusuario().Listar();
         Usuario ousuario = new CNusuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();
            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing; // llamada al evento de cierre
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
       }
      private void frm_closing(object sender, EventArgs   e) // evento de cierre
      {
           txtdocumento.Text = "";
            txtclave.Text = "";
          this.Show();
      }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /* hasta aqui*/

    }
}
