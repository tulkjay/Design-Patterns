using System;
using System.Diagnostics;
using Bridge.Setup;

namespace Bridge
{
  public static class Program
  {
    static void Main()
    {
      Helper.SetTitle();

      /*
        var chargingService = new CreditCustomerService();
        chargingService.Service = new RoomOrderingService();
        chargingService.Charge();

        chargingService.Service = new CheckoutService();
        chargingService.Charge();

        var specializedService = new RoomServiceService();
        specializedService.Charge();

        specializedService = new BreakfastInBedService();
        specializedService.Charge();

        specializedService.Service = new CheckoutService();
        specializedService.Charge();
    */

      //The bridge design pattern decouples an abstraction from its implementation so that the two can vary independently.

      if (Debugger.IsAttached)
      {
        Console.ReadLine();
      }
    }
  }

  public abstract class ServiceProvider
  {
    public abstract void PerformService();
  }
  public class PayableServices
  {
    protected ServiceProvider _provider;
    public ServiceProvider Provider
    {
      set { _provider = value; }
    }

    public virtual void Complete()
    {
      _provider.PerformService();
    }
  }

  public class SpecializedServices : PayableServices
  {
    public override void Complete()
    {
      _provider.PerformService();
    }
  }
}
