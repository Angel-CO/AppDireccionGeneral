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
    public class ConductorDAO
    {
        public static List<Conductor> getConductores(Reporte reporte)
        {
            List<Conductor> conductores = new List<Conductor>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT c.idConductor, c.nombre, " +
                        "c.apellidoPaterno, c.apellidoMaterno, " +
                        "c.fechaNacimiento, c.numLicencia, c.telefono " +
                        "FROM SistemaVehicular.dbo.Conductor c " +
                        "INNER JOIN SistemaVehicular.dbo.Conductor_Reporte cr " +
                        "ON c.idConductor = cr.Conductor_idConductor " +
                        "WHERE cr.Reporte_idReporte = {0};", reporte.IdReporte);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Conductor conductor = new Conductor();

                        conductor.IdConductor = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        conductor.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        conductor.ApellidoPaterno = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        conductor.ApellidoMaterno = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        conductor.FechaNacimiento = (!dataReader.IsDBNull(4)) ? dataReader.GetDateTime(4) : new DateTime();
                        conductor.NumLicencia = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        conductor.Telefono = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";

                        conductores.Add(conductor);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción ConcdutorDAO getConductores(Reporte reporte):");
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
            return conductores;
        }

    }
}
