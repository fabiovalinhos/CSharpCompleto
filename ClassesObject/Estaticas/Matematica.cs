using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estaticas
{
    static public class Matematica
    {
        public static int taxa;

        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }
    }
}