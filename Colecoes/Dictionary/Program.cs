using Dictionary;

ClasseDictionary classeDictionary = new();

classeDictionary.Acionando();

foreach (KeyValuePair<int, string> item in classeDictionary.alunos)
{
    Console.WriteLine($"Chave {item.Key} com valor {item.Value}");
}