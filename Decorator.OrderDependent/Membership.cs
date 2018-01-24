namespace Decorator.OrderDependent
{
  public abstract class Membership
  {
    public double Discount { get; set; }
    public string Name { get; set; }
  }

  public class GoldMembership : Membership
  {
    public GoldMembership()
    {
      Name = "Gold";
      Discount = 0.07;
    }
  }

  public class SilverMembership : Membership
  {
    public SilverMembership()
    {
      Name = "Silver";
      Discount = 0.05;
    }
  }

  public class DiamondMembership : Membership
  {
    public DiamondMembership()
    {
      Name = "Diamond";
      Discount = 0.1;
    }
  }
}