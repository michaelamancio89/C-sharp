using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite as propriedades da primeira peça: ");
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]);
            double n2 = double.Parse(vet[1].ToString(), CultureInfo.InvariantCulture);
            double n3 = double.Parse(vet[2].ToString(), CultureInfo.InvariantCulture);

            double plus1 = (n2 * n3);

            Console.WriteLine("Digite as propriedades da primeira peça: ");
            string[] vet2= Console.ReadLine().Split(' ');
            int n4 = int.Parse(vet[0]);
            double n5 =  double.Parse(vet[1].ToString(), CultureInfo.InvariantCulture);
            double n6 = double.Parse(vet[2].ToString(), CultureInfo.InvariantCulture);

            double plus2 = (n5 * n6);

            double soma = plus1 + plus2;

            Console.WriteLine("Valor a pagar: "+soma.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
