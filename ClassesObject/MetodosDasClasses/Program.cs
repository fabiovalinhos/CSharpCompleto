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

string nomeCompleto = metodos.MontaNome("Gabriel", "Pereira");
int codigoChar = metodos.CodigoChar('a');
double pi = metodos.ValorPI();

Console.WriteLine(nomeCompleto);
Console.WriteLine(codigoChar);
Console.WriteLine(pi);

Console.ReadKey();