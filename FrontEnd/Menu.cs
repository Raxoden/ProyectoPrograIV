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
        /*Variables:
         * fdb = Es la isntacia de FuncionesDB para utilizar sus metodos.
         * AdmColaboradores/AdmUsuarios = Son las instancias de los formularios para administrar a los colaboradores
         *                      y los usuarios para poder controlar su funcionamiento.
         * BackEnd.Usuario = es el objeto que utilizaremos para administrar la información básica del operador.
         */
        FuncionesDB fdb = new FuncionesDB();
        AdmColaboradores ac;
        AdmUsuarios au;
        BackEnd.Usuario Usuario;
        public Menu(int ID_Usuario)
        {
            //Se consigue la informacion del usuario
            Usuario = fdb.BusquedaUsuario(ID_Usuario);
            ac = new AdmColaboradores(Usuario);
            au = new AdmUsuarios(Usuario);
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Se llenan los campos con los datos del usuario actual.
            lbUsuario.Text = "Usuario: " + Usuario.Nombre;
            lbID.Text = "ID: " + Usuario.ID_Colaborador;
            lbArea.Text = "Area: " + Usuario.Desc_Area;
            lbPuesto.Text = "Puesto: " + Usuario.Desc_Puesto;
            //se determina si tiene privilegios para poder administrar a los usuarios o no.
            if (Usuario.Privilegios)
            {
                tsUsuario.Visible = true;
                tsUsuario.Enabled = true;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se verifica si el formulario ya esta visible para mostrarlo o no.
            if (!au.Visible)
            {
                au.Visible = true;
            }
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se verifica si el formulario ya esta visible para mostrarlo o no.
            if (!ac.Visible)
            {
                ac.Visible = true;
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Condicion que si el usuario acepta se terminara el programa en el momento.
            if (MessageBox.Show("Si cierra esta ventana cerrara el programa", "Aviso!", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                //si se sale del cuadro de dialogo sin indicar que acepta se cancela el cierre y se sigue ejecutando la aplicacion
                e.Cancel = true;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Al cerrarse el formulario se cierran todas las ventanas y se marca la salida del usuario
            au.Dispose();
            ac.Dispose();
            fdb.registrarSalida(Usuario.ID_Usuario);
            Application.Exit();
        }
    }
}
