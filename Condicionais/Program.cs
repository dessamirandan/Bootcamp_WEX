int quantidadeEmEstoque = 3;
Console.Write("Insira a quantidade de compras realizadas: ");
int quantidadeCompra = int.Parse(Console.ReadLine());
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; //

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"é possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
  Console.WriteLine("Você não realizou nenhuma compra hoje!");
}
else if (possivelVenda)
{
  Console.WriteLine("Venda realizada!");
}
else
{
  Console.WriteLine("Desculpe, não temos a quantidade solicitada em estoque.");
}

 Console.ReadLine();
