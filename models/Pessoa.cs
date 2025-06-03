using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Estrutura básica de uma classe
namespace Bootcamp.models
{
    public class Pessoa //classe é uma representacao de objetos do mundo real.
    {
        public string Nome { get; set; } //Criando uma classe, sempre inicia com lera maiúscula
        public int Idade { get; set; } //prop para criar um modelo
        public void Apresentar(string @class) //utilizando palavras reservadas. NAO RECOMENDADO!
        {
            Console.WriteLine($"Olá, meu nome {Nome}, e possuo {Idade} anos."); //{Classe = Console e Método = .WriteLine()} e dentro está o parâmetro oua rgumento
        }

//ATRIBUTOS PRIEMIRO, DEPOIS MÉTODOS


    }
}