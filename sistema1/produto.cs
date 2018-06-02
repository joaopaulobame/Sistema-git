using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema1
{
    class produto : IComparable
    {
        public int codigo { get; private set; }
        public string nome { get; private set; }
        public double preco { get; private set; }

        public produto (int codigo, string nome, double preco)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
        }

        public override string ToString()
        {
            return codigo
                + ","
                + nome
                + ","
                + preco.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            produto outro = (produto)obj;
            int resultado = nome.CompareTo(outro.nome);
        }
    }
}