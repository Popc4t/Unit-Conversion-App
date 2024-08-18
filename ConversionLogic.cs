using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConversionApp
{
    public class Metric // Converting metric units to imperial.
    {
        public static void ToFahrenheit()
        {
            double celsiusinput = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsiusinput * 5 / 9 + 32;
        }
        public static void ToPounds()
        {
            double kiloinput = Convert.ToDouble(Console.ReadLine());
            double pounds = kiloinput * 2.204623;
        }
        public static void ToFeet()
        {
            double meterinput = Convert.ToDouble(Console.ReadLine());
            double feet = meterinput * 3.28084;
        }


    }
}
