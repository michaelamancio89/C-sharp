using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    /// <summary>
    /// Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
    ///seguintes intervalos([0,25], (25,50], (50,75], (75,100]) este valor se encontra.Obviamente se o valor não estiver em
    ///nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Intervalos...");
            double interv = double.Parse(Console.ReadLine().ToString(),CultureInfo.InvariantCulture);

            if (interv > 0.0 && interv <25.00)
            {
                Console.WriteLine("[0,25]");
            }
            else if (interv >= 25.00 && interv < 50.00)
            {
                Console.WriteLine("[25,50]");
            }
            else if (interv >= 50.00 && interv < 75.00)
            {
                Console.WriteLine("[50,75]");
            }
            else if (interv >= 75.00 && interv <= 100.00)
            {
                Console.WriteLine("[75,100]");
            }
            else
            {
                Console.WriteLine("Fora do intervalo.");
            }
        }
    }
}
