
string opcao;
bool exibirMenu = true;

while (exibirMenu) //inicia se verdadeiro
{
  Console.Clear(); //Limpa Console
  Console.WriteLine("ESCOLHA UMA OPÇÃO:");
  Console.WriteLine("1 - Cadatsrar cliente");
  Console.WriteLine("2 - Buscar Cliente");
  Console.WriteLine("3 - Apagar Cliente");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Cadastro de Cliente");
      break;
    case "2":
      Console.WriteLine("Buscar Cliente");
      break;

    case "3":
      Console.WriteLine("Apagar Cliente");
      break;

    case "4":
      Console.WriteLine("Encerrar");
      exibirMenu = false; //Encerra o projeto
      //Environment.Exit(0); encerra
      break;

    default:
      Console.WriteLine("Opção Inválida");
      break;
  }
}