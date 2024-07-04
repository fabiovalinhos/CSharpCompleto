using Heranca;

#region Parte 1 herança e sealed
//Carro c = new Carro();
//Bicicleta b = new();

//c.Acelerar();
//b.Acelerar();

//c.Parar();
//b.Parar();
#endregion

Humano hu = new();
Pessoa p = new();
Homem ho = new();

Console.WriteLine("\nHumano");
hu.Olhos();
hu.Cabelos();

Console.WriteLine("\nPessoa");
p.Olhos();
p.Cabelos();

Console.WriteLine("\nHomem");
ho.Olhos();
ho.Cabelos();

Console.ReadKey();