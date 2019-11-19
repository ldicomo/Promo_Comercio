using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listarCliente()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Cliente> listado = new List<Cliente>();
            Cliente cliente;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Dni, Nombre, Apellido, Email, Domicilio, Ciudad, CodigoPostal From Clientes";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    cliente = new Cliente();
                    cliente.Id = lector.GetInt64(0);
                    cliente.Dni = lector.GetInt64(1);
                    cliente.Nombre = lector.GetString(2);
                    cliente.Apellido = lector.GetString(3);
                    cliente.Email = lector.GetString(4);
                    cliente.Domicilio = lector.GetString(5);
                    cliente.Ciudad = lector.GetString(6);
                    cliente.CodigoPostal = lector.GetString(7);

                    listado.Add(cliente);
                }

                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void agregarCliente(Cliente nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Clientes (Dni, Nombre, Apellido, Email, Domicilio, Ciudad, CodigoPostal) values";
                comando.CommandText += "('" + nuevo.Dni + "', '" + nuevo.Nombre + "', '" + nuevo.Apellido + "', '" + nuevo.Email + "', '" + nuevo.Domicilio + "', '" + nuevo.Ciudad + "', '" + nuevo.CodigoPostal + "')";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
