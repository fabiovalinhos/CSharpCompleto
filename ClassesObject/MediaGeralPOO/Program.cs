
using System.Diagnostics;
using MediaGeralPOO;

Console.Title = "### Média Geral dos Alunos ###";

Console.WriteLine("Forneça o número de alunos:");
int nAlunos = int.Parse(Console.ReadLine());

Console.WriteLine();

Aluno[] alunos = new Aluno[nAlunos];

for (int i = 0; i < alunos.Length; i++)
{
    Console.Clear();
    Console.WriteLine($"Aluno #{i + 1} Nome..:");
    string nome = Console.ReadLine();

    Console.WriteLine($"Aluno #{i + 1} Número de provas:");
    int provas = int.Parse(Console.ReadLine());

    alunos[i] = new Aluno(nome ?? "-", provas);

    Console.WriteLine($"Inserir as notas do aluno {nome}");

    alunos[i].InserirNotas();
}

Console.Clear();

double mediaGeral = 0;

foreach (var item in alunos)
{
    Console.WriteLine($"Aluno: {item.Nome}");
    Console.WriteLine($"Media: {item.Media}");
    Console.WriteLine();

    mediaGeral += item.Media;
}

double resultadoFinal = mediaGeral / alunos.Length;
Console.WriteLine($"Média geral dos alunos: {resultadoFinal}");

Console.ReadKey();