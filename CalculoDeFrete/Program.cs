using System;
using System.Globalization;

class CalculoFreteRapido
{
    static void Main()
    {
        // Lê o peso em quilos
        double peso = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        // TODO: Leia o valor do frete por quilo
        double valorFretePorQuilo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);


        // TODO: Calcule o valor total do frete

        double valorTotalFrete = peso * valorFretePorQuilo;

        // TODO: Exiba o valor formatado com duas casas decimais

        Console.Write(valorTotalFrete.ToString("F2", CultureInfo.InvariantCulture));
    }
}