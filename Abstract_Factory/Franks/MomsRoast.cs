using Abstract_Factory.Core;

namespace Abstract_Factory.Franks
{
    public class MomsRoast : Roast
    {
        public override string Name { get; set; } = "Mom's Roast";
        public override string Cut { get; set; }
    }
}