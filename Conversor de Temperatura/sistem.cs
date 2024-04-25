using System;

namespace Conversor
{
    class Sistem
    {
        public static void Sistema()
        {
            int opcao = int.Parse(Console.ReadLine());

            double temperatura, resultado;
            
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    temperatura = double.Parse(Console.ReadLine());
                    resultado = Show.CelsiusParaFahrenheit(temperatura);
                    Console.WriteLine();
                    Console.WriteLine($"Resultado: {resultado} Fahrenheit");
                    Console.WriteLine();
                    Console.ReadKey();
                    Program.Main();
                break;
                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    temperatura = double.Parse(Console.ReadLine());
                    resultado = Show.FahrenheitParaCelsius(temperatura);
                    Console.WriteLine();
                    Console.WriteLine($"Resultado: {resultado} Celsius");
                    Console.WriteLine();
                    Console.ReadKey();
                    Program.Main();
                break;
                case 3:
                    Console.Write("Digite a temperatura em Celsius: ");
                    temperatura = double.Parse(Console.ReadLine());
                    resultado = Show.CelsiusParaKelvin(temperatura);
                    Console.WriteLine();
                    Console.WriteLine($"Resultado: {resultado} Kelvin");
                    Console.WriteLine();
                    Console.ReadKey();
                    Program.Main();
                break;
                case 4:
                    Console.Write("Digite a temperatura em Kelvin");
                    temperatura = double.Parse(Console.ReadLine());
                    resultado = Show.KelvinParaCelsius(temperatura);
                    Console.WriteLine();
                    Console.WriteLine($"Resultado: {resultado} Celsius");
                    Console.WriteLine();
                    Console.ReadKey();
                    Program.Main();
                break;
                case 5:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    temperatura = double.Parse(Console.ReadLine());
                    resultado = Show.FahrenheitParaKelvin(temperatura);
                    Console.WriteLine();
                    Console.WriteLine($"Resultado: {resultado} Kelvin");
                    Console.WriteLine();
                    Console.ReadKey();
                    Program.Main();
                break;
                case 6:
                    Console.Write("Digite a temperatura em Kelvin: ");
                    temperatura = double.Parse(Console.ReadLine());
                    resultado = Show.KelvinParaFahrenheit(temperatura);
                    Console.WriteLine();
                    Console.WriteLine($"Resultado: {resultado} Fahrenheit");
                    Console.WriteLine();
                    Console.ReadKey();
                    Program.Main();
                break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}