using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3
{
    class Games : Produto
    {
        public string plataforma;

        public Games(string titulo, string descricao, string plataformaB, float preco)
        {
            this.title = titulo;
            this.description = descricao;
            this.price = preco;
            this.plataforma = plataformaB;

        }

        public override void InformaDescription()
        {


            Console.WriteLine($"{title} {plataforma} \n{description}");


        }



    }
}
