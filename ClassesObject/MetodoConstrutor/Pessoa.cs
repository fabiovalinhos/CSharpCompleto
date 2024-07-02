using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;

        public Pessoa()
        {
            this.nome = "desconhecido";
            this.sobrenome = "nenhum";
            anoNascimento = 0;
            idade = 0;
        }

        public Pessoa(string nome,
        string sobrenome,
        int anoNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = anoNascimento;
            this.idade = Idade();
        }

        public Pessoa(string nome,
        string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoNascimento = 2002;
            this.idade = Idade();
        }

        private int Idade(){
            return 2024 - this.anoNascimento;
        }
    }
}
