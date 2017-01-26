using System;

namespace FactoryDesignPatterns.Setup
{
    public static class Helper
    {
        public enum Options
        {
            G, C, B, M, R, Y
        }

        public const string Welcome = "This example follows the builder design pattern";

        public static void Set(Options option, bool setTitle = false)
        {
            if (setTitle)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n\t================================\n" +
                                    $"\t=  Frank's In And Out Burgers  =\n" +
                                    $"\t================================\n");
                Console.WriteLine(Welcome);
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

                case Options.M:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                case Options.R:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case Options.Y:
                    Console.ForegroundColor = ConsoleColor.Yellow;
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