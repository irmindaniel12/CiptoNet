using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositorios
{
    public class HistorialRepositorio : IRepository<Historial>
    {
        string ConnectionString;

        public HistorialRepositorio(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public void Actualizar(Historial entity)
        {
            try
            {
                string queryParameters = $"@TipoDeTransaccion,@Descripcion,@Fecha,@Usuario,@FechaCreacion,@Borrado";
                string queryString =
        $"UPDATE Categoria SET  TipoDeTransaccion=@TipoDeTransaccion" +
        $",Descripcion=@Descripcion" +
        $",Fecha=@Fecha," +
        $"Usuario=@Usuario," +
        $"FechaCreacion=@FechaCreacion," +
        $"Borrado=@Borrado) WHERE Id=@Id)";

                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.Parameters.AddWithValue("@TipoDeTransaccion", entity.TipoDeTransaccion);
                    cmd.Parameters.AddWithValue("@Descripcion", entity.Descripcion);
                    cmd.Parameters.AddWithValue("@Fecha",DateTime.Now);
                    cmd.Parameters.AddWithValue("@Usuario","Demo");
                    cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Borrado", entity.Borrado);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                string queryString =
                $"UPDATE Historial SET  Borrado=@Borrado WHERE Id=@Id";

                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Activo", false);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Historial Get(int Id)
        {
            string query = "SELECT * FROM CriptoNet WHERE Id=" + Id;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    Historial entity = new Historial();
                    while (reader.Read())
                    {
                        entity.Id = (int)reader["Id"];
                        entity.TipoDeTransaccion = (string)reader["TipoDeTransaccion"];
                        entity.Descripcion = (string)reader["Descripcion"];
                        entity.Fecha = (DateTime)reader["Fecha"];
                        entity.Usuario = (string)reader["Usuario"];
                        entity.FechaCreacion = (DateTime)reader["FechaCreacion"];
                        entity.Borrado = (bool)reader["Borrado"];
                    }
                    reader.Close();

                    return entity;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<Historial> GetAll()
        {
            string query = "SELECT * FROM Historial";

            using (SqlConnection conn = new SqlConnection(this.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Historial> Bitaco = new List<Historial>();
                    while (reader.Read())
                    {
                        Historial entity = new Historial();

                        entity.Id = (int)reader["Id"];
                        entity.TipoDeTransaccion = (string)reader["TipoDeTransaccion"] ;
                        entity.Descripcion = (string)reader["Descripcion"];
                        entity.Fecha = (DateTime)reader["Fecha"];
                        entity.Usuario = (string)reader["Usuario"];
                        entity.FechaCreacion = (DateTime)reader["FechaCreacion"];
                        entity.Borrado = (bool)reader["Borrado"];

                        Bitaco.Add(entity);


                    }
                    reader.Close();

                    return Bitaco;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Insertar(Historial entity)
        {
            try
            {
                string queryParameters = $"@TipoDeTransaccion,@Descripcion,@Fecha,@Usuario,@FechaCreacion,@Borrado";
                string queryString =
        $"INSERT INTO Historial (TipoDeTransaccion,Descripcion,Fecha,Usuario,FechaCreacion,Borrado) VALUES({queryParameters})";

                using (SqlConnection conn = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.AddWithValue("@TipoDeTransaccion", entity.TipoDeTransaccion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@Usuario", entity.Usuario ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@FechaCreacion", entity.FechaCreacion);
                    cmd.Parameters.AddWithValue("@Borrado", entity.Borrado);
                    conn.Open();
                    cmd.ExecuteScalar();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
