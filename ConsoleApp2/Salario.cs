using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Salario
    {
        public String nome;
        public double salario;
        public String dados;
        public double media;

        public double MediaSalario(double salario1, double salario2)
        {
            double media = (salario1 + salario2) / 2;
            return Math.Round(media, 2);
        }
    }
}
