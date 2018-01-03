using static System.ConsoleColor;
using static Decorator.Setup.Helper;

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
            Set(Green);
            Write($"\t{Name}");
            Hr(false);
            Set(Magenta);
            Write($"\tDefense: {Clothing}.");
            Write($"\tBase Attack: {StickAttack()}");
            Write();
        }
    }
}