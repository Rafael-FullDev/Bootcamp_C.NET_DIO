using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_EHPA.Models
{
    public class ContaCorrente
    {
        private decimal Saldo { get; set; }
        public int NumeroConta { get; set; }

        public ContaCorrente(decimal saldo, int numeroConta)
        {
            Saldo = saldo;
            NumeroConta = numeroConta;
        }

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void VerConta()
        {
            Console.WriteLine(Saldo);
        }

    }
}
