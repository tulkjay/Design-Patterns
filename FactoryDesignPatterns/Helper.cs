using System;

namespace FactoryDesignPatterns
{
    public static class Helper
    {
        public enum Options
        {
            Title,
            Simple,
            G, C, B
        }

        public const string SimpleWelcome = "This example follows a simple factory design pattern:\n";

        public static void Set(Options[] options, bool setTitle = false)
        {
            if (setTitle)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n\t===============================\n" +
                                    $"\t=  Frank's Ground Beef House  =\n" +
                                    $"\t===============================");
            }

            foreach (var option in options)
            {
                switch (option)
                {
                    case Options.Simple:
                        Console.WriteLine(SimpleWelcome);
                        break;

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
        }

        public static void Write(string text)
        {
            Console.WriteLine($"\t{text}");
        }
    }
}