using Estaticas;

#region Classe Estática
// Matematica.taxa = 10;

// var valor1 = Matematica.Adicionar(200);
// var valor2 = Matematica.Diminuir(200);

// Console.WriteLine($"Valor1: {valor1} e Valor2: {valor2}");
#endregion

Pessoa.maioridade = 21;

Pessoa p1 = new();
p1.nome = "Bruce";
p1.idade = Pessoa.CalcularIdade(1973);

Console.WriteLine(p1.nome);
Console.WriteLine(p1.idade);
Console.WriteLine(Pessoa.maioridade);

Console.ReadKey();