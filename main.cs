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
            double input = Convert.ToDouble(Console.ReadLine());
            double inch, mile, yard, feet;
            inch = input * 0.3937;
            mile = input * 0.621371;



        }
        public static void mass() //Converting metric mass units to imperial units.
        {
            
        }

    }

    public static class Imperial
    {
        public static void Entry2()
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

        public static void temperature() //Converting Fahrenheit to Celsius
        {
            Console.Write("Input a temperature in Fahrenheit: ");
            double fahrenheitinput = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheitinput - 32) * 5 / 9;
            Console.WriteLine(fahrenheitinput + "°C converted to Fahrenheit = " + celsius + "°C");
            Console.ReadLine();
        }
        public static void length() //Converting imperial length units (feet, miles, inches etc.) to Imperial length units.
        {
            


        }
        public static void mass() //Converting imperial mass units to metric units.
        {
            
        }

    }
    
    
}
