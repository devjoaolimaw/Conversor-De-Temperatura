using System;

namespace Conversor
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Consversor de Temperatura");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.WriteLine("1. Celsius para Fahrenheit");
            Console.WriteLine("2. Fahrenheit para Celsius");
            Console.WriteLine("3. Celsius para Kelvin");
            Console.WriteLine("4. Kelvin para Celsius");
            Console.WriteLine("5. Fahrenheit para Kelvin");
            Console.WriteLine("6. Kelvin para Fahrenheit");
            Console.WriteLine("0. Sair");
            Console.WriteLine();
            Console.WriteLine("===========================");

            Console.Write("Escolha uma opção (1-6): ");
            Sistem.Sistema();
        }
    }
}