using Abstract_Factory.Core;
using Abstract_Factory.Franks;

namespace Abstract_Factory.Grizzled
{
    public class FlintstonesSteak : Steak
    {
        public override string Name { get; set; } = "The Flintstone";
        public override string Cut { get; set; }
    }
}