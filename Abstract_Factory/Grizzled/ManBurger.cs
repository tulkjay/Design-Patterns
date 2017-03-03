using Abstract_Factory.Core;
using Abstract_Factory.Franks;

namespace Abstract_Factory.Grizzled
{
    public class ManBurger : GroundBeef
    {
        public override string Name { get; set; } = "Man Burger";
        public override string Grade { get; set; }
    }
}