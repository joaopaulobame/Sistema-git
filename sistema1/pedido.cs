using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema1
{
    class pedido
    {
        public int codigo { get; private set; }
        public DateTime data { get; private set; }
        public itemPedido itemPedido { get; private set; }

        public pedido(int codigo, DateTime data, itemPedido itemPedido)
        {
            this.codigo = codigo;
            this.data = data;
            this.itemPedido = itemPedido;
        }

        public double valorTotal()
        {
            return 0;
        }

    }
}
