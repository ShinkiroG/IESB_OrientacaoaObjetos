using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class ItensMenu
    {

        public string Nome { get; protected set; }
        float price;

        public ItensMenu (string nome)
        {
            Nome = nome;


        }

        public void ImprimirNome()
        {
            Console.WriteLine($"Produto: {Nome}");
        }

        public virtual void ImprimirPreco()
        {
            Console.WriteLine($"{price}");

        }



    }
}
