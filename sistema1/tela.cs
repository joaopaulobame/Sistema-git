using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema1
{
    class tela
    {
        public static void mostrarMenu()
        {
            Console.WriteLine("************** MENU ****************");
            Console.WriteLine(" 1 – Listar produtos ordenadamente \r\n"
                            + " 2 – Cadastrar produto \r\n"
                            + " 3 – Cadastrar pedido \r\n"
                            + " 4 – Mostrar dados de um pedido \r\n"
                            + " 5 – Sair");
        }

        public static void mostrarProdutos()
        {
            Console.WriteLine("Listagem de produtos");
            for (int i =0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
        }
    }
}
