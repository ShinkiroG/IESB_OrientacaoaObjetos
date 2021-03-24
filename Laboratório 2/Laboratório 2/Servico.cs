using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_2
{
    class Servicos
    {

        public void Sacar(float valor, Conta saldo)
        {
            if (valor <= 0 || saldo.saldo < valor + saldo.taxaSaque * valor)
            {
                Console.WriteLine("Operação Inválida");
                return;
            }
            saldo.mudarSaldo(-(valor + saldo.taxaSaque * valor));
        }


        public void Depositar(float valor, Conta cliente)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Operação Inválida");
                return;
            }
            cliente.mudarSaldo(valor);
        }

        public void Transferir(float valor, Conta remetente, Conta destinario)
        {
            if (valor <= 0 || remetente.saldo < valor + valor * remetente.taxaTransf)
            {
                Console.WriteLine("Operação Inválida");
                return;
            }
            remetente.mudarSaldo(-(valor + valor * remetente.taxaTransf));
            destinario.mudarSaldo(valor);
        }
    }
}
