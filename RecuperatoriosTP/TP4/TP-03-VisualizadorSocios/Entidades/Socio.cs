using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public enum ETribuna
    {
        Sivori, Centenario, Belgrano, SanMartin
    }

    public enum EProvincia
    {
        BuenosAires=1, CapitalFederal, Catamarca, Chaco, Chubut, Cordoba, Corrientes, EntreRios, Formosa, Jujuy,
        LaPampa, LaRioja, Mendoza, Misiones, Neuquen, RioNegro, Salta, SanJuan, SanLuis, SantaCruz, SantaFe,
        SantiagoDelEstero, TierraDelFuego, Tucuman
    }

    [Serializable]
    [XmlInclude(typeof(Simple))]
    [XmlInclude(typeof(Completo))]

    public class Socio
    {
        string nombre;
        string apellido;
        string dni;
        string sexo;
        double costoCuota;
        int edad;
        int numeroSocio;
        bool activo;
        EProvincia provincia;
        DateTime fechaAlta;

        public Socio()
        {

        }
        public Socio(string nombre, string apellido, string dni, EProvincia provincia, 
                    string sexo, int edad, int numeroSocio, double costoCuota, DateTime fechaAlta, bool activo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.provincia = provincia;
            this.sexo = sexo;
            this.edad = edad;
            this.fechaAlta = fechaAlta;
            this.numeroSocio = numeroSocio;
            this.activo = activo;
            this.costoCuota = costoCuota;
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

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        public EProvincia Provincia
        {
            get
            {
                return provincia;
            }
            set
            {
                provincia = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        
        public DateTime FechaAlta
        {
            get
            {
                return fechaAlta;
            }
            set
            {
                fechaAlta = value;
            }
        }
        public int NumeroSocio
        {
            get
            {
                return numeroSocio;
            }
            set
            {
                this.numeroSocio = value;
            }
        }

        public bool Activo
        {
            get
            {
                return activo;
            }
            set
            {
                activo = value;
            }
        }
        
        public double CostoCuota
        {
            get
            {
                return costoCuota;
            }
            set
            {
                costoCuota = value;
            }
        }
       
        public string Mostrar()
        {
            return $"{Nombre} {Apellido}  DNI {Dni}, {Edad} años, número de socio {NumeroSocio}";
        }
    }
}
