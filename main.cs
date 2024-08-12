using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace UnitConversionApp
{
    public static class Mainmenu
    {
        public static void Main()
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
    public static class Controls
    {
        public static void KeyControls()
        {
            Console.WriteLine("\nPress '1' key to return to the main menu, '2' to convert again");

            char keyinput = Convert.ToChar(Console.ReadLine());

            switch (keyinput)
            {
                case '1':
                    Mainmenu.Main();
                    break;
                case '2':

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
                    Temperature();
                    break;
                case 'l':
                    Length();
                    break;
                case 'm':
                    Mass();
                    break;
            }
            
        }
        
        public static void Temperature() //Converting Celsius to Fahrenheit
        {
            Console.Write("Input a temperature in Celsius: ");
            double celsiusinput = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsiusinput * 9 / 5 + 32;
            
            Console.WriteLine(celsiusinput + "°C converted to Fahrenheit = " + fahrenheit + "°F");
            
            Thread.Sleep(1500);
            
            Console.WriteLine("\nPress '1' key to return to the main menu, '2' to convert again");
            
            char keyinput = Convert.ToChar(Console.ReadLine());

            switch (keyinput)
            {
                case '1':
                    Mainmenu.Main();
                    break;
                case '2':
                    Temperature();
                    break;
            }

        }
        public static void Length() //Converting Metric length units (meter, centimeter, kilometer etc.) to Imperial length units.
        {
            Console.WriteLine("Input 'I' to convert centimeters to inches.");
            Console.WriteLine("Input 'K' to convert kilometers to miles.");
            Console.WriteLine("Input 'F' to convert meters to feet.");
            Console.WriteLine("Input 'Y' to convert meters to yards.");
            char input = Convert.ToChar(Console.ReadLine());
            
            double inch, mile, yard, feet;
            
            switch (input)
            {
                case 'i':
                    Console.WriteLine("Input a value in centimeters: ");
                    double cminput = Convert.ToDouble(Console.ReadLine());
                    inch = cminput * 0.3937;
                    Console.WriteLine(inch);
                    Controls.KeyControls();
                    break;

                case 'k':
                    Console.WriteLine("Input a value in kilometers: ");
                    double kminput = Convert.ToDouble(Console.ReadLine());
                    mile = kminput * 0.621371;
                    Console.WriteLine(mile);
                    Console.ReadLine();
                    break;

                case 'y':
                    Console.WriteLine("Input a value in meters: ");
                    double meterinput = Convert.ToDouble(Console.ReadLine());
                    yard = meterinput * 1.0936133;
                    Console.WriteLine(yard);
                    Console.ReadLine();
                    break;
                case 'f':
                    Console.WriteLine("Input a value in meters: ");
                    double metreinput = Convert.ToDouble(Console.ReadLine());
                    feet = metreinput * 3.2808;
                    Console.WriteLine(feet);
                    Console.ReadLine();
                    break;
            }


        }
        public static void Mass() //Converting metric mass units to imperial units.
        {
            Console.WriteLine("Input 'K' to convert kilograms to pounds, 'O' to convert grams to ounces.");
            char charinput = Convert.ToChar(Console.ReadLine());

            double pounds, ounces;

            switch (charinput)
            {
                case 'k':
                    double kginput = Convert.ToDouble(Console.ReadLine());
                    pounds = kginput * 2.20462;
                    Console.WriteLine(kginput + "kg converted to pounds = " + pounds + " lbs");
                    Console.ReadLine();
                    break;
                case 'o':
                    double graminput = Convert.ToDouble(Console.ReadLine());
                    ounces = graminput * 0.03527396;
                    Console.WriteLine(graminput + "grams converted to ounces = " + ounces + "oz");
                    break;
            }
                

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
