using System;

namespace Decorator.OrderDependent.Setup
{
    public static class Helper
    {
        public const string Welcome = "This example follows the decorator design pattern";
        public static ConsoleColor CurrentConsoleColor;
        public static void SetTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t================================\n\t=  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Frank's Ordering Service   ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("=\n\t================================\n\n");
            Console.WriteLine(Welcome);
            Set(ConsoleColor.Cyan);
            Console.WriteLine();
        }

        public static void Set(ConsoleColor option)
        {
            CurrentConsoleColor = option;
            Console.ForegroundColor = CurrentConsoleColor;
        }

        public static void Hr(bool newline = true)
        {
            Write(string.Empty.PadLeft(70, '=') + $"{(newline ? "\n" : "")}");
        }

        public static void Write(string text = "", ConsoleColor? startColor = null)
        {
            Set(startColor ?? CurrentConsoleColor);
            Console.WriteLine($"{text}");
        }
    }
}