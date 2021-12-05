using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CargaEnCursoException : Exception
    {
        /// <summary>
        /// Excepción de carga o guardado de DB en curso
        /// </summary>
        public CargaEnCursoException()
        {

        }

        /// <summary>
        /// Excepción de carga o guardado de DB en curso
        /// </summary>
        /// <param name="mensaje">Mensaje de error a ser mostrado</param>
        public CargaEnCursoException(string mensaje) : base(mensaje)
        {

        }
    }
}
