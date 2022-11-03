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

Console.WriteLine("\n\n      ES CA LA ÇÃO       \n\n");

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine(atletico.NomeCompleto);

atletico.RelacionarJogadores();
atletico.Escalacao();
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");

Console.WriteLine(coxa.NomeCompleto);
coxa.RelacionarJogadores();
coxa.Escalacao();
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");