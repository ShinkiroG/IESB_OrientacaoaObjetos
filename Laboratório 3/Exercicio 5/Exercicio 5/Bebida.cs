using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Bebida : ItensMenu
    {


        public double PrecoPeq { get; set; }
        public double PrecoMed { get; set; }
        public double PrecoGran { get; set; }

        public Bebida(string nome, double precoPeq, double precoMed, double precoGran ) : base(nome)
        {
            PrecoGran = precoGran;
            PrecoMed = precoMed;
            PrecoPeq = precoPeq;
        }


        public override void ImprimirPreco()
        {
            ImprimirNome();
            Console.WriteLine($"P {PrecoPeq:C}");
            Console.WriteLine($"M {PrecoMed:C}");
            Console.WriteLine($"G {PrecoGran:C}");
        }


    }
}
