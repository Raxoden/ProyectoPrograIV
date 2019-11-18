using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;
using System.Runtime.InteropServices;


namespace FrontEnd
{
    public partial class AdmUsuarios : Form
    {
        /**
         * fdb = es la variable para instanciar a las funciones de la aplicacion.
         * Usuario = la variable para obtener y modificar la informacion del usuario.
         */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        FuncionesDB fdb = new FuncionesDB();
        Usuario Usuario;
        Form menu;
        /// <summary>
        /// En el constructor se asigna la informacion a un usuario.
        /// </summary>
        /// <param name="Usuario">Se obtiene el usuario.</param>
        public AdmUsuarios(Usuario Usuario, Form Men)
        {
            menu = Men;
            this.Usuario = Usuario;
            InitializeComponent();
        }

        //Al cerrar el formulario solo se hace invisible.
        private void AdmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        //Carga la informacion a los data grid views.
        private void AdmUsuarios_Load(object sender, EventArgs e)
        {
            dgvColaboradores.DataSource = fdb.ConsultaGerentes();
            dgvUsuarios.DataSource = fdb.ConsultaUsuarios(Usuario);
        }

        //Obtiene la informacion del usuario clicado.
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbId.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                if (Convert.ToBoolean(dgvUsuarios.CurrentRow.Cells[4].Value))
                {
                    cbPrivilegio.Checked = true;
                }
                else
                {
                    cbPrivilegio.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        //Comprueba que todos los campos esten llenos.
        public bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(tbId.Text) || String.IsNullOrEmpty(tbContrasenna.Text) || String.IsNullOrEmpty(tbConfirmar.Text))
            {
                MessageBox.Show("Todos los espacios deben ser llenados.");
                return false;
            }
            else
            {
                if (!tbContrasenna.Text.Equals(tbConfirmar.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        //Manda el id del colaborador para crear un nuevo usuario.
        private void btCrear_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                if (fdb.BusquedaColaborador(Convert.ToInt32(tbId.Text)) == null)
                {
                    MessageBox.Show("Este colaborador no existe!");
                }
                else
                {
                    if (fdb.RegistrarUsuario(Convert.ToInt32(tbId.Text),tbContrasenna.Text,cbPrivilegio.Checked))
                    {
                        fdb.registrarEvento(Usuario.ID_Usuario, Convert.ToInt32(tbId.Text), 4);
                        MessageBox.Show("Se registro exitosamente.");
                        dgvUsuarios.DataSource = fdb.ConsultaUsuarios(Usuario);

                    } else
                    {
                        MessageBox.Show("Hubo un error al registrar el usuario.");
                    }
                }
            }
        }

        //Modifica el usuario con la inforamcion dada.
        private void btModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (fdb.ActualizarUsuario(Convert.ToInt32(tbId.Text), tbContrasenna.Text, cbPrivilegio.Checked))
                {
                    fdb.registrarEvento(Usuario.ID_Usuario, Convert.ToInt32(tbId.Text), 5);
                    MessageBox.Show("Se modifico correctamente.");
                    dgvUsuarios.DataSource = fdb.ConsultaUsuarios(Usuario);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar.");
                }
            }
        }

        //Manda el id del usuario que desea eliminar.
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("Debe ingresar un ID para eliminar un usuario.");
            }else {
                if (fdb.EliminarUsuario(Convert.ToInt32(tbId.Text)))
                {
                    fdb.registrarEvento(Usuario.ID_Usuario, Convert.ToInt32(tbId.Text), 6);
                    MessageBox.Show("Se elimino correctamente.");
                    dgvUsuarios.DataSource = fdb.ConsultaUsuarios(Usuario);
                } else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
        }

        //Inserta el id del colaborador para poder crear, modificar o eliminar un usuario.
        private void dgvColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgvColaboradores.CurrentRow.Cells[0].Value.ToString();
        }

        //Evita que se digiten letras y solo permite numeros y borrar.
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) && tbId.Text.Length <= 8) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Exporta la informacion a un excel.
        private void btExportar_Click(object sender, EventArgs e)
        {
            fdb.registrarEvento(Usuario.ID_Usuario, 0, 7);
            fdb.ExportarExcel();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("aqui va el manual");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
