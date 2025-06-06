// See https://aka.ms/new-console-template for more information

using Models;

namespace Aritmeticos
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculadora calc = new Calculadora(); //chamo o programa


      calc.Somar(1, 4);
      calc.Subtracao(1, 4);
      calc.Divisao(1, 4);
      calc.Multiplicar(1, 4);

      calc.Potencia(3, 2);
      calc.Potencia(3, 2);

      calc.Seno(30);

      Console.WriteLine(calc);
    }
  }
}
