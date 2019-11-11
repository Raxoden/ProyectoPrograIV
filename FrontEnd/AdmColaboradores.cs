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
            this.Usuario = Usuario;
            InitializeComponent();
        }

        private void AdmColaboradores_Load(object sender, EventArgs e)
        {
            dgvColaboradores.DataSource = fdb.ConsultaColaboradores(Usuario);
            String.Format("yyyy/MM/dd", dtpIngreso);
            String.Format("yyyy/MM/dd", dtpNacimiento);
        }

        private void AdmColaboradores_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}