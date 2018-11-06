using Supremo.Util.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supremo.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        private ICollection<ItemPedido> itensPedido;

        public ICollection<ItemPedido> GetItensPedido()
        {
            return itensPedido;
        }

        public void SetItensPedido(ICollection<ItemPedido> value)
        {
            itensPedido = value;
        }
    }
}
