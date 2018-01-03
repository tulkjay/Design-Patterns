using static System.ConsoleColor;
using static Decorator.Setup.Helper;

namespace Decorator
{
    public class MageDecorator : Decorator
    {
        private string CoolHat { get; } = "Cool hat";

        public MageDecorator(Character character)
        {
            Character = character;
            Name = character.Name;
            Title = $"{(string.IsNullOrEmpty(character.Title) ? "" : $"{character.Title}-")}Mage";
            Character.Title = Title;
        }

        private string CastFireball()
        {
            return "You cast a fireballlll!";
        }

        public override void ShowBreakdown()
        {
            base.ShowBreakdown();
            Set(Red);
            Write($"\tAdditional Inventory: {CoolHat}");
            Write($"\tSpecial Attack: {CastFireball()}");
            Write();
        }
    }
}