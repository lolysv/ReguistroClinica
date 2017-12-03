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
using System.Data.SqlClient;
using Formularios.Models;
using Formularios.Services;

namespace Formularios
{
    public partial class frmHacerDiagnostico : Form
    {
        private string _tableName;
        private string _idColName;

        private static bool SeEstaModificando = false;
        private string tempId = "";
        private BasicService basicService;

        public frmHacerDiagnostico()
        {
            InitializeComponent();
            _tableName = "Diagnostico";
            _idColName = "ID_DIAGNOSTICO";
            basicService = new BasicService(_tableName, _idColName);
            SetDataList(basicService.MostrarTodo());
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funciones
        private void agregar() {
            if (Validador())
            {
                string cod = txtCodigo.Text;
                string diag = txtDiagnostico.Text;
                int sumaId = basicService.GetUltimoID() + 1;
                Diagnostico diagnostico = new Diagnostico(sumaId.ToString(), int.Parse(cod), diag);

                string query = "INSERT INTO "+_tableName+ " ("+_idColName+", ID_PACIENTE1, DESCRIPCION_DIAGNOSTICO)"
                          + "VALUES ('" + diagnostico.Id + "','" + diagnostico.IdPaciente + "', '" + diagnostico.DiagnosticoFinal + "' )";

                if (basicService.Crear(query))
                {
                    SetDataList(basicService.MostrarTodo());
                }
            }
        }

        private void modificar() {
            if (!SeEstaModificando)
            {
                btnAgregar.Enabled = false;
                txtEliminar.Enabled = false;
                int posicion = dataGridView1.SelectedCells[0].RowIndex;
                tempId = dataGridView1.Rows[posicion].Cells[0].Value.ToString();
                btnModificar.Text = "Guardar";
                SeEstaModificando = true;
                SqlDataReader reader = basicService.Buscar(tempId);
                if (reader.Read())
                {
                    Diagnostico diagnosticoT = new Diagnostico(reader.GetString(2),
                                                reader.GetInt32(0),
                                                reader.GetString(1));
                    txtCodigo.Text = Convert.ToString(diagnosticoT.IdPaciente);
                    txtDiagnostico.Text = diagnosticoT.DiagnosticoFinal;
                }
            }
            else
            {
                if (Validador())
                {
                    btnModificar.Text = "Modificar";
                    SeEstaModificando = false;
                    string cod = txtCodigo.Text;
                    string diag = txtDiagnostico.Text;

                    string query = "UPDATE "+_tableName+" SET" +
                        " ID_PACIENTE1='" + cod +
                        "', DESCRIPCION_DIAGNOSTICO='" + diag +
                        "' where "+_idColName+" = " + tempId;
                    if (basicService.Actualizar(query))
                    {
                        SetDataList(basicService.MostrarTodo());
                    }

                    tempId = "";
                    txtCodigo.Clear();
                    txtDiagnostico.Clear();
                    btnAgregar.Enabled = true;
                    txtEliminar.Enabled = true;
                }
            }
        }
  
        private void borrar() {
            int posicion = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[posicion].Cells[0].Value.ToString();
            
            if (basicService.Borrar(id))
            {
                SetDataList(basicService.MostrarTodo());
            }
        }

        private void SetDataList(SqlDataReader reader)
        {
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                Diagnostico diagnosticoTemp = new Diagnostico(reader.GetString(2),
                    reader.GetInt32(0),
                    reader.GetString(1)
                    );

                list.Add(diagnosticoTemp);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private bool Validador()
        {
            return !(txtCodigo.Text.Equals("") || txtDiagnostico.Text.Equals(""));
        }

    }
}
