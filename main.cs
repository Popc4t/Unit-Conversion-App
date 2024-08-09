using System;

namespace UnitConversionApp
{
    public static class main
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Input M to convert from Metric to Imperial, input I to convert Imperial units to Metric.");
            
            char input = Convert.ToChar(Console.ReadLine());

            switch (input)
            {
                case 'm':
                    Metric.Entry();
                    break;
                case 'i':
                    Imperial.Entry2();
                    break;
            }
            
        }

    }
    public static class Metric
    {
        public static void Entry()
        {
            Console.WriteLine("Input 'T' to convert temperature units.");
            Console.WriteLine("Input 'L' to convert length units.");
            Console.WriteLine("Input 'M' to convert mass units.");
            char input = Convert.ToChar(Console.ReadLine());

            switch (input)
            {
                case 't':
                    temperature();
                    break;
                case 'l':
                    length();
                    break;
                case 'm':
                    mass();
                    break;
            }
            
        }
        
        public static void temperature() //Converting Celsius to Fahrenheit
        {
            Console.Write("Input a temperature in Celsius: ");
            double celsiusinput = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsiusinput * 9 / 5 + 32;
            Console.WriteLine(celsiusinput + "°C converted to Fahrenheit = " + fahrenheit + "°F");
            Console.ReadLine();
        }
        public static void length() //Converting Metric length units (meter, centimeter, kilometer etc.) to Imperial length units.
        {
            Console.Write("Input a length number in meters: ");
            double meterinput = Convert.ToDouble(Console.ReadLine());
            double feet = meterinput * 3.2808;
            Console.WriteLine(meterinput + " meter converted to feet = " + feet + " feet");
            Console.ReadLine();
        }
        public static void mass() //Converting metric mass units to imperial units.
        {
            Console.Write("Input a mass in kilograms: ");
            double kiloinput = Convert.ToDouble(Console.ReadLine());
            double pounds = kiloinput * 2.20462;
            Console.WriteLine(kiloinput + " kilograms converted to pounds = " + pounds + " lbs");
            Console.ReadLine();
        }

    }

    public static class Imperial
    {
        public static void Entry2()
        {


        }

    }
    
    
}
