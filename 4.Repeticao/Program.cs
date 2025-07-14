
int numero = 2;

Console.WriteLine($"PARA:");
for (int contador = 0; contador <= 10; contador++)
{
  Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

Console.WriteLine($"ENQUANTO:");
int conta = 0;

while (conta <= 6)
{
  Console.WriteLine($"{numero} x {conta} = {numero + conta}");
  conta++;

}

Console.WriteLine($"QUANDO:");

int dado = 0, soma = 0;

do
{
  Console.WriteLine("Digite um número: (0 para parar)");
  dado = Convert.ToInt32(Console.ReadLine());

  soma += dado;
}
while (dado != 0);

Console.WriteLine($"O total da soma dos numeros digitados é: {soma}");


Console.ReadLine();

