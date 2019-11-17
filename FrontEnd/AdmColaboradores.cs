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
    public partial class AdmColaboradores : Form
    {

        FuncionesDB fdb = new FuncionesDB();
        Usuario Usuario;
        public AdmColaboradores(Usuario Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void AdmColaboradores_Load(object sender, EventArgs e)
        {
            dgvColaboradores.DataSource = fdb.ConsultaColaboradores(Usuario);
            cbArea.DataSource = fdb.BusquedaArea(Usuario);
            cbGenero.DataSource = fdb.BusquedaGenero();
            dtpIngreso.MaxDate = System.DateTime.Now;
            dtpNacimiento.MaxDate = System.DateTime.Now.AddYears(-18);
            dtpIngreso.MinDate = System.DateTime.Now.AddYears(-100);
            dtpNacimiento.MinDate = System.DateTime.Now.AddYears(-100);
        }

        public bool Validacion()
        {
            if (String.IsNullOrEmpty(tbID.Text) || String.IsNullOrEmpty(tbNombre.Text) || String.IsNullOrEmpty(tbEdad.Text))
            {
                return false;
            } else
            {
                return true;
            }
        }

        private void AdmColaboradores_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                if (fdb.RegistrarColaborador(Convert.ToInt32(tbID.Text), tbNombre.Text, cbGenero.Text, Convert.ToInt32(tbEdad.Text), dtpNacimiento.Value, dtpIngreso.Value, cbPuesto.Text, cbArea.Text))
                {
                    fdb.registrarEvento(Usuario.ID_Usuario, Convert.ToInt32(tbID.Text), 1);
                    dgvColaboradores.DataSource = fdb.ConsultaColaboradores(Usuario);
                    MessageBox.Show("El colaborador se registro exitosamente.");
                } else
                {
                    MessageBox.Show("Hubo un error al registrar el colaborador.");
                }
                
            } else
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPuesto.DataSource = fdb.BusquedaPuesto(cbArea.Text);
        }

        private void cbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) && tbEdad.Text.Length < 2) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar) && tbID.Text.Length <= 8) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Space) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                if (fdb.ActualizarColaborador(Convert.ToInt32(tbID.Text), tbNombre.Text, cbGenero.Text, Convert.ToInt32(tbEdad.Text), dtpNacimiento.Value, dtpIngreso.Value, cbPuesto.Text, cbArea.Text))
                {
                    fdb.registrarEvento(Usuario.ID_Usuario, Convert.ToInt32(tbID.Text), 2);
                    dgvColaboradores.DataSource = fdb.ConsultaColaboradores(Usuario);
                    MessageBox.Show("El colaborador se actualizo exitosamente.");
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el colaborador.");
                }

            }
            else
            {
                MessageBox.Show("Debe de llenar todos los campos");
            }
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Debe ingresar un ID para eliminar un usuario.");
            }
            else
            {
                if (fdb.EliminarColaborador(Convert.ToInt32(tbID.Text)))
                {
                    fdb.registrarEvento(Usuario.ID_Usuario, Convert.ToInt32(tbID.Text), 3);
                    MessageBox.Show("El colaborador se elimino correctamente.");
                    dgvColaboradores.DataSource = fdb.ConsultaColaboradores(Usuario);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar al colaborador.");
                }
            }
        }
        private void dgvColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dgvColaboradores.CurrentRow.Cells[0].Value.ToString();
            tbNombre.Text = dgvColaboradores.CurrentRow.Cells[1].Value.ToString();
            cbGenero.Text = dgvColaboradores.CurrentRow.Cells[2].Value.ToString();
            tbEdad.Text = dgvColaboradores.CurrentRow.Cells[3].Value.ToString();
            dtpNacimiento.Value = Convert.ToDateTime(dgvColaboradores.CurrentRow.Cells[4].Value);
            dtpIngreso.Value = Convert.ToDateTime(dgvColaboradores.CurrentRow.Cells[5].Value);
            cbArea.Text = dgvColaboradores.CurrentRow.Cells[7].Value.ToString();
            cbPuesto.Text = dgvColaboradores.CurrentRow.Cells[6].Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}