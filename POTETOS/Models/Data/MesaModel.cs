using POTETOS.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace POTETOS.Models.Data
{
    internal class MesaModel
    {
        private readonly DatabaseConnection _db;

        public MesaModel(DatabaseConnection db = null)
        {
            _db = DatabaseConnection.Instance; // Cambiado para usar la instancia singleton
        }

        public List<Mesa> ObtenerTodas()
        {
            var mesas = new List<Mesa>();
            try
            {
                using (var conn = _db.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_ObtenerMesas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mesas.Add(new Mesa
                                {
                                    IdMesa = Convert.ToInt32(reader["IdMesa"]),
                                    NumeroMesa = Convert.ToInt32(reader["NumeroMesa"]),
                                    Estado = reader["Estado"].ToString()
                                    // Eliminado UltimaActualizacion ya que no existe en la clase Mesa
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener mesas: " + ex.Message);
            }
            return mesas;
        }

        public bool ActualizarEstado(int idMesa, string estado)
        {
            try
            {
                using (SqlConnection conn = _db.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_ActualizarEstadoMesa", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdMesa", idMesa);
                        cmd.Parameters.AddWithValue("@NuevoEstado", estado);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error al actualizar estado de mesa: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar estado de mesa: " + ex.Message);
            }
        }
    }
}