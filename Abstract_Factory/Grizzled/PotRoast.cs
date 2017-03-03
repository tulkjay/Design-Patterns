using Abstract_Factory.Core;
using Abstract_Factory.Franks;

namespace Abstract_Factory.Grizzled
{
    public class PotRoast : Roast
    {
        public override string Name { get; set; } = "The Pot Roast";
        public override string Cut { get; set; }
    }
}