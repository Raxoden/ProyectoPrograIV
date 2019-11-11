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
        BackEnd.Usuario Usuario;
        public Menu(int ID_Usuario)
        {
            Usuario = fdb.BusquedaUsuario(ID_Usuario);
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = "Usuario: " + Usuario.Nombre;
            lbID.Text = "ID: " + Usuario.ID_Colaborador;
            lbArea.Text = "Area: " + Usuario.Desc_Area;
            lbPuesto.Text = "Puesto: " + Usuario.Desc_Puesto;
            if (Usuario.Privilegios)
            {
                tsUsuario.Visible = true;
                tsUsuario.Enabled = true;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmUsuarios au = new AdmUsuarios(Usuario);
            if (!au.Visible)
            {
                au.Show();
            }
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmColaboradores ac = new AdmColaboradores(Usuario);
            if (!ac.Visible)
            {
                ac.Show();
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
