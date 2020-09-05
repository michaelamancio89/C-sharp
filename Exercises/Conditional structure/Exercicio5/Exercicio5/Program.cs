using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    /// <summary>
    /// escreva um programa que leia o código de um item e a quantidade deste item. A
    ///seguir, calcule e mostre o valor da conta a pagar.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Código & preço...");
            string[] vet = Console.ReadLine().Split(' ');
            double cod = double.Parse(vet[0].ToString(), CultureInfo.InvariantCulture);
            double qntd = double.Parse(vet[1].ToString(), CultureInfo.InvariantCulture);

            if(cod == 1)
            {
                Console.WriteLine("R$: "+(qntd * 4.0).ToString("F2",CultureInfo.InvariantCulture));
            }
            else if(cod == 2)
            {
                Console.WriteLine("R$: " + (qntd * 4.5).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(cod == 3)
            {
                Console.WriteLine("R$: " + (qntd * 5.0).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(cod == 4)
            {
                Console.WriteLine("R$: " + (qntd * 2.0).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(cod == 5)
            {
                Console.WriteLine("R$: " + (qntd * 1.5).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Código não registrado no sistema.");
            }
        }
    }
}
