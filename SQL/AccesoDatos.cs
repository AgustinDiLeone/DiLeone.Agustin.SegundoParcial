using Microsoft.Data.SqlClient;
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
            //AccesoDatos.cadena_conexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=SegundoParcial;Integrated Security=True;Trust Server Certificate=True";
            AccesoDatos.cadena_conexion = Properties.Resources.miConexion;
        }
        public AccesoDatos()
        {

            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }
        public bool ProbarConexion()
        {
            bool retorno = false;

            try
            {
                this.conexion.Open();
                retorno = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }

            }

            return retorno;
        }

        public List<ClienteSql> ObtenerListaCliente()
        {
            List<ClienteSql> lista = new List<ClienteSql>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "Select Id,Nombre,Cuit,Ubicacion,Tipo from ClienteSql";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = this.comando.ExecuteReader(); //La que retorna informacion, tipo select

                while (this.lector.Read()) //devuelve true si tiene mas para leer
                {
                    ClienteSql cliente = new ClienteSql();
                    cliente.id = (int)this.lector[0]; //le indicas el nombre de la columna
                    cliente.nombre = this.lector[1].ToString(); // le indicas el indice
                    cliente.cuit = (long)this.lector[2];
                    cliente.ubicacion = this.lector[3].ToString();
                    cliente.tipo = this.lector[4].ToString();

                    lista.Add(cliente);
                }

                this.lector.Close();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;

        }

        public bool AgregarCliente(ClienteSql cliente)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "Insert into ClienteSql(Nombre,Cuit,Ubicacion,Tipo) values('" + cliente.nombre + "'," + cliente.cuit + ",'" + cliente.ubicacion + "','" + cliente.tipo + "')";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                
                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                    retorno = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }
        public bool ModificarCliente(ClienteSql cliente)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Id", cliente.id);
                this.comando.Parameters.AddWithValue("@Nombre", cliente.nombre);
                this.comando.Parameters.AddWithValue("@Cuit", cliente.cuit);
                this.comando.Parameters.AddWithValue("@Ubicacion", cliente.ubicacion);
                this.comando.Parameters.AddWithValue("@Tipo", cliente.tipo);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "Update ClienteSql Set nombre = @Nombre, cuit = @Cuit , ubicacion = @Ubicacion where id = @Id";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }
        public bool EliminarCliente(ClienteSql cliente)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", cliente.id);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "DELETE FROM ClienteSql WHERE id = @Id"; ;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return retorno;
        }
    }
}