using System;
using static System.ConsoleColor;

namespace Mediator.Setup
{
    public static class Helper
    {
        public const string Welcome = "This example follows the mediator design pattern";

        public static void SetTitle()
        {
            Console.ForegroundColor = DarkRed;
            Console.Write("\n\t================================\n\t=  ");
            Console.ForegroundColor = Yellow;
            Console.Write(" Frank's Payroll Services   ");
            Console.ForegroundColor = DarkRed;
            Console.Write("=\n\t================================\n\n");
            Console.WriteLine(Welcome);
            Set(Cyan);
            Console.WriteLine();
        }

        public static void Set(ConsoleColor option)
        {
            Console.ForegroundColor = option;
        }

        public static void Hr()
        {
            Console.WriteLine();
            Write(string.Empty.PadLeft(70, '='));
            Console.WriteLine();
        }

        public static void Write(string text, ConsoleColor startColor = Magenta, ConsoleColor endColor = Cyan)
        {
            Set(startColor);
            Console.WriteLine($"{text}");
            Set(endColor);
        }
    }
}