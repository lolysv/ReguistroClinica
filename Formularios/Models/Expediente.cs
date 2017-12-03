using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Models
{
    class Expediente
    {
        private int _codigo;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nombres;

        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        private string _dui;

        public string Dui
        {
            get { return _dui; }
            set { _dui = value; }
        }

        private string _domicilio;

           public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private string _diagnostico;

        public string Diagnostico
        {
            get { return _diagnostico; }
            set { _diagnostico = value; }
        }

    }
}
