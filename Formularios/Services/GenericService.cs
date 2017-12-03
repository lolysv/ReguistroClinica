using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Services
{
    interface GenericService
    {
        bool Crear(string query);
        bool Actualizar(string query);
        bool Borrar(string id);
        SqlDataReader Buscar(string id);
        SqlDataReader MostrarTodo();
        int GetUltimoID();
    }
}
