using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_3
{
    class Livro : Produto
    {

        public Livro(string titulo, string autoria, float preco)
        {
            this.title = titulo;
            this.description = autoria;
            this.price = preco;

        }

        public override void InformaDescription()
        {


            Console.WriteLine($"{title} \n{description}");

        }

    }
    }
