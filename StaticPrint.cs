using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnums
{
    static class StaticPrint
    {
        public enum Colors
        {
            blue,
            yellow,
            white, 
            green,
            red
        }
        //----------------------

        public static void Print(string text, Colors color)
        { 
                switch (color)
                {
                case Colors.blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(text);
                    break;

                case Colors.yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(text);
                    break;

                case Colors.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(text);
                    break;

                case Colors.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(text);
                    break;

                case Colors.white:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(text);
                    break;

                default:
                    {
                        Console.WriteLine("Something went wrong!");
                        break;
                    }
                }
        }
        //-------------------------------------------------------
    }
}
