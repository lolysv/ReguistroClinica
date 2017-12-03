using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Models
{
    class Diagnostico
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idPaciente;

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        private string diagnosticoFinal;

        public string DiagnosticoFinal
        {
            get { return diagnosticoFinal; }
            set { diagnosticoFinal = value; }
        }

        public Diagnostico(string id, int idPaciente, string diagnosticoFinal)
        {
            this.id = id;
            this.idPaciente = idPaciente;
            this.diagnosticoFinal = diagnosticoFinal;
        }

    }
}
