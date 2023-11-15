using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace SQL
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private static string cadena_conexion;
        private SqlCommand comando; //con este objeto realizas la consulta
        private SqlDataReader lector; //Contiene lo que te devuelve la consulta sql

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=test_bd;Integrated Security=True;Trust Server Certificate=True";
            //AccesoDatos.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoDatos()
        {

            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }
    }
}