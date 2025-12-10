using System.Data.SqlClient;
using System.IO;

namespace Proyecto_final.Clases
{
    internal class DBConnection
    {
        //Método para obtener la conexión
        public static SqlConnection GetConnection()
        {
            //Leer la cadena desde el archivo secreto
            string connectionString = File.ReadAllText("connection.secret.txt");
            return new SqlConnection(connectionString);
        }
    }
}
