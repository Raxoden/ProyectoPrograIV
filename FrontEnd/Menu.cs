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
        BackEnd.Colaborador Usuario;
        public Menu(int ID_Usuario)
        {
            Usuario = fdb.Busqueda(ID_Usuario);
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = "Usuario: " + Usuario.Nombre;
            lbID.Text = "ID: " + Usuario.ID_Colaborador;
            lbArea.Text = "Area: " + Usuario.Desc_Area;
            lbPuesto.Text = "Puesto: " + Usuario.Desc_Puesto;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmUsuarios au = new AdmUsuarios();
            au.Show();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmUsuarios ac = new AdmUsuarios();
            ac.Show();
        }
    }
}
