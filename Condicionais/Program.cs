int quantidadeEmEstoque = 3;
Console.Write("Insira a quantidade de compras realizadas: ");
int quantidadeCompra = int.Parse(Console.ReadLine()); //solicita uma entrada
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; //vQuantidade de compra é maior que 0 E quantidade de estoque é suficiente

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"é possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
  Console.WriteLine("Você não realizou nenhuma compra hoje!");
}
else if (possivelVenda) //se o estoque for suficiente
{
  Console.WriteLine("Venda realizada!");
}
else
{
  Console.WriteLine("Desculpe, não temos a quantidade solicitada em estoque.");
}

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
  case "a":
  case "A":
  case "e":
  case "E":
  case "i":
  case "I":
  case "o":
  case "O":

    Console.WriteLine("A letra digitada é uma vogal!");
    break;

  default:

    Console.WriteLine("A letra digitada náo é uma vogal!");
    break;
}


Console.ReadLine();
