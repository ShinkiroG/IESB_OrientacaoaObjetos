using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratório_2
{
    public abstract class Conta
    {
        protected int numConta;
        protected string cliente;

        public float saldo { get; protected set; }
        public abstract float taxaSaque { get; }
        public abstract float taxaTransf { get; }

        public void mudarSaldo(float mSaldo)
        {
            saldo += mSaldo;
        }
    }

    public class ContaCorrente : Conta
    {
        public ContaCorrente(string clienteNome, int nmroConta, float saldoDisp)
        {
            this.cliente = clienteNome;
            this.numConta = nmroConta;
            this.saldo = saldoDisp;
        }
        public override float taxaSaque { get => 0.0037f; }
        public override float taxaTransf { get => 0.0010f; }
    }

    public class ContaPoupança : Conta
    {
        public ContaPoupança(string clienteNome, int nmroConta, float saldoDisp)
        {
            this.cliente = clienteNome;
            this.numConta = nmroConta;
            this.saldo = saldoDisp;
        }
        public override float taxaSaque { get => 0.0020f; }
        public override float taxaTransf { get => 0.0015f; }
    }
}
