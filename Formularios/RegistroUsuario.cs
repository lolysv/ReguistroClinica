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
    public partial class frmRegistroUsuario : Form
    {
        //Creo los ArrayList en la clase para que sean visibles a nivel de todos los botones y métodos
        ArrayList nombres = new ArrayList();
        ArrayList apellidos = new ArrayList();
        ArrayList nivel = new ArrayList();
        ArrayList junta = new ArrayList();
        ArrayList usuario = new ArrayList();
        ArrayList contra = new ArrayList();

        //Creo DataTable que me permitirá agregar los datos en el DataGridView
        DataTable datos = new DataTable();

        //variable tipo entero que me permitirá manejar los índices de los ArrayList y listar los datos en el DataGridView
        int i = 0;


        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            //Creo las columans en el DataTable
            datos.Columns.Add("Nombres");
            datos.Columns.Add("Apellidos");
            datos.Columns.Add("Nivel");
            datos.Columns.Add("Junta");
            datos.Columns.Add("Usuario");
            datos.Columns.Add("Contraseña");


        }

        //Método que me permitirá actualizar el DataGirdView cada vez que modifique los ArrayList
        private void listar()
        {
            //Cuenta la cantidad de registros que hay en el arraylist 'carnet'
            while (i < usuario.Count)
            {
                //Crea un DataRow para el DataTable 'datos'
                DataRow fila = datos.NewRow();
                //Le asigna a cada fila por columna, el valor de la casilla del ArrayList por el índice
                fila["Nombres"] = nombres[i].ToString();
                fila["Apellidos"] = apellidos[i].ToString();
                fila["Nivel"] = nivel[i].ToString();
                fila["Junta"] = junta[i].ToString();
                fila["Usuario"] = usuario[i].ToString();
                fila["Contraseña"] = contra[i].ToString();
                //Agrega una fila y los datos halados de los arrayist correspondientes a cada columna
                datos.Rows.Add(fila);
                //incrementa el contador del while y a la vez, el índice de los arrayList
                i++;
            }
            //Una vez que ha terminado de recorrer los ArrayList y agregado las filas necesarias al dataTable,
            //lo envía todo al DataGidView
            dgv.DataSource = datos;
        }

        //Método que limpia las cajas de texto y regresa todo por defecto
        public void limpiar()
        {
            rdbDoctor.Checked = true;
            txtNombres.Text = null;
            txtApellidos.Text = null;
            txtJunta.Text = null;
            txtUsuario.Text = null;
            txtContra.Text = null;
        }



        //Inhabilita los campos innecesarios para la búsqueda, dejando solo aquellos que son realmente necesarios
        private void inhabilitarBuscar()
        {
            rdbDoctor.Enabled = false;
            rdbEnfermera.Enabled = false;
            rdbDoctor.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            btnAgregar.Enabled = false;
        }



        //Se ejecuta en el botón Agregar, este agrega los datos ingresados por el usuario, en los ArrayList
        public void agregar()
        {
            if (usuario.Contains(txtUsuario.Text))
            {
                MessageBox.Show("Usuario Ya Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                nombres.Add(txtNombres.Text);
                apellidos.Add(txtApellidos.Text);
                nivel.Add(rdbDoctor.Checked ? "Doctor" : "Enfermera");
                junta.Add(txtJunta.Text);
                usuario.Add(txtUsuario.Text);
                contra.Add(txtContra.Text);
                limpiar();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
            listar();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            agregar();
            listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
