using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema1
{
    class itemPedido
    {
        public int quantidade { get; private set; }
        public double porcentagemDesconto { get; private set; }
        produto produto;

        public itemPedido (int quantidade, double porcentagemDesconto, produto produto)
        {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.produto = produto;
        }

        public double subTotal()
        {
            return 0;
        }
    }
}
