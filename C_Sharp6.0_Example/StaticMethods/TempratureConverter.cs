using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    public class TempratureConverter
    {
        public static double CelciusToFahrenheit(string celcius)
        {
            double tempInCelcius = double.Parse(celcius);
            double tempInFahrenheit = (tempInCelcius * 9 / 5) + 32;
            return tempInFahrenheit;
        }

        public static double FahrenheitToCelcius(string fahrenheit)
        {
            double tempInFahrenheit = double.Parse(fahrenheit);
            double tempInCelcius = (tempInFahrenheit * 5 / 9) - 32;
            return tempInCelcius;
        }
    }
}
