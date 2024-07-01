using TermoThis;

Acessar acessar = new();

if (acessar.Login("teste"))
{
    Console.WriteLine("Seja bem vindo");
}
else
{
    Console.WriteLine("Acesso negado");
}

Console.ReadKey();