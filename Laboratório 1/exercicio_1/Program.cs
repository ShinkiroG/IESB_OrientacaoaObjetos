using System;

namespace exercicio_1
{


    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float peso, altura, imc, metaMin, metaMax, perder, ganhar;

            //coleta das informações
            Console.WriteLine("Seja bem vindo ao registro da academia ACME");

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite seu peso:");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite sua altura:");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Aperte qualquer tecla para exibir o resultado");
            Console.ReadLine();
            Console.WriteLine();


            //Exibe as informações
            Console.WriteLine("Cliente: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Altura: " + altura);


            //Calcula o IMC
            imc = (peso / (altura * altura));

            if (imc < 18.5)
                Console.WriteLine("Peso abaixo do normal, peça uma pizza!");
            else if ((imc < 18.5) && (imc > 24.9))
                Console.WriteLine("Parabéns " + nome + " você está em seu peso normal!");
            else if ((imc > 25) && (imc < 29.9))
                Console.WriteLine("Você está acima de seu peso (sobrepeso).");
            else if ((imc > 30) && (imc < 34.9))
                Console.WriteLine("Obesidade grau I.");
            else if ((imc > 35) && (imc < 39.0))
                Console.WriteLine("Obesidade grau II.");
            else if (imc > 40)
                Console.WriteLine("Obesidade grau III e IV.");

            //Meta de peso
            metaMin = ((altura * altura) * 18.5f);
            metaMax = ((altura * altura) * 24.9f);

            //Você precisar ganhar/perder X
            perder = peso - metaMax;
            ganhar = metaMin - peso;
            
            //Resultado
            Console.WriteLine("Seu peso ideal é entre: " + metaMin + "kg e " + metaMax + "kg");
            if (imc > 18.5)
                Console.WriteLine("Você precisa perder pelo menos " + perder + "kg");
            else if (imc < 18.5)
                Console.WriteLine("Você precisa ganhar pelo menos " + ganhar + "kg");
        }
    }
}
