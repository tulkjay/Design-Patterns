using System;
using Decorator.Setup;

namespace Decorator
{
    public class CommonCharacter : Character
    {
        public CommonCharacter(string commonName = "Commoner")
        {
            Name = commonName;
        }

        private string StickAttack()
        {
            return "You Attack with a stick!";
        } 

        public override void ShowBreakdown()
        {
            Helper.Set(ConsoleColor.Green);
            Helper.Write($"\t{Name}");
            Helper.Hr(false);
            Helper.Set(ConsoleColor.Magenta);
            Helper.Write($"\tDefense: {Clothing}.");
            Helper.Write($"\tBase Attack: {StickAttack()}");
        }
    }
}