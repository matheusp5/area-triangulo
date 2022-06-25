using System;
using System.Globalization;

namespace TringuloClass
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double calcularArea(double A, double B, double C)
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }
}
