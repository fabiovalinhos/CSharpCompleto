using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    public class Metodos
    {
        public void Cumprimentar()
        {
            Console.WriteLine("Eai?!");
        }

        public void Somar(int num1, int num2)
        {
            Console.WriteLine($"A soma é: {num1 + num2}");
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");
        }

        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final (por valor) é {valor}");
        }

        // É recebido uma referencia do valor inicial. Se mudarmos o valor aqui
        // vai afetar a referência, ou a variável que tem o valor original
        public void AumentarValorRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final (por referência) é {valor}");
        }

        public string  MontaNome(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}"; 
        }

        public int CodigoChar(char caractere)
        {
            int codigo = (int)caractere;// poderia tirar o (int) pois a convensão é implícita

            return codigo;
        }

        public double ValorPI()
        {
            return 3.1415;
        }
    }
}
