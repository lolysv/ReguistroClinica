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
    public partial class frmConsultarExpediente : Form
    {
        ExpedienteServices expediente;

        public frmConsultarExpediente()
        {
            InitializeComponent();
            expediente = new ExpedienteServices();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string id = txtCodigo.Text;
            SetDataList(expediente.Buscar(id));

        }

        private void SetDataList(SqlDataReader reader)
        {
            ArrayList list = new ArrayList();
            while (reader.Read())
            {


                Expediente expediente = new Expediente()
                {
                    Codigo = reader.GetInt32(0),
                    Nombres = reader.GetString(1),
                    Apellido = reader.GetString(2),
                    Edad = reader.GetInt32(3),
                    Dui = reader.GetString(4),
                    Domicilio = reader.GetString(5),
                    Telefono = reader.GetString(6),
                    Diagnostico = reader.GetString(7)
                };

                list.Add(expediente);
            }

            dgtLista.DataSource = null;
            dgtLista.DataSource = list;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
