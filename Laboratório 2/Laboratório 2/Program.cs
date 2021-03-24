using System;

namespace Laboratório_2
{

    //P.S.(1) Essas operações devem ser simuladas em uma classe de teste.
    //P.S.(2) Deseja-se que sejam explorados todos pilares da POO além da utilização de construtores específicos.

    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente BobNelson = new ContaCorrente("Bob Nelson", 12345, 0);
            ContaCorrente LisaLeite = new ContaCorrente("Lisa Leite", 65432, 0);
            ContaPoupança Testolfo = new ContaPoupança("Testolfo Rocha", 71717, 0);

            Servicos serviços = new Servicos();

            //bob nelson deposita 5k
            serviços.Depositar(5000, BobNelson);
            MostraSaldo();

            //lisa deposita 2k
            serviços.Depositar(2000, LisaLeite);
            MostraSaldo();

            //Testolfo deposita 1500
            serviços.Depositar(1500, Testolfo);
            MostraSaldo();

            //Bob transfere 600 pra testolfo
            serviços.Transferir(600, BobNelson, Testolfo);
            MostraSaldo();

            //Lisa sacou 250
            serviços.Sacar(250, LisaLeite);
            MostraSaldo();

            //Lisa transfere pra testolfo
            serviços.Transferir(400, LisaLeite, Testolfo);
            MostraSaldo();

            //Testolfo transfere pra bob nelson 1000R$
            serviços.Transferir(1000, Testolfo, BobNelson);
            MostraSaldo();

            //Bob sacou 900
            serviços.Sacar(900, BobNelson);
            MostraSaldo();

            //Bob transfere 1500 Lisa leite
            serviços.Transferir(1500, BobNelson, LisaLeite);
            MostraSaldo();

            //testolfo transfere 1200 pra lisa
            serviços.Transferir(1200, Testolfo, LisaLeite);
            MostraSaldo();

            //bob saca 2000
            serviços.Sacar(2000, BobNelson);
            MostraSaldo();

            //Lisa deposita 100
            serviços.Depositar(100, LisaLeite);
            MostraSaldo();

            //testolfo transfere 700 para bob
            serviços.Transferir(700, Testolfo, BobNelson);
            MostraSaldo();

            void MostraSaldo()
            {
                Console.WriteLine(BobNelson.saldo.ToString("N2")  + "  saldo bob");
                Console.WriteLine(Testolfo.saldo.ToString("N2") + "  saldo testolfo");
                Console.WriteLine(LisaLeite.saldo.ToString("N2") + "  saldo lisa");
                Console.WriteLine();
            }
        }
    }

}
