using Abstract_Factory.Core;

namespace Abstract_Factory.Franks
{
    public class FranksPatty : GroundBeef
    {
        public override string Grade { get; set; }
        public override string Name { get; set; } = "Frank's Patty";
    }
}