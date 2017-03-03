using System;

namespace Builder.Setup
{
    public static class Helper
    {
        public enum Options
        {
            G, C, B, M, DR, Y
        }

        public const string Welcome = "This example follows the builder design pattern";

        public static void Set(Options option, bool setTitle = false)
        {
            if (setTitle)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n\t================================\n\t=  ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Frank's In And Out Burgers  ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("=\n\t================================\n\n");
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

                case Options.DR:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
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