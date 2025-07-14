using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Professor : Pessoa //heranca
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou o professor {Nome}, tenho {Idade} anos e recebo um salário de R${Salario}.");
        }

    }


}