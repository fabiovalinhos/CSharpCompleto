using System;
using ClassesObjetos;

#region 
// MinhaClasse minha = new();
// minha.Metodo();
// OutraClasse outra = new();
#endregion


Pessoa p1 = new();
p1.nome = "Fabio";
p1.sobrenome = "Valinhos";
p1.anoNascimenot = 1973;

Pessoa p2 = new(){
      nome = "Bruce",
      sobrenome = "Fletcher",
      anoNascimenot = 1973
};

Console.WriteLine($"Pessoa1: {p1.nome}");
Console.WriteLine($"Pessoa1: {p1.sobrenome}");
Console.WriteLine($"Pessoa1: {p1.anoNascimenot}");
p1.Cumprimentar();

Console.WriteLine();

Console.WriteLine($"Pessoa2: {p2.nome}");
Console.WriteLine($"Pessoa2: {p2.sobrenome}");
Console.WriteLine($"Pessoa2: {p2.anoNascimenot}");
p2.Cumprimentar();

Console.ReadKey();


class MinhaClasse
{
    public void Metodo()
    {
        Console.WriteLine("Hello, World mudado!");
    }

}
