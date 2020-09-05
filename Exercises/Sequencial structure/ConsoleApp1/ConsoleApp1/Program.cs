using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo: ");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos têm na sua casa?");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o seu nome, sua idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2],CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(price.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
