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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionesDB fdb = new FuncionesDB();
            if (fdb.Validacion(Convert.ToInt32(tbUsuario.Text), tbContrasenna.Text.Normalize()))
            {
                Menu m = new Menu(Convert.ToInt32(tbUsuario.Text));
                m.Show();
            } else
            {
                MessageBox.Show("Los datos ingresados son incorrectos.");
            }
        }
    }
}
