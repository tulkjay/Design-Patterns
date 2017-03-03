using Abstract_Factory.Core;

namespace Abstract_Factory.Franks
{
    public class HomestyleSteak : Steak
    {
        public override string Name { get; set; } = "Homestyle Steak";
        public override string Cut { get; set; }
    }
}