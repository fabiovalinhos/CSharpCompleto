using TipoDelegate;

Matematica m = new();
Operacao conta = null;

conta += m.Somar;
conta += m.Subtrair;
conta += m.Multiplicar;
conta += m.Dividir;
conta += m.Multiplicar;

conta(10, 2);

Console.WriteLine();

conta -= m.Dividir;
conta -= m.Subtrair;

conta(15, 3);

Console.ReadKey();

public delegate void Operacao(int num1, int num2);

