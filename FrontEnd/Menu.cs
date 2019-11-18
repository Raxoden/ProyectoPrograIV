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
    /// <summary>
    /// Formulario en el que se muestra la informacion del usuario y se accede a los formularios de administracion.
    /// Si se cierra este formulario se cerrara todo el programa.
    /// </summary>
    public partial class Menu : Form
    {
        /// <summary>
        /// fdb = es la variable utilizada para instancia la clase de funciones.
        /// ac = La variable utilizada para el formulario AdmColaboradores.
        /// au = La variable utilizada para el formulario AmdUsuarios.
        /// Usuario = Variable para manipular y mostrar la informacion del usuario.
        /// </summary>
        FuncionesDB fdb = new FuncionesDB();
        AdmColaboradores ac;
        Administración au;
        BackEnd.Usuario Usuario;

        /// <summary>
        /// En el constructor se crean las intancias de los formularios usuarios y colaboradores.
        /// Tambien se obtiene y se define la variable para manipular la informacion del usuario.
        /// </summary>
        /// <param name="ID_Usuario">Se recibe el ID del usuario que ingreso para obtener su informacion.</param>
        public Menu(int ID_Usuario)
        {
            Usuario = fdb.BusquedaUsuario(ID_Usuario);
            ac = new AdmColaboradores(Usuario);
            au = new Administración(Usuario);
            InitializeComponent();
        }

        /// <summary>
        /// Al cargar el formulario se muestra la informacion obtenida del usuario.
        /// Muestra el acceso para usuarios si se tienen privilegios.
        /// </summary>
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

        /// <summary>
        /// Si el formulario no esta visible se muestra.
        /// Si esta visible se oculta.
        /// </summary>
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!au.Visible)
            {
                au.Visible = true;
            }
        }

        /// <summary>
        /// Si el formulario no esta visible se muestra.
        /// Si esta visible se oculta.
        /// </summary>
        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ac.Visible)
            {
                ac.Visible = true;
            }
        }

        /// <summary>
        /// Al tratar de cerrar el formulario se le muestra una advertencia.
        /// </summary>
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Si cierra esta ventana cerrara el programa", "Aviso!", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Al cerrarse el formulario se registra la salida del usuario.
        /// </summary>
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            au.Dispose();
            ac.Dispose();
            fdb.registrarSalida(Usuario.ID_Usuario);
            Application.Exit();
        }

        private void lineShape4_Click(object sender, EventArgs e)
        {

        }

        private void lbPuesto_Click(object sender, EventArgs e)
        {

        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
