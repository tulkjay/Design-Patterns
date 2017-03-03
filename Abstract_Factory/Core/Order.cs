namespace Abstract_Factory.Core
{
    public class Order
    {
        public int UnitsOfGroundBeef { get; set; }
        public int UnitsOfSteak { get; set; }
        public int UnitsOfRoast { get; set; }

        public Order(int groundBeef = 0, int steak = 0, int roast = 0)
        {
            UnitsOfGroundBeef = groundBeef;
            UnitsOfSteak = steak;
            UnitsOfRoast = roast;
        }
    }
}