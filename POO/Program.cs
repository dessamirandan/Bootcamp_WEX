
using System;
using POO.Models;
      Pessoa pessoa1 = new Pessoa();
      pessoa1.Nome = "Andressa";
      pessoa1.Idade = 28;

      pessoa1.Apresentar();

      ContaCorrente c1 = new ContaCorrente(123, 1400);
      c1.Depositar(600);
c1.Sacar(100);
c1.ExibirSaldo();

