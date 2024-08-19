using System;

namespace UnitConversionApp
{
    public static class Metric // Converting metric units to imperial.
    {
        
        public static void ToFahrenheit()
        {
            Console.WriteLine("\nInput a value in Celsius to convert to Fahrenheit: ");
            double celsiusinput = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsiusinput * 9 / 5 + 32;
            Console.WriteLine(celsiusinput + "°C converted to Fahrenheit = " + fahrenheit + "°F");
            Console.ReadLine();
            
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
