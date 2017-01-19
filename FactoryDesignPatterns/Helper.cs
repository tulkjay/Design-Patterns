using System;

namespace FactoryDesignPatterns
{
    public static class Helper
    {
        public enum Options
        {
            Title,
            Method,
            G, C, B
        }

        public const string MethodWelcome = "This example follows the factory method design pattern";

        public static void Set(Options[] options, bool setTitle = false)
        {
            if (setTitle)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n\t========================\n" +
                                    $"\t=  Frank's Meat House  =\n" +
                                    $"\t========================\n");
            }

            foreach (var option in options)
            {
                switch (option)
                {
                    case Options.Method:
                        Console.WriteLine(MethodWelcome);
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