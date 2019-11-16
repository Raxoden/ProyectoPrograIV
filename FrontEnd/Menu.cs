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
        AdmColaboradores ac;
        AdmUsuarios au;
        BackEnd.Usuario Usuario;
        public Menu(int ID_Usuario)
        {
            Usuario = fdb.BusquedaUsuario(ID_Usuario);
            ac = new AdmColaboradores(Usuario);
            au = new AdmUsuarios(Usuario);
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
            if (!au.Visible)
            {
                au.Visible = true;
            }
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ac.Visible)
            {
                ac.Visible = true;
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Si cierra esta ventana cerrara el programa", "Aviso!", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            au.Dispose();
            ac.Dispose();
            fdb.registrarSalida(Usuario.ID_Usuario);
            Application.Exit();
        }
    }
}
