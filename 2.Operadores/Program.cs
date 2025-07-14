// See https://aka.ms/new-console-template for more information

//OR PIPE ||

bool maiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (maiorDeIdade || possuiAutorizacaoDoResponsavel)
{
  Console.WriteLine("Pode acessar a balada");
}
else
{
  Console.WriteLine("Você não pode entrar na balada!");
}

// AND &&

bool presencaMinima = true;
int possuiMedia = 7;

if (presencaMinima && possuiMedia >= 7)
{
  Console.WriteLine("Você foi aprovado");
}
else
{
  Console.WriteLine("Você foi reprovado");
}