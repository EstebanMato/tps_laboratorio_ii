using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]

    public class Simple : Socio , IInformacion
    {
        //tipo somos river, solo accesos a los partidos locales y listo
        public Simple(string nombre, string apellido, string dni, EProvincia provincia,
                    string sexo, int edad, int numeroSocio, double costoCuota , DateTime fechaAlta, bool activo)
                    :base(nombre, apellido,dni,provincia,sexo,edad,numeroSocio,costoCuota, fechaAlta, activo)
        {

        }
        public Simple()
        {

        }


        /// <summary>
        /// Retorna la información completa
        /// </summary>
        /// <returns></returns>
        public string MostrarInformacion()
        {
            return base.Mostrar();
        }

        /// <summary>
        /// Retorna el valor de cuota mensual final
        /// </summary>
        /// <returns></returns>
        public double PrecioMensual()
        {
            return CostoCuota;
        }
    }
}
