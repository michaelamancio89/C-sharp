using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        /// <summary>
        /// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        ///Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        ///ordem crescente ou decrescente.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("São ou não múltiplos...");
            string[] vet = Console.ReadLine().Split(' ');
            int n1= int.Parse(vet[0]);
            int n2= int.Parse(vet[1]);

            if ((n2 % n1 == 0)||(n1 % n2 == 0))
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não múltiplos");
            }
        }
    }
}
