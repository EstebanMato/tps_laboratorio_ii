using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{

    [Serializable]
    public class Club
    {
        private string nombre;
        private List<Socio> listadoSocios;

        public Club(string nombre)
        {
            this.nombre = nombre;
            this.listadoSocios = new List<Socio>();

        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
    
        public List<Socio> ListadoSocios
        {
            get
            {
                return listadoSocios;
            }
            set
            {
                listadoSocios = value;
            }
        }

        /// <summary>
        /// Cuenta la cantidad de socios Totales del club
        /// </summary>
        /// <returns>Cantidad de socios Totales</returns>
        public int CantSociosTotales()
        {
            return ListadoSocios.Count();
        }

        /// <summary>
        /// Retorna próximo número de socio
        /// </summary>
        /// <returns></returns>
        public int ProximoNumeroSocio()
        {
            return CantSociosTotales() + 1;
        }

        /// <summary>
        /// Devuelve la información completa de los socios Activos
        /// </summary>
        /// <returns>String con los socios Activos</returns>
        public string ListadoSociosActivos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Listado de socios Activos: \n");
            if (listadoSocios != null)
            {
                foreach(Socio socio in listadoSocios)
                {
                    if(socio.Activo)
                        sb.Append(socio.Mostrar()+"\n");
                }
                if(listadoSocios.Count == 0)
                {
                    sb.Append("--Sin socios activos--");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Listado de socios Activos
        /// </summary>
        /// <returns>List de socios activos</returns>
        public List<Socio> SociosActivos()
        {
            List<Socio> listaAux = new List<Socio>();

            if (listadoSocios != null)
            {
                foreach (Socio socio in listadoSocios)
                {
                    if (socio.Activo)
                        listaAux.Add(socio);
                }
            }
            return listaAux;
        }

        /// <summary>
        /// Devuelve la información completa de todos los socios alguna vez ingresados
        /// </summary>
        /// <returns>String con la información de los socios</returns>
        public string ListadoSociosTotales()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Listado de socios Totales: \n");

            if (listadoSocios != null)
            {
                foreach (Socio socio in listadoSocios)
                {
                    sb.Append(socio.Mostrar() + "\n");
                }
            }
            return sb.ToString();
        }


        /// <summary>
        /// Devuelve la información completa de los socios Simples
        /// </summary>
        /// <returns></returns>
        public string ListadoSociosSimples()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Listado de socios Simples: \n");

            if (listadoSocios != null)
            {
                foreach (Socio socio in listadoSocios)
                {
                    if (socio is Simple && socio.Activo)
                        sb.Append(((Simple)socio).MostrarInformacion() + "\n");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Devuelve la información completa de los socios Completos
        /// </summary>
        /// <returns></returns>
        public string ListadoSociosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Listado de socios Completos: \n");

            if (listadoSocios != null)
            {
                foreach (Socio socio in listadoSocios)
                {
                    if (socio is Completo && socio.Activo)
                        sb.Append(((Completo)socio).MostrarInformacion() + "\n");
                }
            }
            return sb.ToString();
        }


        /// <summary>
        /// Devuelve la provincia con más socios registrados
        /// </summary>
        /// <returns></returns>
        public string ProvinciaMasSocios()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cantidad de socios por provincia: \n");

            int contador = 0;

            if (this.SociosActivos().Count != 0)
            {
                for (int i = 0; i < Enum.GetNames(typeof(EProvincia)).Length; i++)
                {
                    foreach (Socio socio in this.SociosActivos())
                    {
                        if ((int)(socio).Provincia == i)
                        {
                            contador++;
                        }
                    }
                    if (contador != 0)
                    {
                       sb.Append($"{Enum.GetName(typeof(EProvincia), i)}, {contador} ");
                        contador = 0;
                    }
                }
            }

            return sb.ToString();
        }


        /// <summary>
        /// Devuelve la tribuna con más socios registrados
        /// </summary>
        /// <returns></returns>
        public string TribunaMasSocios()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("La tribuna con más socios asignados es ");

            int[] contador = new int[Enum.GetNames(typeof(ETribuna)).Length];

            int max = 0;

            if (this.SociosActivos().Count != 0)
            {

                for (int i = 0; i < contador.Length; i++)
                {
                    foreach (Socio socio in this.SociosActivos())
                    {
                        if (socio is Completo && (int)((Completo)socio).Tribuna == i)
                        {
                            contador[i]++;
                        }
                    }

                    if (contador[i] > max)
                    {
                        max = contador[i];
                    }
                }

                for (int i = 0; i < contador.Length; i++)
                {
                    if (contador[i] == max && contador[i] != 0)
                    {
                        sb.Append($"{Enum.GetName(typeof(ETribuna), i)} \n");
                    }
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Devuelve la tribuna con más socios, según listado de socios obtenido por parámetros
        /// </summary>
        /// <returns></returns>
        public string TribunaMasSocios(List<Socio> listadoSocios)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("La tribuna con más socios asignados es ");

            int[] contador = new int[Enum.GetNames(typeof(ETribuna)).Length];

            int max = 0;

            if (listadoSocios.Count != 0)
            {

                for (int i = 0; i < contador.Length; i++)
                {
                    foreach (Socio socio in listadoSocios)
                    {
                        if (socio is Completo && (int)((Completo)socio).Tribuna == i)
                        {
                            contador[i]++;
                        }
                    }

                    if (contador[i] > max)
                    {
                        max = contador[i];
                    }
                }

                for (int i = 0; i < contador.Length; i++)
                {
                    if (contador[i] == max && contador[i] != 0)
                    {
                        sb.Append($"{Enum.GetName(typeof(ETribuna), i)} \n");
                    }
                }
            }
            return sb.ToString();
        }


        /// <summary>
        /// Devuelve la cantidad de ingresos por mes que obtendría el club
        /// </summary>
        /// <returns></returns>
        public string IngresosPorMes()
        {
            StringBuilder sb = new StringBuilder();
            double valor = 0;
            foreach (Socio socio in this.SociosActivos())
            {
                valor += ((IInformacion)socio).PrecioMensual();

            }
            sb.AppendLine($"Los ingresos mensuales del club son ${valor.ToString()}");

            return sb.ToString();
        }


        /// <summary>
        /// Devuelve la tribuna con más socios mujeres
        /// </summary>
        /// <returns></returns>
        public string TribunaMasMujeres()
        {
            StringBuilder sb = new StringBuilder();
            List<Socio> listadoSocios = new List<Socio>();
            foreach (Socio socio in this.SociosActivos())
            {
                if(socio.Sexo == "F")
                {
                    listadoSocios.Add(socio);
                }
            }
            sb.Append(TribunaMasSocios(listadoSocios));

            return sb.ToString();
        }


        /// <summary>
        /// Devuelve la tribuna con más socios hombres
        /// </summary>
        /// <returns></returns>
        public string TribunaMasHombres()
        {
            StringBuilder sb = new StringBuilder();
            List<Socio> listadoSocios = new List<Socio>();
            foreach (Socio socio in this.SociosActivos())
            {
                if (socio.Sexo == "M")
                {
                    listadoSocios.Add(socio);
                }
            }
            sb.Append(TribunaMasSocios(listadoSocios));

            return sb.ToString();
        }


        /// <summary>
        /// Devuelve el promedio de edad de entre todos los socios activos
        /// </summary>
        /// <returns></returns>
        public string PromedioEdad()
        {
            StringBuilder sb = new StringBuilder();
            float sumador = 0;
            float contador = 0;
            foreach(Socio socio in this.SociosActivos())
            {
                sumador += socio.Edad;
                contador++;
            }
            float promedio = sumador / contador;
            sb.AppendLine($"El promedio de edad de los socios es de {promedio}");
            return sb.ToString();
        }


        /// <summary>
        /// Devuelve la cantidad de socios jubilados (Hombres mayor a 65, mujeres mayor a 60)
        /// </summary>
        /// <returns></returns>
        public string CantidadJubilados()
        {
            StringBuilder sb = new StringBuilder();
            int contador = 0;
            foreach (Socio socio in this.SociosActivos())
            {
                if(socio.Sexo == "M" && socio.Edad>=65)
                {
                    contador++;
                }
                else if (socio.Sexo == "F" && socio.Edad>=60)
                {
                    contador++;

                }
            }
           
            sb.AppendLine($"La cantidad de socios jubilados es de {contador}");
            return sb.ToString();
        }

        /// <summary>
        /// Busca un socio en la lista de socios del club, y lo retorna
        /// </summary>
        /// <param name="numeroSocio"></param>
        /// <returns></returns>
        public Socio BuscarSocio(int numeroSocio)
        {
            foreach (Socio socio in listadoSocios)
            {
                if (socio.NumeroSocio == numeroSocio)
                    return socio;
            }

            return null;
        }

        /// <summary>
        /// Sobrecarga del operador "+", agrega un socio a la lista de socios del club
        /// </summary>
        /// <param name="club"></param>
        /// <param name="socio"></param>
        /// <returns></returns>
        public static Club operator +(Club club, Socio socio)
        {
            club.ListadoSocios.Add(socio);

            return club;
        }

    }
}
