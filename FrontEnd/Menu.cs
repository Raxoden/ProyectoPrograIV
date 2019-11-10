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
using DataBase;

namespace FrontEnd
{
    public partial class Menu : Form
    {
        FuncionesDB fdb = new FuncionesDB();

        public Menu(int ID_Usuario)
        {

            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = fdb.Consulta();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario formusuario = new FormUsuario();
            formusuario.Show();
        }
    }
}
