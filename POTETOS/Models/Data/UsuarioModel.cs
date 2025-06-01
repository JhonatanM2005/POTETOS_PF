using POTETOS.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POTETOS.Models.Data
{
    public class UsuarioModel
    {
        private DatabaseConnection dbConnection;

        public UsuarioModel()
        {
            dbConnection = DatabaseConnection.Instance;
        }

        // CRUD Operations
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Usuarios WHERE Activo = 1";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuarios.Add(new Usuario
                    {
                        IdUsuario = (int)reader["IdUsuario"],
                        Identificacion = reader["Identificacion"].ToString(),
                        NombreCompleto = reader["NombreCompleto"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        NombreUsuario = reader["NombreUsuario"].ToString(),
                        Contrasena = reader["Contrasena"].ToString(),
                        TipoUsuario = reader["TipoUsuario"].ToString()
                    });
                }
            }

            return usuarios;
        }

        public bool Insertar(Usuario usuario)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Usuarios (Identificacion, NombreCompleto, Telefono, 
                           NombreUsuario, Contrasena, TipoUsuario) 
                           VALUES (@Identificacion, @NombreCompleto, @Telefono, 
                           @NombreUsuario, @Contrasena, @TipoUsuario)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Identificacion", usuario.Identificacion);
                cmd.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@TipoUsuario", usuario.TipoUsuario);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Actualizar(Usuario usuario)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = @"UPDATE Usuarios SET Identificacion = @Identificacion, 
                           NombreCompleto = @NombreCompleto, Telefono = @Telefono,
                           NombreUsuario = @NombreUsuario, Contrasena = @Contrasena,
                           TipoUsuario = @TipoUsuario WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@Identificacion", usuario.Identificacion);
                cmd.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@TipoUsuario", usuario.TipoUsuario);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int idUsuario)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = "UPDATE Usuarios SET Activo = 0 WHERE IdUsuario = @IdUsuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Usuario ValidarCredenciales(string nombreUsuario, string contrasena)
        {
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                string query = @"SELECT * FROM Usuarios 
                           WHERE NombreUsuario = @NombreUsuario 
                           AND Contrasena = @Contrasena AND Activo = 1";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario
                    {
                        IdUsuario = (int)reader["IdUsuario"],
                        Identificacion = reader["Identificacion"].ToString(),
                        NombreCompleto = reader["NombreCompleto"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        NombreUsuario = reader["NombreUsuario"].ToString(),
                        TipoUsuario = reader["TipoUsuario"].ToString()
                    };
                }

                return null;
            }
        }

        public Usuario ValidateCredentials(string username, string password)
        {
            var query = "SELECT * FROM Usuarios WHERE Username = @Username AND Password = @Password";
            var parameters = new Dictionary<string, object>
            {
                { "@Username", username },
                { "@Password", password }
            };

            var result = ExecuteQuery(query, parameters).FirstOrDefault();
            return result;
        }

        public List<Usuario> ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conn = dbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuarios.Add(new Usuario
                    {
                        IdUsuario = (int)reader["IdUsuario"],
                        Identificacion = reader["Identificacion"].ToString(),
                        NombreCompleto = reader["NombreCompleto"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        NombreUsuario = reader["NombreUsuario"].ToString(),
                        TipoUsuario = reader["TipoUsuario"].ToString()
                    });
                }
            }

            return usuarios;
        }
    }
}
