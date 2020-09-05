using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira três valores para calcular ás areas geométricas: ");
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            Console.WriteLine("Triângulo: "+((a*c)/2).ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: "+(314159*(c*c)).ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: "+ (((a + b) * c) / 2).ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: "+ (b * b).ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: "+(a*b).ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
