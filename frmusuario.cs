using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPrecentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using SistemaVentas.Properties;
using System.Windows.Media;
using System.Security.Cryptography;
using System.Runtime.Remoting.Messaging;



namespace CapaPrecentacion
{
    public partial class frmusuario : Form
    {
        public frmusuario()
        {
            InitializeComponent();
        }


        private void frmusuario_Load(object sender, EventArgs e) // esto es el desplegable de estado
        {
            // TODO: esta línea de código carga datos en la tabla 'bDSISTEMA_DE_VENTASDataSet.ROL' Puede moverla o quitarla según sea necesario.
            this.rOLTableAdapter.Fill(this.bDSISTEMA_DE_VENTASDataSet.ROL);
            cboestado.Items.Add(new Opcioncombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new Opcioncombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto"; //esto seleciona lo que esta en el texto
            cboestado.ValueMember = "Valor"; // esto no lo muesta lo maneja interno
            cboestado.SelectedIndex = 0; // esto siemptre seleciona el valor peimero
            // asta aqui
            /*este metodo lista todos l.os roles que estan en el combobox*/

            List<Rol> ListaRol = new CN_Rol().Listar();

            foreach (Rol item in ListaRol)
            {
                cborol.Items.Add(new Opcioncombo() { Valor = item.IdRol, Texto = item.Descripcion });

            }
            cborol.DisplayMember = "Texto"; //esto seleciona lo que esta en el texto
            cborol.ValueMember = "valor"; // esto no lo muesta lo maneja interno
            cborol.SelectedIndex = 0; // esto siemptre seleciona el valor peimero
            //asta aqui

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnselecionar")
                {
                    cbobusqueda.Items.Add(new Opcioncombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto"; //esto seleciona lo que esta en el texto
            cbobusqueda.ValueMember = "valor"; // esto no lo muesta lo maneja interno
            cbobusqueda.SelectedIndex = 0; // esto siemptre seleciona el valor peimero


            // este solo me muestra los el ID de cada estado mas no la desacripcion.
            //Mostar todos los usuarios con el siguiente codigo

            List<Usuario> ListaUsuario = new CNusuario().Listar();

            foreach (Usuario item in ListaUsuario)
            {
                dgvdata.Rows.Add(new object[] { "", item.IdUsuario,item.Documento, item.NombreCompleto,item.Correo,item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"


            });

            }


            // Este funciona a medias solo me muestar el estado mas no el rol
            //Mostar todos los usuarios con el siguiente codigo
            //List<Usuario> ListaUsuario = new CNusuario().Listar();
            //string tmpEstado = "";
            //foreach (Usuario item in ListaUsuario)
            //{
            //    tmpEstado = (item.Estado) ? "Activo" : "No Activo";

            //    dgvdata.Rows.Add(new object[] { "", item.IdUsuario,item.Documento, item.NombreCompleto,item.Correo,item.Clave,txtclave,
            //item.oRol.IdRol,
            //item.oRol.Descripcion,
            //tmpEstado});

            //}



            //        // segunda prueba 

            //// Obtener la lista de usuarios
            //List<Usuario> ListaUsuario = new CNusuario().Listar();

            //// Recorrer la lista de usuarios
            //foreach (Usuario usuario in ListaUsuario)
            //{
            //    // Obtener la descripción del estado para este usuario
            //    string descripcionEstado = usuario.Estado ? "Activo" : "No Activo";

            //    // Obtener la descripción del rol para este usuario
            //    string descripcionRol = usuario.oRol.Descripcion;

            //    // Agregar el usuario al DataGridView
            //    dgvdata.Rows.Add(new object[] {
            //    "",
            //    usuario.IdUsuario,
            //    usuario.Documento,
            //    usuario.NombreCompleto,
            //    usuario.Correo,
            //    usuario.Clave,
            //    usuario.Estado,descripcionRol ,// Utiliza la descripción del rol en lugar del ID
            //    usuario.Estado, descripcionEstado, //Utiliza la descripción del estado en lugar del valor booleano

            //});
            //}
            //        // hasta aqui



        }

        private void btnguardar_Click(object sender, EventArgs e)

        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Clave = txtclave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((Opcioncombo)cborol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((Opcioncombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            int idusuariogenerado = new CNusuario().Registrar(objusuario, out mensaje);

            if (idusuariogenerado != 0)// para poder registra datos en el datagrid el id del usuario deve ser diferente de 0
            {
                // ESTE CODIGO AGREGA DATOS Y FILAS A UN  DATAGRID

                dgvdata.Rows.Add(new object[] { "", txtid.Text,txtdocumento.Text,txtnombrecompleto.Text,txtcorreo.Text,txtclave.Text,
             ((Opcioncombo)cborol.SelectedItem).Valor.ToString(),
             ((Opcioncombo)cborol.SelectedItem).Texto.ToString(),
             ((Opcioncombo)cboestado.SelectedItem).Valor.ToString(),
             ((Opcioncombo)cboestado.SelectedItem).Texto.ToString()
             });

                limpiar();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            

        }
        /*metodo para limpiar los texbox*/
        private void limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfirmarclave.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

        }

        // ponerle un color a una celda
        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 1) //Verifica si la columna es mayor o igual a 1 (excluyendo la primera columna)
                return;
            {
                if (e.ColumnIndex <= 0) // Verifica si no es la primera columna (índice 0)
                {
                    // Define el color que deseas para las celdas (por ejemplo, azul)
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);// Pintar la celda normalmente antes de aplicar el color
                    System.Drawing.Color colorCelda = System.Drawing.Color.Blue;
                    // Aplica el color de fondo a la celda
                    e.CellStyle.BackColor = colorCelda;


                }
            }
        }


        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;
                if (indice >= 0)
                    txtindice.Text= indice.ToString();
                {
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtdocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtnombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txtconfirmarclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (Opcioncombo oc in cborol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cborol.Items.IndexOf(oc);
                            cborol.SelectedIndex = indice_combo;
                            break;
                        }


                        foreach (Opcioncombo Oc in cboestado.Items)

                        {

                            if (Convert.ToInt32(Oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                            {
                                int indice_combo = cboestado.Items.IndexOf(Oc);
                                cboestado.SelectedIndex = indice_combo;
                                break;
                            }
                        }
                    }

                }

            }

        }
       


    }
}

       
    
