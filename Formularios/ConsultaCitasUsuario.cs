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
    public partial class frmCitasDoctor : Form
    {
        string usuario;
        int i = 0;

        //ArrayList codigo_paciente = new ArrayList();
        //ArrayList nombres = new ArrayList();
        //ArrayList apellidos = new ArrayList();
        //ArrayList doctor = new ArrayList();
        //ArrayList fecha_cita = new ArrayList();
        //ArrayList hora_cita = new ArrayList();

         DataTable datos;

       
        public frmCitasDoctor()
        {
            InitializeComponent();

            datos = new DataTable();
            datos.Columns.Add("Codigo paciente");
            //datos.Columns.Add("Nombres");
            //datos.Columns.Add("Apellidos");
            datos.Columns.Add(" doctor ");
            datos.Columns.Add("Fecha Cita");
            datos.Columns.Add("Hora cita");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           llenar();
            listardos();
           

            
        }
        public void listar1()
        {
            int cantidadUsuarios = frmRegistroCita.codigo_paciente.Count;
            for (int i = 0; i < cantidadUsuarios; i++)
            {
               DataRow fila = datos.NewRow();
               fila["Codigo paciente"] = frmRegistroCita.codigo_paciente[i].ToString();
               //fila["Nombres"] = frmRegistroCita.nombres[i].ToString();
               //fila["apellidos"] = frmRegistroCita.apellidos[i].ToString();
               fila[" doctor "] = frmRegistroCita.doctor[i].ToString();
               fila["Fecha Cita"] = frmRegistroCita.fecha_cita[i].ToString();
               fila["Hora cita"] = frmRegistroCita.hora_cita[i].ToString();
            //    nuevaFila["Carnet"] = frmMenu.carnet[indice].ToString();
            //    nuevaFila["Nombres"] = frmMenu.nombres[indice].ToString();
            //    nuevaFila["Apellidos"] = frmMenu.apellidos[indice].ToString();
            //    string nivel = frmMenu.nivel[indice].ToString();
            //    nuevaFila["Nivel"] = nivel == "1" ? "Usuario" : nivel == "2" ? "Asistente" : "Administrador";
              datos.Rows.Add(fila);
            //    // llamamos que se llene el datagrid

                dataGridView1.DataSource = datos;
            }
           // try
            //{
            //    usuario = txtUs.Text.ToString().Trim();
            //    while (dataGridView1.RowCount > 1)
            //    {
            //        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            //    }
            //    dataGridView1.Refresh();

            //    if (codigo_paciente.Contains(usuario) == true)
            //    {
            //        i = codigo_paciente.IndexOf(usuario);
            //        txtUs.Text = codigo_paciente[i].ToString();

            //        DataRow fila = datos.NewRow();
            //        fila["Codigo paciente"] = frmRegistroCita.codigo_paciente[i].ToString();
            //        fila["Nombres"] = frmRegistroCita.nombres[i].ToString();
            //        fila["apellidos"] = frmRegistroCita.apellidos[i].ToString();
            //        fila[" doctor "] = frmRegistroCita.doctor[i].ToString();
            //        fila["Fecha Cita"] = frmRegistroCita.fecha_cita[i].ToString();
            //        fila["Hora cita"] = frmRegistroCita.hora_cita[i].ToString();

                    //fila["Codigo paciente"] = codigo_paciente[i].ToString();
                    //fila["Nombres"] = nombres[i].ToString();
                    //fila["apellidos"] = apellidos[i].ToString();
                    //fila[" doctor "] = doctor[i].ToString();
                    //fila["Fecha Cita"] = fecha_cita[i].ToString();
                    //fila["Hora cita"] = hora_cita[i].ToString();



                    //datos.Rows.Add(fila);
                    dataGridView1.DataSource = datos;
                    Limpieza();
                }

        //        else
        //        {
        //            MessageBox.Show("Error el Codigo del paciente no existe!");
        //            Limpieza();
        //            dataGridView1.DataSource = null;
        //        }


        //    }
        //    catch
        //    {

        //    }
        //}
        public void listardos()
        {
          
              //  nuevaFila["Carnet"] = frmMenu.carnet[indice].ToString();
            //    nuevaFila["Nombres"] = frmMenu.nombres[indice].ToString();
            //    nuevaFila["Apellidos"] = frmMenu.apellidos[indice].ToString();
            //    string nivel = frmMenu.nivel[indice].ToString();
            //    nuevaFila["Nivel"] = nivel == "1" ? "Usuario" : nivel == "2" ? "Asistente" : "Administrador";
            //  datos.Rows.Add(fila);
            //     llamamos que se llene el datagrid

            //    dataGridView1.DataSource = datos;
            //}
            try
            {
                usuario = txtUs.Text.ToString().Trim();
                while (dataGridView1.RowCount > 1)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
                dataGridView1.Refresh();

                if (frmRegistroCita.codigo_paciente.Contains(usuario) == true)
                {
                    i = frmRegistroCita.codigo_paciente.IndexOf(usuario);
                    txtUs.Text = frmRegistroCita.codigo_paciente[i].ToString();

                    DataRow fila = datos.NewRow();
                    fila["Codigo paciente"] = frmRegistroCita.codigo_paciente[i].ToString();
                   // fila["Nombres"] = frmRegistroCita.nombres[i].ToString();
                   // fila["apellidos"] = frmRegistroCita.apellidos[i].ToString();
                    fila[" doctor "] = frmRegistroCita.doctor[i].ToString();
                    fila["Fecha Cita"] = frmRegistroCita.fecha_cita[i].ToString();
                    fila["Hora cita"] = frmRegistroCita.hora_cita[i].ToString();

                    //fila["Codigo paciente"] = frmRegistroCita.codigo_paciente[i].ToString();
                    //fila["Nombres"] = frmRegistroCita.nombres[i].ToString();
                    //fila["apellidos"] = frmRegistroCita.apellidos[i].ToString();
                    //fila[" doctor "] = frmRegistroCita.doctor[i].ToString();
                    //fila["Fecha Cita"] = frmRegistroCita.fecha_cita[i].ToString();
                    //fila["Hora cita"] = frmRegistroCita.hora_cita[i].ToString();



                    datos.Rows.Add(fila);
                    dataGridView1.DataSource = datos;
                    Limpieza();
                }

                else
                {
                    MessageBox.Show("Error el Codigo del paciente no existe!");
                    Limpieza();
                    dataGridView1.DataSource = null;
                }


            }
            catch
            {

            }
        }

        public void llenar()
        {
            DataRow fila = datos.NewRow();
            fila["Codigo paciente"] = frmRegistroCita.codigo_paciente[i].ToString();
            //fila["Nombres"] = frmRegistroCita.nombres[i].ToString();
            //fila["apellidos"] = frmRegistroCita.apellidos[i].ToString();
            fila[" doctor "] = frmRegistroCita.doctor[i].ToString();
            fila["Fecha Cita"] = frmRegistroCita.fecha_cita[i].ToString();
            fila["Hora cita"] = frmRegistroCita.hora_cita[i].ToString();

            frmRegistroCita.codigo_paciente.Add(frmRegistroCita.codigo_paciente);
            //codigo_paciente.Add("0002");
            //codigo_paciente.Add("0003");
            //nombres.Add("Claudia Berenice");
            frmRegistroCita.nombres.Add(frmRegistroCita.nombres);
            //nombres.Add("Alex Noe");
           frmRegistroCita.apellidos.Add(frmRegistroCita.apellidos);
            //apellidos.Add("Rivas Domingues");
            //apellidos.Add("Estrada Menjivar");
            //doctor.Add("Manuel Alejandro hernandez");
            frmRegistroCita.doctor.Add(frmRegistroCita.doctor);
            //doctor.Add("Jessica Carolina molina");
            frmRegistroCita.fecha_cita.Add(frmRegistroCita.fecha_cita);
            //fecha_cita.Add("06/12/2017");
            //fecha_cita.Add("16/12/2017");
            frmRegistroCita.hora_cita.Add(frmRegistroCita.hora_cita);
            //hora_cita.Add(" 3:00 pm a 4:00 pm");
            //hora_cita.Add(" 11:00 am a 12:00 md");

        }


        public void Limpieza()
        {
            txtUs.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaCitasDoctor_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult opcion;

            opcion = MessageBox.Show(this, "¿Esta seguro de Cancelar la cita?", "¡Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (String.IsNullOrEmpty(txtUs.Text))
            {
                MessageBox.Show("* Ingrese un numero de dui *", " ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            if (opcion == DialogResult.Yes)
            {
              dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            else
            {

            }
        }
    }

        private void txtUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            listar1();
            llenar();
            Limpieza();
        } 
}
}