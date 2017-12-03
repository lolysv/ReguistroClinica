using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Formularios
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Form formulario = new frmRegistroUsuario();
            formulario.Show();
        }

        private void btnHacerDiagnostico_Click(object sender, EventArgs e)
        {
            Form formulario = new frmHacerDiagnostico();
            formulario.Show();
        }

        private void btnConsultarCitas_Click(object sender, EventArgs e)
        {
            Form formulario = new frmCitasDoctor();
            formulario.Show();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmRegistroUsuario();
            formulario.Show();
        }

        private void hacerDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmHacerDiagnostico();
            formulario.Show();
        }

        private void verCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmCitasDoctor();
            formulario.Show();
        }

        private void btnConsultarExpediente_Click(object sender, EventArgs e)
        {

        }

        private void consultarExpedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmConsultarExpediente();
            formulario.Show();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
