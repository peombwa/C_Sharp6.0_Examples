using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = String.Empty;
            while (selection.ToLower() != "q")
            {
                Console.Write("Enter C)elsius to Fahrenheit or F)ahrenheit to Celsius or Q)uit: ");
                selection = Console.ReadLine();
                double fahrenheit = 0, celsius = 0;
                
                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Enter temprature in Celsius: ");
                        fahrenheit = TempratureConverter.CelciusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temprature in Fahrenheit: {fahrenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Enter temprature in Fahrenheit: ");
                        celsius = TempratureConverter.FahrenheitToCelcius(Console.ReadLine());
                        Console.WriteLine($"Temprature in Celsius: {celsius:f2}");
                        break;

                    case "Q":
                    case "q":

                        break;

                    default:
                        break;
                }
            }

        }
    }
}
