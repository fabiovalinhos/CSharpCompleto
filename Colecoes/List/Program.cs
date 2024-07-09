
using List;

Lista lista = new();

lista.Acionando();
Console.WriteLine(lista.nomes2[1]);

foreach (var item in lista.nomes2)
{
    Console.WriteLine(item);
}