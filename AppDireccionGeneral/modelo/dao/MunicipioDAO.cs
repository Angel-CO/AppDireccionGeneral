using AppDireccionGeneral.modelo.db;
using AppDireccionGeneral.modelo.poco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppDireccionGeneral.modelo.dao
{
    class MunicipioDAO
    {
        public static List<Municipio> getAllMunicipios()
        {
            List<Municipio> municipios = new List<Municipio>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT m.idMunicipio, m.nombre " +
                        "FROM SistemaVehicular.dbo.Municipio m;";
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Municipio municipio = new Municipio();

                        municipio.IdMunicipio = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        municipio.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        municipios.Add(municipio);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción MunicipioDAO getAllMunicipios():");
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------------------------\n");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return municipios;
        }
    }
}
