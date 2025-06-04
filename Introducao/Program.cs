
//Reconhecendo as classes criadas
using Introducao.models;

Pessoa pessoa1 = new Pessoa(); //variável pessoa1 do tipo Pessoa. Começa com minuscula camelCase
pessoa1.Nome = "Andressa";
pessoa1.Idade = 28;
pessoa1.Apresentar(); //isso é um método. Começa com maiuscula Case

string texto = "Olá mundo!";
int inteiro = 10;
double naturais = 1.2; //Padrão para operações matemáticas
decimal valor = 1.80m; //Finanças, preços (alta precisão) sufixo -m
float flutuante = 1.2f; //Medidas físicas (altura, distância) sufixo -f
bool condicao = true;

Console.WriteLine("Uma string: " + texto);
Console.WriteLine("Um inteiro: " + inteiro);
Console.WriteLine("Um natural: " + naturais);
Console.WriteLine("Um decimal: " + valor);
Console.WriteLine("Um float: " + flutuante);
Console.WriteLine("Um booleano: " + condicao);


DateTime dataAtual = DateTime.Now;
Console.WriteLine("Hoje é: " + dataAtual);

Console.WriteLine("O mês é: " + dataAtual.ToString("MMMM")); //exibe mês por extenso
