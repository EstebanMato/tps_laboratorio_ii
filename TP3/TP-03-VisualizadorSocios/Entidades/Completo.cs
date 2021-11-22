using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]

    public class Completo : Socio , IInformacion
    {
        ETribuna tribuna;
        int cantDescuento;
        public Completo(string nombre, string apellido, string dni, EProvincia provincia,
                    string sexo, int edad, int numeroSocio, double costoCuota, ETribuna tribuna, int cantDescuento, DateTime fechaAlta, bool activo)
                    : base(nombre, apellido, dni, provincia, sexo, edad, numeroSocio, costoCuota, fechaAlta, activo)
        {
            this.tribuna = tribuna;
            this.cantDescuento = cantDescuento;
        }
        public Completo()
        {

        }

        public ETribuna Tribuna
        {
            get
            {
                return tribuna;
            }
            set
            {
                tribuna = value;
            }
        }

        public int CantDescuento
        {
            get
            {
                return cantDescuento;
            }
            set
            {
                cantDescuento = value;
            }
        }

        /// <summary>
        /// Retorna la información completa
        /// </summary>
        /// <returns></returns>
        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Tribuna asignada {Tribuna} y la cantidad de descuento otorgada {cantDescuento}");

            return sb.ToString();
        }

        /// <summary>
        /// Retorna el valor de cuota mensual final
        /// </summary>
        /// <returns></returns>
        public double PrecioMensual()
        {
            return CostoCuota.DescontarPorcentaje(cantDescuento);
        }
    }
}
