using System;
using System.Collections;
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
    public partial class FrmConsultasCitasDoctor : Form
    {

        class CitaViewModel
        {
            public string CodigoPaciente { get; set; }
            public string NombrePaciente { get; set; }
            public string CodigoCita { get; set; }
            public DateTime HoraCita { get; set; }
            public string NombreDoctor { get; set; }

        }

        ArrayList Citas = new ArrayList();

        public FrmConsultasCitasDoctor()
        {

            CitaViewModel cita1 = new CitaViewModel
            {
                CodigoCita = "cit1",
                CodigoPaciente = "00000000-1",
                HoraCita = DateTime.Now,
                NombreDoctor = "Jorge Acevedo",
                NombrePaciente = "Alexander Rodriguez"
            };

            CitaViewModel cita2 = new CitaViewModel
            {
                CodigoCita = "cit2",
                CodigoPaciente = "00000000-2",
                HoraCita = new DateTime(2017,10,11,06,23,08),
                NombreDoctor = "Jose Antonio",
                NombrePaciente = "carlos aguirre"
            };
            CitaViewModel cita3 = new CitaViewModel
            {
                CodigoCita = "cit3",
                CodigoPaciente = "00000000-3",
                HoraCita = new DateTime(2017,11,11,15,10,20),
                NombreDoctor = "David Aguirre",
                NombrePaciente = "Karina kardoza"
            };
            CitaViewModel cita4 = new CitaViewModel
            {
                CodigoCita = "cit4",
                CodigoPaciente = "00000000-4",
                HoraCita = new DateTime(2018, 1, 1,20,5,30),
                NombreDoctor = "jose roberto",
                NombrePaciente = "Karina elizabeth"
            };
            CitaViewModel cita5 = new CitaViewModel
            {
                CodigoCita = "cit5",
                CodigoPaciente = "00000000-5",
                HoraCita = new DateTime(2017, 12, 11,20,10,30),
                NombreDoctor = "susana marlene",
                NombrePaciente = "natalia Aguirre"
            };
            CitaViewModel cita6 = new CitaViewModel
            {
                CodigoCita = "cit6",
                CodigoPaciente = "00000000-6",
                HoraCita = new DateTime(2017, 10, 11,12,23,34),
                NombreDoctor = "yesenia ayala",
                NombrePaciente = "jonathan nathanael"
            };



            Citas.Add(cita1);
            Citas.Add(cita2);
            Citas.Add(cita3);
            Citas.Add(cita4);
            Citas.Add(cita5);
            Citas.Add(cita6);

            InitializeComponent();

            //cambiar el nombre de las columnas aqui
            //dgv.Columns[0].HeaderText = "primera columna";
            //...
        }

        private void btmCitas_Click(object sender, EventArgs e)
        {

            ArrayList citasDelDia = new ArrayList();

            foreach (CitaViewModel cita in Citas)
            {
                if (cita.HoraCita.Date == DateTime.Now.Date)
                {
                    citasDelDia.Add(cita);
                }
            }

            dgv.DataSource = citasDelDia;

        }

        private void lblCitasDoctor_Click(object sender, EventArgs e)
        {

            string[] lista = new string[Citas.Count];

            for (int i = 0; i < Citas.Count; i++)
            {
                lista[i] = ((CitaViewModel)Citas[i]).NombreDoctor;
            }

            frmListaDoctores formListaDoc = new frmListaDoctores(lista.ToArray());

            formListaDoc.ShowDialog();

            string nombreDoctor = formListaDoc.NombreDoctor;

            formListaDoc.Dispose();

            ArrayList citasPorDoctor = new ArrayList();

            foreach (CitaViewModel cita in Citas)
            {
                if (cita.NombreDoctor == nombreDoctor)
                {
                    citasPorDoctor.Add(cita);
                }
            }

            dgv.DataSource = citasPorDoctor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
