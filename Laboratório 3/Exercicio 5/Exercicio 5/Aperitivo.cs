using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Aperitivo : ItensMenu
    {
        public double Preco { get; private set; }


        public Aperitivo (string nome, double preco) : base(nome)
        {
            Preco = preco;

        }


        public override void ImprimirPreco()
        {
            ImprimirNome();
            Console.WriteLine($"Preço {Preco:C}");
        }
    }
}
