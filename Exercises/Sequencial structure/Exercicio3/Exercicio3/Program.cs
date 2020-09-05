using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        public static void Main(string[] args)
        {

            //double raio = 2.00;
            //double raio = 100.64;
            double raio = 150.00;
            double r = 3.14159;
            double area = r * (raio * raio);

            Console.WriteLine("A= "+area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
