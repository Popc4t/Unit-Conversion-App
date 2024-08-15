using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConversionApp
{
    public class Metric // Converting metric units to imperial.
    {
        public static void ToFahrenehit()
        {
            double input = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = input * 5 / 9 + 32;
            Console.WriteLine(input + "°C converted to Fahrenheit = " + fahrenheit + "°F");
            



        }


    }
}
