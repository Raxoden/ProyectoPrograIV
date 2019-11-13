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
            InitializeComponent();
            this.Usuario = Usuario;
            cbArea.DataSource = fdb.BusquedaArea(this.Usuario);

        }
        
        private void AdmColaboradores_Load(object sender, EventArgs e)
        {
            dgvColaboradores.DataSource = fdb.ConsultaColaboradores(Usuario);
            dtpIngreso.MaxDate = System.DateTime.Now;
            dtpNacimiento.MaxDate = System.DateTime.Now.AddYears(-18);
            dtpIngreso.MinDate = System.DateTime.Now.AddYears(-100);
            dtpNacimiento.MinDate = System.DateTime.Now.AddYears(-100);
        }

        private void AdmColaboradores_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void btCrear_Click(object sender, EventArgs e)
        {

        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPuesto.DataSource = fdb.BusquedaPuesto(cbArea.Text);
        }
    }
}