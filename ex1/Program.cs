using System;
using System.Collections.Generic;


List<Pessoa> pessoas = new List<Pessoa>();
for (int i = 0; i < 3; i++)
{
    Console.Write($"\nEntre com o nome da pessoa {i+1}: ");
    string nome = Console.ReadLine();
    Console.Write($"\nEntre com a idade do(a) {nome}: ");
    int idade = int.Parse(Console.ReadLine());

    pessoas.Add(new Pessoa(nome, idade));
}

Console.WriteLine("");

for (int i = 0; i < pessoas.Count; i++)
{
    pessoas[i].ExibirDados();
}



