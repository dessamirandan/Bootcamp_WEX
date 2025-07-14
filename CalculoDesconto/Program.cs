using System;
using System.Globalization;



class DescontoInteligente
{
  static void Main()
  {
    // Lê o valor original do produto
    double valorOriginal = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

    // Lê a porcentagem de desconto
    double porcentagemDesconto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

    // TODO: Verifique se o desconto está dentro de um intervalo válido

    if (porcentagemDesconto < 0 || porcentagemDesconto > 100)
    {
      Console.WriteLine("Desconto invalido");
    }
    else
    {

      // TODO: Calcule o valor final do produto
      double DescontoFinal = (valorOriginal * porcentagemDesconto / 100);
      double valorFinal = valorOriginal - DescontoFinal;

      // Exibe o valor com duas casas decimais
      Console.WriteLine($"{valorFinal.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    }
}
