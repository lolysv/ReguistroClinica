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
    public partial class OrganizarHorarios : Form
    {


        //ArrayList codigo_paciente = new ArrayList();
        //ArrayList nombres = new ArrayList();
        //ArrayList apellidos = new ArrayList();
        ArrayList doctor = new ArrayList();
        ArrayList dia = new ArrayList();
        ArrayList hora = new ArrayList();
        //ArrayList hora_cita = new ArrayList();

        DataTable datos = new DataTable();

        int i = 0;
        // int ca;
        public OrganizarHorarios()
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
        //            text.Clear();
        //            limpiar();
        //        }
        //    }
        //}
        private void limpiar()
        {
            checkedListBox1.Text = null;
            chekhora.Text = null;

            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();

                }
            }
            //txtdoctor.Text = null;
            checkedListBox1.Text = null;
            chekhora.Text = null;
        }
        private void OrganizarHorarios_Load(object sender, EventArgs e)
        {
            //datos.Columns.Add("Codigo paciente");
            // datos.Columns.Add("Nombres");
            //datos.Columns.Add("Apellidos");
            datos.Columns.Add(" doctor ");
            datos.Columns.Add("dia");
            datos.Columns.Add("hora");
            //datos.Columns.Add("Fecha Cita");
            //datos.Columns.Add("Hora cita");

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (doctor.Contains(txtdoctor.Text) && hora.Contains(chekhora.Text) && dia.Contains(checkedListBox1.Text))
            {
                MessageBox.Show("REGISTRO EXISTENTE", "___ERROR____", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

            else
            {


                if (String.IsNullOrEmpty(checkedListBox1.Text) || String.IsNullOrEmpty(chekhora.Text) || String.IsNullOrEmpty(txtdoctor.Text))
                {
                    MessageBox.Show("* CAMPOS VACIOS *", " ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Lamando los métodos para agregar, limpiar y listar los datos

                    Registrar();
                    listar();
                    MessageBox.Show(" REGISTRO REALIZADO ", "   * CONFIRMACION * ");

                }

            }
        }
        //    if (String.IsNullOrEmpty(checkedListBox1.Text) || String.IsNullOrEmpty(chekhora.Text) || String.IsNullOrEmpty(txtdoctor.Text))
        //    {
        //        MessageBox.Show("* CAMPOS VACIOS *", " ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    else
        //    {
        //        //Lamando los métodos para agregar, limpiar y listar los datos
        //        Registrar();
        //        listar();
        //        MessageBox.Show(" REGISTRO REALIZADO ", "   * CONFIRMACION * ");

        //    }      

        //}

        // Método que me permitirá actualizar el DataGirdView cada vez que modifique los ArrayList
        private void listar()
        {
            //Cuenta la cantidad de registros que hay en el arraylist 'carnet'
            while (i < doctor.Count)
            {
                //Crea un DataRow para el DataTable 'datos'
                DataRow fila = datos.NewRow();
                //Le asigna a cada fila por columna, el valor de la casilla del ArrayList por el índice
                // fila["Codigo paciente"] = codigo_paciente[i].ToString();
                //fila["Nombres"] = nombres[i].ToString();
                // fila["apellidos"] = apellidos[i].ToString();
                fila[" doctor "] = doctor[i].ToString();
                fila["dia"] = dia[i].ToString();
                fila["hora"] = hora[i].ToString();
                //fila["Hora cita"] = hora_cita[i].ToString();
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

            doctor.Add(txtdoctor.Text);
            dia.Add(checkedListBox1.Text);
            hora.Add(chekhora.Text);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicioSesion mnn = new frmInicioSesion();
            mnn.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}



