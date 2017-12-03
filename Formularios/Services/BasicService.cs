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
    class BasicService : GenericService
    {
        private static string URLBASE = @"Server=.\sqlexpress;Database=BD_CLINICA;Trusted_Connection=True;";
        private string TableName = "";
        private string IdColName = "";

        public BasicService(string tableName, string idColName)
        {
            TableName = tableName;
            IdColName = idColName;
        }

        public bool Actualizar(string query)
        {
            SqlConnection connection = new SqlConnection(URLBASE);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            connection.Open();
            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Actualizado exitosamente");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        public bool Borrar(string id)
        {
            string query = "DELETE FROM "+ TableName +" WHERE "+IdColName+" = " + id;
            SqlConnection connection = new SqlConnection(URLBASE);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            connection.Open();
            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Borrado exitosamente");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        public SqlDataReader Buscar(string id)
        {
            string query = "SELECT * FROM " +TableName+" WHERE "+IdColName+" = " + id;
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
            SqlConnection connection = new SqlConnection(URLBASE);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            connection.Open();
            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Creado exitosamente");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        public int GetUltimoID()
        {
            string query = "SELECT * FROM " + TableName +" ORDER BY "+IdColName+" DESC;";
            SqlConnection connection = new SqlConnection(URLBASE);
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            connection.Open();
            SqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var test = int.Parse(reader.GetString(2));
                    return int.Parse(reader.GetString(2));
                }

                return 0;


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                //connection.Close();

            }

            return 0;
        }

        public SqlDataReader MostrarTodo()
        {
            string query = "SELECT * FROM " + TableName;
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

        
    }
}
