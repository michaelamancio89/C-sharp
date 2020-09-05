using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Coordenadas diferentes de NULL");
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while ((x != 0) && (y != 0))
            {
                if ((x > 0) && (y > 0))
                {
                    Console.WriteLine("Primeiro");
                }
                else if ((x > 0) && (y < 0))
                {
                    Console.WriteLine("Quarto");
                }
                else if ((x < 0) && (y < 0))
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Segundo");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            }

            Console.WriteLine("NULL");
        }
    }
}
