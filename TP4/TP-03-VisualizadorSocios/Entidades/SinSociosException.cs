using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SinSociosException : Exception
    {
        /// <summary>
        /// Excepción sin socios en el listado del club
        /// </summary>
        public SinSociosException()
        {

        }

        /// <summary>
        /// Excepción sin socios en el listado del club
        /// </summary>
        /// <param name="mensaje">Mensaje de error a ser mostrado</param>
        public SinSociosException(string mensaje) : base(mensaje)
        {

        }
    }
}
