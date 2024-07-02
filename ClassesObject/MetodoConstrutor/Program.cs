using MetodoConstrutor;

Pessoa p1 = new();

Console.WriteLine(p1.nome);
Console.WriteLine(p1.sobrenome);
Console.WriteLine(p1.anoNascimento);
Console.WriteLine(p1.idade);

Console.WriteLine();

Pessoa p2 = new("Bruce", "Fletcher", 1973);
Console.WriteLine(p2.nome);
Console.WriteLine(p2.sobrenome);
Console.WriteLine(p2.anoNascimento);
Console.WriteLine(p2.idade);

Console.WriteLine();

Pessoa p3 = new("Fábio", "Valinhos");
Console.WriteLine(p3.nome);
Console.WriteLine(p3.sobrenome);
Console.WriteLine(p3.anoNascimento);
Console.WriteLine(p3.idade);

Console.ReadKey();