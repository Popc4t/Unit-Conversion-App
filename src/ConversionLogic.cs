using System;

namespace UnitConversionApp
{
    public static class Metric // Converting metric units to imperial.
    {
        
        public static void ToFahrenheit()
        {
            Console.WriteLine("\nInput a value in Celsius to convert to Fahrenheit:");
            double celsiusinput = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celsiusinput * 9 / 5 + 32;
            Console.WriteLine("\n" + celsiusinput + "°C converted to Fahrenheit = " + fahrenheit + "°F");
            MainMenu.Controls();
        }
        public static void ToPounds()
        {
            Console.WriteLine("\nInput a value in kilograms to convert to pounds:");
            double kiloinput = Convert.ToDouble(Console.ReadLine());
            double pounds = kiloinput * 2.204623;
            Console.WriteLine("\n" + kiloinput + "kg converted to pounds = " + pounds + " lbs");
            MainMenu.Controls();
        }
        public static void ToFeet()
        {
            Console.WriteLine("\nInput a value in meters to convert to feet:");
            double meterinput = Convert.ToDouble(Console.ReadLine());
            double feet = meterinput * 3.28084;
            Console.WriteLine("\n" + meterinput + " meters converted to feet = " + feet + " ft");
            MainMenu.Controls();
        }
    }
    public static class Imperial
    {
        public static void ToCelsius()
        {
            Console.WriteLine("\nInput a value in Fahrenheit to convert to Celsius: ");
            double fahrenheitinput = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheitinput - 32) * 5 / 9;
            Console.WriteLine("\n" + fahrenheitinput + "°F converted to Celsius = " + celsius + "°C");
            MainMenu.Controls();
        }
        public static void ToKilograms()
        {
            Console.WriteLine("\nInput a value in pounds to convert to kilograms:");
            double poundinput = Convert.ToDouble(Console.ReadLine());
            double kilograms = poundinput * 0.453592;
            Console.WriteLine("\n" + poundinput + " lbs converted to kilograms = " + kilograms + " kg");
            MainMenu.Controls();
        }
        public static void ToMeters()
        {
            Console.WriteLine("\nInput a value in feet to convert to meters:");
            double ftinput = Convert.ToDouble(Console.ReadLine());
            double meters = ftinput * 0.3048;
            Console.WriteLine("\n" + ftinput + " meters converted to feet = " + meters + " ft");
            MainMenu.Controls();
        }

    }

}