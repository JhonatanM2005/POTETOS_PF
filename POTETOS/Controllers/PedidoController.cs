using POTETOS.Models;
using POTETOS.Models.Data;
using POTETOS.Properties;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POTETOS.Controllers
{
    public class PedidoController
    {
        private readonly PedidoModel _pedidoModel;

        public PedidoController()
        {
            _pedidoModel = new PedidoModel();
        }

        public async Task<int> CrearPedido(Pedido pedido)
        {
            try
            {
                return await Task.Run(() => _pedidoModel.CrearPedido(pedido));
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear pedido: " + ex.Message);
            }
        }

        public async Task<bool> ActualizarPedido(Pedido pedido)
        {
            try
            {
                return await Task.Run(() => _pedidoModel.ActualizarEstado(pedido.IdPedido, pedido.Estado));
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar pedido: " + ex.Message);
            }
        }

        public List<DetallePedido> ObtenerDetallePedido(int idPedido)
        {
            try
            {
                return _pedidoModel.ObtenerDetallePedido(idPedido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalle del pedido: " + ex.Message);
            }
        }

        public Pedido ObtenerPedidoActivo(int idMesa)
        {
            try
            {
                // Implementar la lógica para obtener el pedido activo de una mesa
                // Este método debería agregarse en PedidoModel
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener pedido activo: " + ex.Message);
            }
        }
    }
}