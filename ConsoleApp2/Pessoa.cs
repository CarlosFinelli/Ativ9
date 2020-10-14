using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Pessoa
    {
        public String nome;
        public int idade;

        public String MaisVelho(int xidade, int yidade, String nomeA, String nomeB)
        {
            if (xidade > yidade)
            {
                return nomeA;
            }
            return nomeB;
        }
    }
}
