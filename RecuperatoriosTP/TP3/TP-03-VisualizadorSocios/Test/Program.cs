using System;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //damos de alta un club
            Club club = new Club("Club de ejemplo");

            //damos de alta 2 socios pero no los agregamos a la lista
            Completo socioCompleto = new Completo("Cosme", "Fulanito", "3164975", EProvincia.Cordoba, "M", 22, 912, 500, ETribuna.Centenario, 20, DateTime.Now, true);
            Simple socioSimple = new Simple("John", "Doe", "9122018", EProvincia.Mendoza, "M", 31, 301, 1500, DateTime.Now, true);

            //agregamos un socio simple
            club += socioSimple;
            //Imprimimos la lista
            Console.WriteLine(club.ListadoSociosActivos());

            Console.WriteLine("---------");
            //agregamos un socio completo
            club += socioCompleto;
            //Imprimimos la lista
            Console.WriteLine(club.ListadoSociosActivos());

            Console.WriteLine("---------");

            //guardamos el socio simple
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = System.IO.Path.Combine(rutaEscritorio, "SociosDeEjemplo.txt");

            Archivadora.EscribirTxt(rutaArchivo, socioSimple.MostrarInformacion());

            //lo damos de baja
            Socio socioAux = club.BuscarSocio(912);
            socioAux.Activo = false;

            //imprimimos nuevamente la lista 
            Console.WriteLine(club.ListadoSociosActivos());

            //Agregamos 2 socios completos mas y vemos la provincia y tribuna con mas socios 
            Completo socioCompleto2 = new Completo("Segundo", "socio", "3164975", EProvincia.Mendoza, "F", 45, 111, 500, ETribuna.Sivori, 20, DateTime.Now, true);
            Completo socioCompleto3 = new Completo("Ivael", "Tercero", "9495620", EProvincia.Cordoba, "M", 50, 123, 500, ETribuna.Centenario, 20, DateTime.Now, true);

            club += socioCompleto2;
            club += socioCompleto3;

            //mostramos la tribuna con más socios
            Console.WriteLine(club.TribunaMasSocios());
            Console.WriteLine("---------");


            //mostramos la provincia con más socios
            Console.WriteLine(club.ProvinciaMasSocios());
            Console.WriteLine("---------");

            //por último mostramos los ingresos mensuales
            Console.WriteLine($"Los ingresos mensuales son ${club.IngresosPorMes()}");

            Console.ReadKey();
        }
    }
}
