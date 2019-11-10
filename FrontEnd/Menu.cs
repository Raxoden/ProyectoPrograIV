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
            using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
            {
                var query = from C in PE.Colaborador
                            join A in PE.Area on C.ID_Area equals A.ID_Area
                            join P in PE.Puesto on C.ID_Puesto equals P.ID_Puesto
                            select new BackEnd.Colaborador
                            {
                                ID_Colaborador = C.ID_Colaborador,
                                Nombre = C.Nombre,
                                Genero = Convert.ToChar(C.Genero),
                                Edad = Convert.ToInt32(C.Edad),
                                Fecha_Nacimiento = Convert.ToDateTime(C.Fecha_Nacimiento),
                                Fecha_Ingreso = Convert.ToDateTime(C.Fecha_Ingreso),
                                Desc_Puesto = P.Descripcion,
                                Desc_Area = A.Descripcion
                            };
                dgvDatos.DataSource = query.ToList();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario formusuario = new FormUsuario();
            formusuario.Show();
        }
    }
}
