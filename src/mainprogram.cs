using System;
using System.Threading;

namespace UnitConversionApp
{
    public static class MainMenu
    {
        

        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nInput 'M' to convert metric units to imperial.");
            Console.WriteLine("Input 'I' to convert imperial units to metric.");
            ConsoleKeyInfo keyinfo = Console.ReadKey();
            switch (keyinfo.Key)
            {
                case ConsoleKey.M:
                    MetricControls();
                    break;
                case ConsoleKey.I:
                    ImperialControls();
                    break;
                default:
                    Console.WriteLine("\nInvalid input, please try again.");
                    Main();
                    break;
            }   

        }
        public static void Controls()
        {
            Thread.Sleep(1500);
            Console.WriteLine("\nInput 'D' to return to the main menu.");
            Console.WriteLine("Input 'Q' to quit.");
            ConsoleKeyInfo keypressed = Console.ReadKey();

            switch (keypressed.Key)
            {
                case ConsoleKey.D:
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
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
                case ConsoleKey.K:
                    Metric.ToPounds();
                    break;
                case ConsoleKey.M:
                    Metric.ToFeet();
                    break;
                default:
                    Console.WriteLine("\nInvalid input, please try again.");
                    MetricControls();
                    break;
            }

        }
        public static void ImperialControls()
        {
            Console.WriteLine("\nPress 'F' to convert Fahrenheit to Celsius.");
            Console.WriteLine("Press 'P' to convert pounds to kilograms.");
            Console.WriteLine("Press 'M' to convert feet to meters.");

            ConsoleKeyInfo keyinput = Console.ReadKey();

            switch (keyinput.Key)
            {
                case ConsoleKey.F:
                    Imperial.ToCelsius();
                    break;
                case ConsoleKey.P:
                    Imperial.ToKilograms();
                    break;
                case ConsoleKey.M:
                    Imperial.ToMeters();
                    break;
                default:
                    Console.WriteLine("\nInvalid input, please try again.");
                    ImperialControls();
                    break;
            }

        }
        
    }
    
}