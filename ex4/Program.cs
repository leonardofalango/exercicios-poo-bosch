using System;





// Criei 2 arquivos com 11 nomes aleatórios
var athle = File.ReadAllLines("times/Athletico.txt");
Time atletico = Time.makeTime(athle, "Athletico");

var cpx = File.ReadAllLines("times/Coxa.txt");
Time coxa = Time.makeTime(cpx, "Coxa Branca");

Console.WriteLine("_________________________");
atletico.Plantel();
Console.WriteLine("_________________________");
coxa.Plantel();
Console.WriteLine("_________________________");