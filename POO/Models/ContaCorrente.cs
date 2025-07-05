using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal ValorDeSaque)
        {
            if (ValorDeSaque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                Saldo -= ValorDeSaque;
                Console.WriteLine($"Saque de R${ValorDeSaque}, realizado com sucesso. Seu saldo é de R${Saldo}");
            }
        }
        public void Depositar(decimal valorDeDeposito)
        {
            Saldo += valorDeDeposito;
            Console.WriteLine($"Depósito de R${valorDeDeposito}, realizado com sucesso. Seu saldo é de R${Saldo}");

        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de {Saldo}");
        }

    }
}