using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== Conversor de Temperatura ===");
                Console.WriteLine("1. Celsius para Fahrenheit");
                Console.WriteLine("2. Fahrenheit para Celsius");
                Console.WriteLine("3. Celsius para Kelvin");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nDigite a temperatura em Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {(celsius * 9 / 5) + 32} °F");
                        break;

                    case "2":
                        Console.Write("\nDigite a temperatura em Fahrenheit: ");
                        double fahrenheit = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {(fahrenheit - 32) * 5 / 9} °C");
                        break;

                    case "3":
                        Console.Write("\nDigite a temperatura em Celsius: ");
                        double celsiusKelvin = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {celsiusKelvin + 273.15} K");
                        break;

                    case "0":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\nObrigado por usar o Conversor de Temperatura!");
        }
    }
}
