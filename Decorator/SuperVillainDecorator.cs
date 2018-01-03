using static System.ConsoleColor;
using static Decorator.Setup.Helper;

namespace Decorator
{
    public class SuperVillainDecorator : Decorator
    {
        private string Horse { get; } = "Evil War Horse";
        private string Cowl { get; } = "Super Villain Cowl";

        public SuperVillainDecorator(Character character)
        {
            Character = character;
            Name = character.Name;
            Title = $"{(string.IsNullOrEmpty(character.Title) ? "" : $"{character.Title}-")}Super Villain";
            Character.Title = Title;
        }

        private string SneakAttack()
        {
            return "You can do a sneaky super villain attack!";
        }

        private string SummonHordeAttack()
        {
            return "You can summon a horde! Mwuhahah!!";
        }

        public override void ShowBreakdown()
        {
            base.ShowBreakdown();
            Set(Red);
            Write($"\tAdditional Inventory: {Horse}, {Cowl}.");
            Write($"\tSpecial Attacks: {SummonHordeAttack()} and {SneakAttack()}.");
            Write();
        }
    }
}