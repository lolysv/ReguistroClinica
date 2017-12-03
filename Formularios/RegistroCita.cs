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
    public partial class frmRegistroCita : Form
    {


        public static ArrayList codigo_paciente = new ArrayList();
        public static ArrayList nombres = new ArrayList();
        public static ArrayList apellidos = new ArrayList();
        public static  ArrayList doctor = new ArrayList();
        public static ArrayList fecha_cita = new ArrayList();
        public static  ArrayList hora_cita = new ArrayList();

        DataTable datos = new DataTable();

         int i = 0;
       // int ca;
         private void frmRegistroCita_Load(object sender, EventArgs e)
         {
             datos.Columns.Add("Codigo paciente");
            // datos.Columns.Add("Nombres");
            // datos.Columns.Add("Apellidos");
             datos.Columns.Add(" doctor ");
             datos.Columns.Add("Fecha Cita");
             datos.Columns.Add("Hora cita");

         }

        public frmRegistroCita()
        {
            InitializeComponent();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    foreach (Control ctrl in this.Controls)
        //    {
        //        if (ctrl is TextBox)
        //        {
        //            TextBox text = ctrl as TextBox;
        //                text.Clear();
        //                limpiar();
        //        }
        //    }
        //}

        private void limpiar()
        {
            listdoctor.Text = null;
            dateTimePicker1.Text = null;
            listhora.Text = null;
            textBox1.Clear();
            //foreach (Control ctrl in this.Controls)
            //{
            //    if (ctrl is TextBox)
            //    {
            //        TextBox text = ctrl as TextBox;
            //            text.Clear();
            //            limpiar();
            //    }
            //}
            //limpiar2();
        }

        //private void limpiar2()
        //{
        //    listdoctor.Text = null;
        //    dateTimePicker1.Text = null;
        //    listhora.Text = null;
        //}


           // private void agregar()
            //{
        //    string doctorcita, horariocita;
        //    doctorcita = listBox2.Text.ToString();
        //    horariocita = listBox1.Text.ToString().Trim();

                //if (doctor.Contains(checkedListBox1.Text) || hora_cita.Contains(checkedListBox1.Text))
                //{
                //    MessageBox.Show("REGISTRO EXISTENTE", "___ERROR____", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}

                //if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
                //{
                //    MessageBox.Show("* CAMPOS VACIOS *", " ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
           // }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {  
        }
        private void button1_Click(object sender, EventArgs e)
        {
        //agregar();
        //     string doctorcita, horariocita;
        //     doctorcita = listBox2.Text.ToString();
        //horariocita = listBox1.Text.ToString().Trim();

        //if (doctor.Contains(listBox2.Text))
        //{
        //    MessageBox.Show("REGISTRO YA EXISTE", "___ERROR____", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}


            // FALTA UNA CONDICION QUE LIMITE A QUE UN DOCTORBTENGO 4 PACIENTES MAXIMO EN UN DIA.

           

            if (codigo_paciente.Contains(textBox1.Text) )
            {
                MessageBox.Show(" DUI  EXISTENTE ....   ACTUALMENTE TIENE UNA CITA YA REGISTRADA ", "___ERROR____", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
            else
            {

                if (doctor.Contains(listdoctor.Text) && hora_cita.Contains(listhora.Text) && fecha_cita.Contains(dateTimePicker1.Text))
            {
                MessageBox.Show(" DOCTOR YA ASIGNADO A UNA CITA EN ESA FECHA Y HORA ", "___ERROR____", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                

                }

                    else 
                {


                    if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(listdoctor.Text) || String.IsNullOrEmpty(listhora.Text) )
        {
            MessageBox.Show("* CAMPOS VACIOS *", " ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
            else
            {
                //Lamando los métodos para agregar, limpiar y listar los datos
               
                Registrar();
                listar();
                limpiar();

                MessageBox.Show(" REGISTRO REALIZADO CON EXITO  ", "   * CONFIRMACION * ");

            }      

        }
            }
        }

        // Método que me permitirá actualizar el DataGirdView cada vez que modifique los ArrayList
        public void listar()
        {
            //Cuenta la cantidad de registros que hay en el arraylist 'carnet'
            while (i < codigo_paciente.Count)
            {
                //Crea un DataRow para el DataTable 'datos'
                DataRow fila = datos.NewRow();
                //Le asigna a cada fila por columna, el valor de la casilla del ArrayList por el índice
                fila["Codigo paciente"] = codigo_paciente[i].ToString();
               // fila["Nombres"] = nombres[i].ToString();
                //fila["apellidos"] = apellidos[i].ToString();
                fila[" doctor "] = doctor[i].ToString();
                fila["Fecha Cita"] = fecha_cita[i].ToString();
                fila["Hora cita"] = hora_cita[i].ToString();
                //Agrega una fila y los datos halados de los arrayist correspondientes a cada columna
                datos.Rows.Add(fila);
                //incrementa el contador del while y a la vez, el índice de los arrayList
                i++;
            }
            //Una vez que ha terminado de recorrer los ArrayList y agregado las filas necesarias al dataTable,
            //lo envía todo al DataGidView
            dgv.DataSource = datos;
        }
        private void Registrar()
        {
            codigo_paciente.Add(textBox1.Text);
            //nombres.Add(textBox2.Text);
            //apellidos.Add(textBox3.Text);
            doctor.Add(listdoctor.Text);
            fecha_cita.Add(dateTimePicker1.Text);
            hora_cita.Add(listhora.Text);
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void consultarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCitasDoctor CC = new frmCitasDoctor();

            CC.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioSesion ss = new frmInicioSesion();
            ss.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmRegistroCita.hide();
            frmInicioSesion ss = new frmInicioSesion();
            ss.Show();
            
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultarCitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCitasDoctor CC = new frmCitasDoctor();

            CC.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
        }
    }
