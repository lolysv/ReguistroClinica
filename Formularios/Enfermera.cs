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
    public partial class frmEnfermera : Form
    {
        public frmEnfermera()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void registroPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente Rp = new frmRegistroPaciente();
            Rp.Show();
        }

        private void registrarCitasPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCita Rc = new frmRegistroCita();
            Rc.Show();
        }

        private void consultarCitasPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCitasDoctor Cd = new frmCitasDoctor();
            Cd.Show();
        }

        private void consultarCitasDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultasCitasDoctor Cc = new FrmConsultasCitasDoctor();
            Cc.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        

       
    }
}