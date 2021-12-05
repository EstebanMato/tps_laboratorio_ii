using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensioDouble
    {
        /// <summary>
        /// Extensión de Double en donde recibe un valor y se le aplica el descuento.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="descuento"></param>
        /// <returns></returns>
        public static double DescontarPorcentaje(this double valor, int descuento)
        {
            return valor - ((valor * descuento) / 100);
        }
    }
}
