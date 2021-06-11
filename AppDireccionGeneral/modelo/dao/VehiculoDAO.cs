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
    public class VehiculoDAO
    {
        public static List<Vehiculo> getVehiculos(Reporte reporte)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT v.idVehiculo, v.marca, v.modelo, v.anio, v.color, " +
                        "v.nombreAseguradora, v.numPolizaSeguro, " +
                        "v.numPlaca, v.idConductor, c.nombre, c.apellidoPaterno, c.apellidoMaterno " +
                        "FROM SistemaVehicular.dbo.Vehiculo v " +
                        "INNER JOIN SistemaVehicular.dbo.Conductor c " +
                        "ON v.idConductor = c.idConductor " +
                        "INNER JOIN SistemaVehicular.dbo.Vehiculo_Reporte vr " +
                        "ON v.idVehiculo = vr.Vehiculo_idVehiculo " +
                        "WHERE vr.Reporte_idReporte = {0};", reporte.IdReporte);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Vehiculo vehiculo = new Vehiculo();

                        vehiculo.IdVehiculo = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        vehiculo.Marca = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        vehiculo.Modelo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        vehiculo.Anio = (!dataReader.IsDBNull(3)) ? dataReader.GetInt32(3) : 0;
                        vehiculo.Color = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        vehiculo.NombreAseguradora = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        vehiculo.NumPolizaSeguro = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        vehiculo.NumPlaca = (!dataReader.IsDBNull(7)) ? dataReader.GetString(7) : "";
                        vehiculo.IdConductor = (!dataReader.IsDBNull(8)) ? dataReader.GetInt32(8) : 0;
                        String nombre = (!dataReader.IsDBNull(9)) ? dataReader.GetString(9) : "";
                        String apellidoPaterno = (!dataReader.IsDBNull(10)) ? dataReader.GetString(10) : "";
                        String apellidoMaterno = (!dataReader.IsDBNull(11)) ? dataReader.GetString(11) : "";
                        String nombreCompleto = nombre + " " + apellidoPaterno + " " + apellidoMaterno;
                        vehiculo.NombreConductor = nombreCompleto;

                        vehiculos.Add(vehiculo);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción VehiculoDAO getVehiculos(Reporte reporte):");
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
            return vehiculos;
        }
    }
}
