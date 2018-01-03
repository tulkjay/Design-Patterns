using static System.ConsoleColor;
using static Decorator.Setup.Helper;

namespace Decorator
{
    public class KnightDecorator : Decorator
    {
        private string Helmet { get; } = "Metal helmet";
        private string Armor { get; } = "Generic metal armor digs";
        private string Shield { get; } = "Strong metal shield";

        public KnightDecorator(Character character)
        {
            Character = character;
            Name = character.Name;
            Title = $"{(string.IsNullOrEmpty(character.Title) ? "" : $"{character.Title}-")}Knight";
            Character.Title = Title;
        }

        private string SwordAttack()
        {
            return "You can do a sword attack!";
        }

        private string Parry()
        {
            return "You parry an attack!?! Bwuah!";
        }

        public override void ShowBreakdown()
        {
            base.ShowBreakdown();
            Set(Red);
            Write($"\tAdditional Inventory: {Helmet}, {Armor}, {Shield}.");
            Write($"\tSpecial Attack: {SwordAttack()}.");
            Write($"\tAdditional Defense: {Parry()}.");
            Write();
        }
    }
}