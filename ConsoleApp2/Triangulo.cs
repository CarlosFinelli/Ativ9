using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp2
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;


        public double CalculoX(double XA, double XB, double XC)
        {
            double xp = ((XA + XB + XC) / 2);
            double areaX = (xp * (xp - XA) * (xp - XB) * (xp - XC));
            return areaX;
        }
        public double CalculoY(double YA, double YB, double YC)
        {
            double yp = ((YA + YB + YC) / 2);
            double areaY = (yp * (yp - YA) * (yp - YB) * (yp - YC));
            return areaY;
        }
    }
}
