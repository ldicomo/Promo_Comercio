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
    public class ProductoNegocio
    {
        public List<Producto> listarProducto()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Producto> listado = new List<Producto>();
            Producto producto;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Titulo, Descripcion, URLImagen From Productos";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    producto = new Producto();
                    producto.Id = lector.GetInt64(0);
                    producto.Titulo = lector.GetString(1);
                    producto.Descripcion = lector.GetString(2);
                    producto.URLImagen = lector.GetString(3);

                    listado.Add(producto);
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

        public void agregarProducto(Producto nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into Productos (Titulo, Descripcion, URLImagen) values";
                comando.CommandText += "('" + nuevo.Titulo + "', '" + nuevo.Descripcion + "', '" + nuevo.URLImagen + "')";
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
