using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ItensMenu[] produtos = new ItensMenu[5];
            produtos[0] = new Bebida("Café Expresso", 3.99, 5.99, 7.99);
            produtos[1] = new Bebida("Refrigerante", 4.99, 5.99, 6.99);
            produtos[2] = new Bebida("Suco de Laranja", 5.99, 7.99, 9.99);
            produtos[3] = new Aperitivo("Coxinha", 5.99);
            produtos[4] = new Aperitivo("Pastel", 5.99);
            ImprimirCardapio(produtos);
            Console.ReadLine();
        }

        public static void ImprimirCardapio(ItensMenu[] produtos)
        {
            Console.WriteLine("-------Cardapio-------");
            foreach (ItensMenu item in produtos)
            {
                item.ImprimirPreco();
                Console.WriteLine("");
            }
        }

    }

}
