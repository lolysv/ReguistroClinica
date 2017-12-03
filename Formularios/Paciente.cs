using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    class Paciente
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Edad { get; set; }
        public string Telefono { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
    }
}
