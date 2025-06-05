using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Estrutura básica de uma classe
namespace Introducao.models //namespace
{
    public class Pessoa //classe é uma representacao de objetos do mundo real.
    {
        public string Nome { get; set; } //Criando uma classe, sempre inicia com lera maiúscula
        public int Idade { get; set; } //prop para criar um modelo
        public void Apresentar() //utilizando palavras reservadas. NAO RECOMENDADO! (string @class)
        {
            Console.WriteLine($"Olá, meu nome {Nome}, e possuo {Idade} anos.\n"); //{Classe = Console e Método = .WriteLine()} e dentro está o parâmetro oua rgumento
        }

//ATRIBUTOS PRIMEIRO, DEPOIS MÉTODOS


    }
}