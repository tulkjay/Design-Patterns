using System;
using System.Diagnostics;
using static System.ConsoleColor;
using static Decorator.Setup.Helper;

namespace Decorator
{
    public static class Program
    {
        public static void Main()
        {
            SetTitle();

            Character rudy, maggie;

            Introduction(out rudy, out maggie);

            Write("Then they went to the Academy anddd...\n", Cyan);

            var mage = new MageDecorator(rudy);
            var knight = new KnightDecorator(maggie);

            Write($"{mage.Name} became a {mage.Title}!!?!\n");
            mage.ShowBreakdown();

            Write();

            Write($"{knight.Name} became a {knight.Title}...  :O\n", Cyan);
            knight.ShowBreakdown();

            Write();

            PlotTwist(knight);

            Write();

            SecondPlotTwist(mage);

            if (Debugger.IsAttached)
            {
                Set(Cyan);
                Write();
                Write("Press Enter to exit... ", Cyan);
                Console.ReadLine();
            }
        }

        private static void SecondPlotTwist(Character mage)
        {
            var villainKnight = new SuperVillainDecorator(new KnightDecorator(mage));

            Write($"Another surprise twist: {mage.Name} turned evil, goes back to the academy and becomes a {villainKnight.Title}. BAMPH!\n", Yellow);

            villainKnight.ShowBreakdown();
        }

        private static void PlotTwist(KnightDecorator knight)
        {
            var battleMage = new MageDecorator(knight);

            Write($"Surprise twist: {knight.Name} goes back to the academy and becomes a {battleMage.Title}(battlemage)!??! WUUUUT\n", Yellow);

            battleMage.ShowBreakdown();
        }

        private static void Introduction(out Character protagonistA, out Character protagonistB)
        {
            protagonistA = new CommonCharacter("Rutherford Cornelius Parrington");
            protagonistB = new CommonCharacter("Magnus Stonewall");
            Write($"In the beginning there were two normal people, {protagonistA.Name} and {protagonistB.Name}...", Cyan);
            Write();

            protagonistA.ShowBreakdown();
            Write();
            protagonistB.ShowBreakdown();

            Write();
        }
    }
}