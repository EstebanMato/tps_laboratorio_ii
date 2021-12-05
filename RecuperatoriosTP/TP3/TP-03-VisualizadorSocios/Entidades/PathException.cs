using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PathException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
            set
            {
                this.nombreClase = value;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }

            set
            {
                this.nombreMetodo = value;
            }
        }

        public PathException(string mensaje, string clase, string metodo)
            : base(mensaje)
        {
            this.NombreClase = clase;
            this.NombreMetodo = metodo;

        }

        public PathException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.NombreClase = clase;
            this.NombreMetodo = metodo;

        }
    }
}
