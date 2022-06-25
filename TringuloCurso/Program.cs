using System;
using TringuloClass;

namespace TringuloCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo A = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo A:");
            A.A = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            A.B = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            A.C = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Triangulo B = new Triangulo();
            Console.WriteLine("Entre com as medidas do triângulo B:");
            B.A = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            B.B = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            B.C = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double AreaA = A.calcularArea(A.A, A.B, A.C);
            double AreaB = B.calcularArea(B.A, B.B, B.C);

            Console.WriteLine("Area A: " + AreaA.ToString("F4", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine("Area B: " + AreaB.ToString("F4", System.Globalization.CultureInfo.InvariantCulture));

            if(AreaA > AreaB)
            {
                Console.WriteLine("Maior Area: A");
            } else if (AreaB > AreaA) 
            {
                Console.WriteLine("Maior Area: B");
            }
            
        }
    }
}
