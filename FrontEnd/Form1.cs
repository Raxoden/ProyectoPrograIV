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

        /*
         * Función Validacion, comprueba que los campos necesarios no esten vacios.
         */
        public bool Validacion()
        {
            if (String.IsNullOrEmpty(tbUsuario.Text) || String.IsNullOrEmpty(tbContrasenna.Text))
            {
                return false;
            } else
            {
                return true;
            }
        }

        /*
         * Funcion del boton para realizar la validacion de usuario en la base de datos.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion())// Se manda a verificar los campos para recibir true or false.
            {
                FuncionesDB fdb = new FuncionesDB();//Se instancia la clase FuncionesDB para acceder a sus metodos y funciones.
                if (fdb.Validacion(Convert.ToInt32(tbUsuario.Text), tbContrasenna.Text.Normalize()))//se mandan los datos del usuario a la funcion Validacion de la clase FuncionesDB.
                {
                    //Si se recibe la confirmacion de que el usuario es correcto se crea la instancia de Menu y se muestra.
                    Menu m = new Menu(Convert.ToInt32(tbUsuario.Text));
                    m.Show();
                    this.Visible = false;//se oculta la ventana principal de login para evitar que se cierre la aplicacion
                }
                else
                {
                    //Si se recibe un error se indica que los datos son incorrectos.
                    MessageBox.Show("Los datos ingresados son incorrectos.");
                }
            } else
            {
                //si se encuentra algun espacio vacio se indicara que deberan llenarse.
                MessageBox.Show("Debe llenar todos los campos.");
            }
            
        }

        /*
        *Se utiliza el evento de escritura en el TextBoxUsuario para verificar que solo se ingresen numeros.
        */
        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se verifica que solo se ingresen numeros y se llegue a un largo de 9, ademas de permitir borrar lo escrito.
            if ((Char.IsDigit(e.KeyChar) && tbUsuario.Text.Length <= 8) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

    }
}
