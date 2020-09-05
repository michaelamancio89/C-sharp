using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nº funcionário ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas Trabalhadas");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor/hora");
            double vh = double.Parse(Console.ReadLine().ToString(),CultureInfo.InvariantCulture);
            double salary = vh * h;

            Console.WriteLine("Nº do funcionário: "+num+"\n Salary: "+salary.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
