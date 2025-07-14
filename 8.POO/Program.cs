
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

      Aluno aluno1 = new Aluno();
      aluno1.Nome = "Andressa";
      aluno1.Idade = 18;
      aluno1.Nota = 100.00D;

aluno1.Apresentar();

Professor professor1 = new Professor();
professor1.Nome = "Jaeder";
professor1.Idade = 29;
professor1.Salario = 10000.00m;

professor1.Apresentar();

