using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Services
{

    class ExpedienteServices : GenericService
    {
        private static string URLBASE = @"Server=.\sqlexpress;Database=BD_CLINICA;Trusted_Connection=True;";
      
        public bool Actualizar(string query)
        {
       

            return false;
        }

        public bool Borrar(string id)
        {
            
            return false;
        }

        public SqlDataReader Buscar(string id)
        {
            string query = "SELECT  " +
                "T2.ID_PACIENTE, T2.NOMBRE_PAC, T2.APELLIDO_PAC, T2.EDAD, " +
                "T2.DUI_PAC, T2.DIRECCION, T2.TELEFONO, T1.DESCRIPCION_DIAGNOSTICO " +
                "FROM DIAGNOSTICO T1 INNER JOIN PACIENTE T2 ON T1.ID_PACIENTE1 = T2.ID_PACIENTE where T1.ID_PACIENTE1 = " + id;
            SqlConnection connection = new SqlConnection(URLBASE);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            connection.Open();
            SqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader != null)
                {
                    return reader;
                }

                return null;


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return null;
        }

        public bool Crear(string query)
        {
            
            return false;
        }


        public int GetUltimoID()
        {
            

            return 0;
        }

        

        public SqlDataReader MostrarTodo()
        {
           


            return null;
        }
    }
}
