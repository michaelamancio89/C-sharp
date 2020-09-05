using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    /// <summary>
    /// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
    ///começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Duração dos jogos...");
            string[] vet = Console.ReadLine().Split(' ');
            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);

            if(n2 > n1)
            {
                int complemento = 24-(n2 - n1);
                Console.WriteLine($"O jogo durou {complemento} horas.");
            }
            else if(n1>n2)
            {
                Console.WriteLine($"O jogo durou {n1 - n2} horas.");
            }
            else
            {
                Console.WriteLine("O jogo durou 24 horas.");
            }

            
        }
    }
}
