namespace Decorator
{
    public abstract class Character
    {
        public string Name { get; set; }

        public string Clothing { get; } = "Shirt, Pants, Shoes";

        public string Title;

        public abstract void ShowBreakdown();
    }
}