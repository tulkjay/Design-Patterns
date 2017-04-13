using System;

namespace Decorator.Setup
{
    public static class Helper
    {
        public const string Welcome = "This example follows the decorator design pattern";

        public static void SetTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t========================================\n\t=  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Frank's Employee Registry System   ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("=\n\t========================================\n\n");
            Console.WriteLine(Welcome);
            Set(ConsoleColor.Cyan);
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

        public static void Write(string text, ConsoleColor startColor = ConsoleColor.Magenta, ConsoleColor endColor = ConsoleColor.Cyan)
        {
            Set(startColor);
            Console.WriteLine($"{text}");
            Set(endColor);
        }
    }
}