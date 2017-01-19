using System;

namespace FactoryDesignPatterns
{
    public static class Helper
    {
        public enum Options
        {
            G, C, B
        }

        public const string AbstractWelcome = "This example follows the abstract factory design pattern";

        public static void Set(Options option, bool setTitle = false)
        {
            if (setTitle)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n\t================\n" +
                                    $"\t=  Meat World  =\n" +
                                    $"\t================\n");
                Console.WriteLine(AbstractWelcome);
            }

            switch (option)
            {
                case Options.G:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case Options.C:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                case Options.B:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(option), option, null);
            }
            Console.WriteLine();
        }

        public static void Write(string text)
        {
            Console.WriteLine($"\t{text}");
        }
    }
}