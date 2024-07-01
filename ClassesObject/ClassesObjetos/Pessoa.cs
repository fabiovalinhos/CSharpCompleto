using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimenot;

        public void Cumprimentar(){
            Console.WriteLine($"Olá, eu sou {nome} {sobrenome}");
        }
    }
}