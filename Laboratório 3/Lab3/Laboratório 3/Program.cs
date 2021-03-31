using System;

namespace Laboratório_3
{
    class Program
    {


        static void Main(string[] args)
        {
            //List<Produto> ProdutosDaLoja = new List<Produto>();
            Produto[] produtos = new Produto[7];

            produtos[0] = new Games("The Jackbox Party Pack", "jogo do careca", "PC", 45.99f);
            produtos[1] = new Games("The Jackbox Party Pack 2", "jogo do careca pacote 2", "PC", 45.99f);
            produtos[2] = new Games("The Jackbox Party Pack 3", "jogo do careca pacote 3", "PC", 45.99f);
            produtos[3] = new Games("Oriental Knight", "jogo do Israel", "PC", 199.99f);
            produtos[4] = new Livro("As melhores histórias da mitologia", "A.S Franchini / Carmen Seganfredo", 16.15f);
            produtos[5] = new Livro("Demian", "Herman Hesse", 23.67f);
            produtos[6] = new Livro("O Herói de Mil Faces", "Joseph Campbell", 49.49f);


            void Comprar(Produto p)
            {
                p.InformaDescription();
                p.InformaPreco();
                Console.WriteLine();


            }

            foreach (var item in produtos)
                Comprar(item);






        }

    }
}
