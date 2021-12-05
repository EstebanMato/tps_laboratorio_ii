using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SocioDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static SocioDAO()
        {
            connectionString = @"Data Source=.;Initial Catalog=SOCIOS_DB;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Socio> Leer()
        {
            List<Socio> listaSocios = new List<Socio>();

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM SOCIOS";
                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    if((bool)dataReader["ES_COMPLETO"] == true)
                    {
                        listaSocios.Add(new Completo(dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(), dataReader["DNI"].ToString(), (Entidades.EProvincia)(int)dataReader["ID_PROVINCIA"],
                                                dataReader["SEXO"].ToString(), (int)dataReader["EDAD"], (int)dataReader["ID_SOCIO"], (double)dataReader["COSTO_CUOTA"], (Entidades.ETribuna)(int)dataReader["ID_TRIBUNA"], (int)dataReader["CANT_DESCUENTO"], (DateTime)dataReader["FECHA_ALTA"], (bool)dataReader["ESTA_ACTIVO"]));
                    }
                    else
                    {
                        listaSocios.Add(new Simple(dataReader["NOMBRE"].ToString(), dataReader["APELLIDO"].ToString(), dataReader["DNI"].ToString(), (Entidades.EProvincia)(int)dataReader["ID_PROVINCIA"], 
                                                dataReader["SEXO"].ToString(), (int)dataReader["EDAD"], (int)dataReader["ID_SOCIO"], (double)dataReader["COSTO_CUOTA"] , (DateTime)dataReader["FECHA_ALTA"] , (bool)dataReader["ESTA_ACTIVO"]));
                    }
                }

                return listaSocios;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Guardar(Socio socio)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO SOCIOS (NOMBRE, APELLIDO, DNI, SEXO, COSTO_CUOTA, EDAD, ESTA_ACTIVO, ID_PROVINCIA, FECHA_ALTA, ES_COMPLETO, ID_TRIBUNA, CANT_DESCUENTO)" +
                    $"                  VALUES (@nombre, @apellido, @dni, @sexo, @costoCuota, @edad, @estaActivo, @idProvincia, @fechaAlta, @tipoSocio, @tribuna, @cantDescuento)";

                command.Parameters.AddWithValue("@nombre", socio.Nombre);
                command.Parameters.AddWithValue("@apellido", socio.Apellido);
                command.Parameters.AddWithValue("@dni", socio.Dni);
                command.Parameters.AddWithValue("@sexo", socio.Sexo);
                command.Parameters.AddWithValue("@costoCuota", socio.CostoCuota);
                command.Parameters.AddWithValue("@edad", socio.Edad);
                command.Parameters.AddWithValue("@estaActivo", socio.Activo);
                command.Parameters.AddWithValue("@idProvincia", (int)socio.Provincia);
                command.Parameters.AddWithValue("@fechaAlta", socio.FechaAlta);

                if(socio is Completo)
                {
                    command.Parameters.AddWithValue("@tipoSocio", 1);
                    command.Parameters.AddWithValue("@tribuna", ((Completo)socio).Tribuna);
                    command.Parameters.AddWithValue("@cantDescuento", ((Completo)socio).CantDescuento);
                }
                else
                {
                    command.Parameters.AddWithValue("@tipoSocio", 0);
                    command.Parameters.AddWithValue("@tribuna", "");
                    command.Parameters.AddWithValue("@cantDescuento", 0);
                }

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Baja(Socio socio)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE SOCIOS SET ESTA_ACTIVO = 0 WHERE ID_SOCIO  = @id";

                command.Parameters.AddWithValue("@id", socio.NumeroSocio);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
