using POTETOS.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace POTETOS.Models.Data
{
    internal class PedidoModel
    {
        private readonly DatabaseConnection _db;

        public PedidoModel(DatabaseConnection db = null)
        {
            _db = db ?? DatabaseConnection.Instance;
        }

        public int CrearPedido(Pedido pedido)
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_CrearPedido", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdMesa", pedido.IdMesa);
                        cmd.Parameters.AddWithValue("@IdMesero", pedido.IdMesero);
                        cmd.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                        cmd.Parameters.AddWithValue("@Estado", pedido.Estado);

                        var paramIdPedido = new SqlParameter("@IdPedido", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(paramIdPedido);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        return (int)paramIdPedido.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear pedido: " + ex.Message);
            }
        }

        public bool ActualizarEstado(int idPedido, string estado)
        {
            try
            {
                using (var conn = _db.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_ActualizarEstadoPedido", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPedido", idPedido);
                        cmd.Parameters.AddWithValue("@Estado", estado);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar estado del pedido: " + ex.Message);
            }
        }

        public List<DetallePedido> ObtenerDetallePedido(int idPedido)
        {
            var detalles = new List<DetallePedido>();
            try
            {
                using (var conn = _db.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_ObtenerDetallePedido", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPedido", idPedido);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                detalles.Add(new DetallePedido
                                {
                                    IdDetalle = Convert.ToInt32(reader["IdDetalle"]),
                                    IdPedido = idPedido,
                                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                    Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                    PrecioUnitario = Convert.ToDecimal(reader["Precio"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalle del pedido: " + ex.Message);
            }
            return detalles;
        }
    }
}