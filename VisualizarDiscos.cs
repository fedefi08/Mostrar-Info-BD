using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexcionBdDiscos
{
    internal class VisualizarDiscos
    {
        public List<Discos> Listar()
        {
            List<Discos> lista = new List<Discos>();

            string cadenaConexion = "server=MSI\\SQLEXPRESS; database=DISCOS_DB; integrated security=true;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "select titulo as Nombre, cantidadCanciones as CantCanciones from discos";

                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {

                            Discos aux = new Discos
                            {
                                Nombre = Convert.ToString(lector["Nombre"]),
                                CantCanciones = lector.GetInt32(1)
                            };

                            lista.Add(aux);

                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Lanza la excepción para manejarla en el formulario
                    throw new Exception($"Error al obtener la lista de discos: {ex.Message}");
                }
            }

            return lista;
        }


    }
}
