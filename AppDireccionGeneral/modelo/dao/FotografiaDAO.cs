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
    class FotografiaDAO
    {
        public static List<Fotografia> getFotografias(Reporte reporte)
        {
            List<Fotografia> fotografias = new List<Fotografia>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;

                    String query = String.Format("SELECT f.idFoto, f.foto, f.idReporte " +
                        "FROM SistemaVehicular.dbo.Fotografia f " +
                        "WHERE f.idReporte = {0};", reporte.IdReporte);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();


                    while (dataReader.Read())
                    {
                        Fotografia fotografia = new Fotografia();

                        byte[] buffer = new byte[0];
                        fotografia.IdFoto = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        fotografia.Foto = (!dataReader.IsDBNull(1)) ? (byte[])dataReader.GetValue(1) : new byte[0];
                        fotografia.IdReporte = (!dataReader.IsDBNull(2)) ? dataReader.GetInt32(2) : 0;

                        fotografias.Add(fotografia);
                    }

                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción FotografiaDAO getFotografias(Reporte reporte)");
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
            return fotografias;
        }

    }
}
