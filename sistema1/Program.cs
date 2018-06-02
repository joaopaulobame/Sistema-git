using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema1
{
    class Program
    {

        public static List<produto> produtos = new List<produto>();
        

        static void Main(string[] args)
        {
            int op = 0;
            // lista com produtos já cadastrados         
            produtos.Add(new produto(1001, "Cadeira simples", 500.00));
            produtos.Add(new produto(1002, "Cadeira acolchoada", 900.00));
            produtos.Add(new produto(1003, "Sofá de três lugares", 2000.00));
            produtos.Add(new produto(1004, "Mesa retangular", 1500.00));
            produtos.Add(new produto(1005, "Mesa retangular", 2000.00));
            produtos.Sort();

            while (op != 5)
            {
                //Console.Clear();
                tela.mostrarMenu();
                

                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Write("Erro, " + ex.Message);
                }

                switch (op)
                {
                    case 1:
                        tela.mostrarProdutos();
                        break;

                    case 2:
                        Console.WriteLine("2");
                        break;

                    case 3:
                        Console.WriteLine("3");
                        break;

                    case 4:
                        Console.WriteLine("4");
                        break;

                    case 5:
                        Console.WriteLine("Sistema finalizado");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

                Console.ReadLine();

        }
    }
}
