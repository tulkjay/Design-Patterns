using Abstract_Factory.Franks;

namespace Abstract_Factory.Core
{
    public abstract class Steak : Item
    {
        public abstract string Cut { get; set; }
    }
}