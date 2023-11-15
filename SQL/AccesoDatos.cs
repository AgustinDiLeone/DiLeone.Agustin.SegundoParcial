using Microsoft.Data.SqlClient;
using Entidades;
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

        public List<Cliente> ObtenerListaCliente()
        {
            List<Cliente> lista = new List<Cliente>();

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
                    Cliente cliente = new Cliente();
                    cliente.Nombre = this.lector[1].ToString(); // le indicas el indice
                    cliente.Cuit = (long)this.lector[2];
                    cliente.Ubicacion = this.lector[3].ToString();
                    cliente.TipoCliente = (ETipos)Enum.Parse(typeof(ETipos), (string)this.lector[4]);
                    
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

        public bool AgregarCliente(Cliente cliente)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "Insert into ClienteSql(Nombre,Cuit,Ubicacion,Tipo) values('" + cliente.Nombre + "'," + cliente.Cuit + ",'" + cliente.Ubicacion + "','" + cliente.TipoCliente + "')";
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
        public bool ModificarCliente(Cliente clienteViejo, Cliente cliente)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                this.comando.Parameters.AddWithValue("@Cuit", cliente.Cuit);
                this.comando.Parameters.AddWithValue("@Ubicacion", cliente.Ubicacion);
                this.comando.Parameters.AddWithValue("@Tipo", cliente.TipoCliente);
                this.comando.Parameters.AddWithValue("@NombreViejo", clienteViejo.Nombre);
                this.comando.Parameters.AddWithValue("@CuitViejo", clienteViejo.Cuit);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"Update ClienteSql Set Nombre = @Nombre, Cuit = @Cuit , Ubicacion = @Ubicacion where Nombre = @NombreViejo AND Cuit = @CuitViejo";
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
        public bool EliminarCliente(Cliente cliente)
        {
            bool retorno = false;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                this.comando.Parameters.AddWithValue("@Cuit", cliente.Cuit);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "DELETE FROM ClienteSql WHERE Nombre = @Nombre AND Cuit = @Cuit";
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