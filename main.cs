using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace UnitConversionApp
{
    public static class Main
    {
        public static void MainMenu()
        {
            Console.WriteLine("Input 'M' to convert metric units to imperial.");
            Console.WriteLine("Input 'I' to convert imperial units to metric.");
            ConsoleKeyInfo keyinfo = Console.ReadKey();
            switch (keyinfo.Key)
            {
                case ConsoleKey.M:
                    
                    break;
                case ConsoleKey.I:
                    
                    break;
            }   

        }
        
    }
    
}
