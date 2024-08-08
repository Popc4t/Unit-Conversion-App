using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConversionApp
{
    public static class main
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Type M to convert from Metric to Imperial, type I to convert Imperial units to Metric.");
            
            char input = Convert.ToChar(Console.ReadLine());

            if (input == 'M' | input == 'm')
            {
                IfMetric.entry();
            } 
            if (input == 'I' | input == 'i')
            {
                ifImperial.entry2();

            }
        }

    }
    public static class IfMetric
    {
        public static void entry()
        {
            Console.WriteLine("Input 'T' to convert temperature units.");
            Console.WriteLine("Input 'L' to convert length units.");
            Console.WriteLine("Input 'M' to convert mass units.");
            char input = Convert.ToChar(Console.ReadLine());

            if (input == 'T' | input == 't')
            {
                temperature();
            }

        }
        
        public static void temperature() //Converting Celsius to Fahrenheit//
        {
            Console.Write("Input a temperature in Celsius: ");
            double input = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = input * 9 / 5 + 32;
            Console.WriteLine(input + "°C converted to Fahrenheit = " + fahrenheit + "°F");
            Console.ReadLine();


        }
        public static void length() //Converting Metric length units (meter, centimeter, kilometer etc.) to Imperial length units.//
        {


        }

    }




    public static class ifImperial
    {
        public static void entry2()
        {


        }

    }
    
    
}
