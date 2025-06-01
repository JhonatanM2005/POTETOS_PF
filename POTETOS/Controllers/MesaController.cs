using POTETOS.Models;
using POTETOS.Models.Data;
using POTETOS.Properties;
using System;
using System.Collections.Generic;

namespace POTETOS.Controllers
{
    public class MesaController
    {
        private readonly MesaModel _mesaModel;

        public MesaController()
        {
            _mesaModel = new MesaModel();
        }

        public List<Mesa> ObtenerTodasLasMesas()
        {
            try
            {
                return _mesaModel.ObtenerTodas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener mesas: " + ex.Message);
            }
        }

        public bool ActualizarMesa(Mesa mesa)
        {
            try
            {
                return _mesaModel.ActualizarEstado(mesa.IdMesa, mesa.Estado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar mesa: " + ex.Message);
            }
        }

        public Mesa ObtenerMesa(int idMesa)
        {
            try
            {
                return _mesaModel.ObtenerTodas().Find(m => m.IdMesa == idMesa);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener mesa: " + ex.Message);
            }
        }
    }
}