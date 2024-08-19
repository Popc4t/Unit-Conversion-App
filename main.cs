using System;

namespace UnitConversionApp
{
    public static class MainMenu
    {
        

        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Input 'M' to convert metric units to imperial.");
            Console.WriteLine("Input 'I' to convert imperial units to metric.");
            ConsoleKeyInfo keyinfo = Console.ReadKey();
            switch (keyinfo.Key)
            {
                case ConsoleKey.M:
                    MetricControls();
                    break;
                case ConsoleKey.I:
                    
                    break;
            }   

        } 
        public static void MetricControls()
        {
            Console.WriteLine("\nPress 'C' to convert Celsius to Fahrenheit.");
            Console.WriteLine("Press 'K' to convert kilograms to pounds.");
            Console.WriteLine("Press 'M' to convert meters to feet.");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.C:
                    Metric.ToFahrenheit();
                    break;


            }

        }
        
    }
    
}
