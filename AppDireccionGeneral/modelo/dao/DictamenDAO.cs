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
    public class DictamenDAO
    {
        public static void registrarDicatmen(Dictamen dictamen)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    String fecha = dictamen.FechaHora.ToString("yyyy-MM-dd");
                    String hora = dictamen.FechaHora.ToString("HH:mm:ss");
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("INSERT INTO SistemaVehicular.dbo.Dictamen " +
                        "(descripcion, fechaHora, idReporte, idUsuario) " +
                        "VALUES('{0}', '{1}', {2}, {3});",
                        dictamen.Descripcion, fecha + " " + hora, dictamen.IdReporte, dictamen.IdUsuario);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción DictamenDAO registrarDicatmen(Dictamen dictamen):");
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
        }

    }
}
