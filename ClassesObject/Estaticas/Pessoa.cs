using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estaticas
{
    public class Pessoa
    {
        public static int maioridade = 18;
        public string nome;

        public int idade;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou {nome}");
        }

        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}