using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheitTemp, celsiusTemp;
            
            Console.WriteLine("\n\nPlease enter a temperature in degrees Fahrenheit, then press 'enter'.\n\n");
            fahrenheitTemp = Convert.ToDouble (Console.ReadLine());
            celsiusTemp = (fahrenheitTemp - 32)*5/9;

            Console.WriteLine("\n\nYou entered {0} degrees Fahrenheit. \nThis is equivalent to {1} degrees Celsius.", fahrenheitTemp.ToString("f0"), celsiusTemp.ToString("f0"));
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
