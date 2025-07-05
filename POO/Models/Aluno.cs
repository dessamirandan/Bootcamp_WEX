using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Aluno : Pessoa //heranca
    {
        public double Nota { get; set; }

    public override void Apresentar() //override polimorfismo
    {
    Console.WriteLine($"Olá, eu sou o aluno {Nome}, tenho {Idade} anos e estou com a no {Nota}.");

    }
    }
}