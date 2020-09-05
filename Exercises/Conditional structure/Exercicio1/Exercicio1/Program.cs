using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        /// <summary>
        /// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("O número é positivo ou negativo?");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("Não negativo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}
