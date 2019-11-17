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

namespace FrontEnd
{
    public partial class AdmUsuarios : Form
    {
        FuncionesDB fdb = new FuncionesDB();
        Usuario Usuario;
        public AdmUsuarios(Usuario Usuario)
        {
            this.Usuario = Usuario;
            InitializeComponent();
        }

        private void AdmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void AdmUsuarios_Load(object sender, EventArgs e)
        {
            dgvColaboradores.DataSource = fdb.ConsultaGerentes(Usuario);
            dgvUsuarios.DataSource = fdb.ConsultaUsuarios(Usuario);
        }

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

        private void dgvColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dgvColaboradores.CurrentRow.Cells[0].Value.ToString();
        }

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

        private void btExportar_Click(object sender, EventArgs e)
        {
            fdb.registrarEvento(Usuario.ID_Usuario, 0, 7);
            fdb.ExportarExcel();
        }
    }
}
