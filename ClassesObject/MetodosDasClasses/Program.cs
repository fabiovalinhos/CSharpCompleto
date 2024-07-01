using MetodosDasClasses;

Metodos metodos = new();

//metodos.Cumprimentar();
//metodos.Somar(10, 5);
//metodos.Apresentar("Bruce", 51);

//int valor1 = 100;
//int valor2 = 100;

//metodos.AumentarValor(valor1);
//metodos.AumentarValorRef(ref valor2);

//Console.WriteLine($"Valor 1 {valor1}");
//Console.WriteLine($"Valor 2 {valor2}");

//string nomeCompleto = metodos.MontaNome("Gabriel", "Pereira");
//int codigoChar = metodos.CodigoChar('a');
//double pi = metodos.ValorPI();

//Console.WriteLine(nomeCompleto);
//Console.WriteLine(codigoChar);
//Console.WriteLine(pi);

metodos.Cumprimentar();
metodos.Cumprimentar("Marcelo");
metodos.Cumprimentar("Marcelo", 15);

bool res1 = metodos.Comparar(100, 50 * 2);
bool res2 = metodos.Comparar("Fábio", "Fabio");

Console.WriteLine(res1);
Console.WriteLine(res2);

Console.ReadKey();