using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POTETOS.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdMesa { get; set; }
        public int IdMesero { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } // "En cocina", "Listo", "Entregado"
    }
}
