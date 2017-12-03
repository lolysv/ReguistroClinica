using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void registrarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarCitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroCita Rc = new frmRegistroCita();
            Rc.Show();
        }

        private void consultarCitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCitasDoctor Cp = new frmCitasDoctor();
            Cp.Show();
        }
    }
}
