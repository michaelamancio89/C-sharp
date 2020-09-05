using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Acesso via senha: ");
            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha Incorreta");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!!!");
        }
    }
}
