namespace Factory_Method.Core
{
    public abstract class Beef
    {
        public abstract string Name { get; set; }
    }

    public abstract class BeefFactory
    {
        public abstract Beef ProcessBeef();
    }
}