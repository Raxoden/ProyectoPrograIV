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
    public partial class AdmColaboradores : Form
    {
        FuncionesDB fdb = new FuncionesDB();
        Usuario Usuario;
        public AdmColaboradores(Usuario Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }
        
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
                    MessageBox.Show("El colaborador se elimino correctamente.");
                    dgvColaboradores.DataSource = fdb.ConsultaColaboradores(Usuario);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar al colaborador.");
                }
            }
        }
    }
}