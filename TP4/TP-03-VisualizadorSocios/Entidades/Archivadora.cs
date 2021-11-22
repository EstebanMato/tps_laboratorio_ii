using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Por practicidad se utilizaron tipo genéricos y archivos en conjunto para poder 4
    /// Serializar y Deserealizar la información, y así aprovechar las funcionalidades, por ejemplo
    /// </summary>
    public static class Archivadora
    {
        /// <summary>
        /// Crea un archivo txt segun la ruta y los datos pasados como parametros
        /// </summary>
        /// <param name="path">Ruta dodne escribir</param>
        /// <param name="datos">Datos a escribir</param>
        /// <returns></returns>
        public static bool EscribirTxt(string path, string datos)
        {
            bool returnAux = false;

            try
            {
                StreamWriter escribir = new StreamWriter(path);

                using (escribir)
                {
                    escribir.WriteLine(datos);
                    if (File.Exists(path))
                        returnAux = true;
                }
                return returnAux;
            }
            catch (ArgumentNullException)
            {
                throw new PathException("No fue seleccionado el informe a exportar y su ruta", "Archivadora", "Escribir Txt");
            }

        }

        /// <summary>
        /// Lee el archivo txt segun la ruta pasada como parametro
        /// </summary>
        /// <param name="path">ruta del archivo txt</param>
        /// <returns>Retorna lo que pudo leer, caso contrario vacio en formato string</returns>
        public static string LeerTxt(string path)
        {
            string texto = "";

            if (File.Exists(path))
            {
                StreamReader leer = new StreamReader(path);
                texto += leer.ReadToEnd();

            }

            return texto;
        }


        /// <summary>
        /// Serializador genérico donde recibe un objeto no importa el tipo y lo serializa en formato xml
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="objeto">obejot</param>
        /// <param name="path">ruta donde guarda</param>
        /// <returns></returns>
        public static bool SerializarXml<T>(T objeto, string path)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            XmlTextWriter escritor = new XmlTextWriter(path, Encoding.UTF8);
            bool returnAux = true;
            using (escritor)
            {
                try
                {
                    serializador.Serialize(escritor, objeto);
                }
                catch
                {
                    //aca podriamos lanzar otra excepcion
                    returnAux = false;
                }
            }

            return returnAux;
        }

        /// <summary>
        /// Deserializador genérico donde recibe un objeto no importa el tipo y lo desserializa desde un formato xml
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="path">ruta del archivo</param>
        /// <returns></returns>
        public static T DeserializarXml<T>( string path)
        {
            if (!File.Exists(path))
                return default;

            XmlTextReader lector = new XmlTextReader(path);
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            T returnAux = default(T);

            using (lector)
            {
                try
                {
                    returnAux = (T)serializador.Deserialize(lector);
                }
                catch
                {
                    return default;
                }
            }
            return returnAux;
        }
    }
}
