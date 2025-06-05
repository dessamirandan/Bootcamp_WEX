using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Calculadora //Criei uma calculadora com os métodos abaixo:
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtracao(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            Console.WriteLine($"{x} ˆ {y} = {(double)Math.Pow(x, y)}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;

            Console.WriteLine($"Seno de {angulo} = {Math.Round(Math.Sin(radiano), 4)}");
        }

    }
}