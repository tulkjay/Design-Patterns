using System;
using System.Collections.Generic;
using static DesignPatterns.Setup.Helper;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main()
        {
            Set(Options.G, true);

            var kitchen = new Kitchen();

            var cheeseBurger = kitchen.MakeBurger(new CheeseburgerBuilder());
            Display(cheeseBurger);
            Set(Options.M);

            var pattyMelt = kitchen.MakeBurger(new PattyMeltBuilder());
            Display(pattyMelt);
            Set(Options.B);

            var poboy = kitchen.MakeBurger(new PoboyBuilder());
            Display(poboy);

            Set(Options.G);
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void Display(Burger burger)
        {                      
            Console.WriteLine($"From the kitchen came a {burger.Name}");
            Set(Options.C);
            Console.WriteLine($"\tA {burger.Name} is made with {burger.Meat}" +
                              $" on a {burger.Bread}\n" +
                              $"\ttopped with {string.Join(", ", burger.Dressings)}\n");            
        }
    }

    public class Kitchen
    {
        public Burger MakeBurger(Builder builder)
        {
            builder.AddBread();
            builder.AddMeat();
            builder.AddDressings();
            return builder.DeliverBurger();
        }
    }

    public abstract class Builder
    {
        public abstract void AddBread();
        public abstract void AddDressings();
        public abstract void AddMeat();
        public abstract Burger DeliverBurger();
    }

    public class Burger
    {
        public string Name;
        public List<string> Dressings { get; set; } = new List<string>();
        public string Meat { get; set; }
        public string Bread { get; set; }
    }

    public class CheeseburgerBuilder : Builder
    {
        private readonly Burger _cheeseburger;
        public CheeseburgerBuilder()
        {
            _cheeseburger = new Burger {Name = "Cheeseburger"};
        }
        public override void AddBread()
        {
            _cheeseburger.Bread = "Bun";
        }

        public override void AddDressings()
        {
            _cheeseburger.Dressings
                .AddRange(new[]
                {
                    "Lettuce", "Tomatoes", "Cheese", " Onions", " Pickles", "Ketchup", "Mustard"
                });
        }

        public override void AddMeat()
        {
            _cheeseburger.Meat = "Ground Beef";
        }

        public override Burger DeliverBurger()
        {
            return _cheeseburger;
        }
    }

    public class PattyMeltBuilder : Builder
    {
        private readonly Burger _pattyMelt;

        public PattyMeltBuilder()
        {
            _pattyMelt = new Burger {Name = "Patty Melt"};
        }

        public override void AddBread()
        {
            _pattyMelt.Bread = "Buttered Toast Slice";
        }

        public override void AddMeat()
        {
            _pattyMelt.Meat = "Onions and Ground Beef";
        }        

        public override void AddDressings()
        {
            _pattyMelt.Dressings.AddRange(new[] {"Cheese", "Caramelized Onions"});
        }

        public override Burger DeliverBurger()
        {
            return _pattyMelt;
        }
    }

    public class PoboyBuilder : Builder
    {
        private readonly Burger _poboy;

        public PoboyBuilder()
        {
            _poboy = new Burger {Name = "Poboy"};
        }

        public override void AddBread()
        {
            _poboy.Bread = "Baguette-Style French Bread";
        }

        public override void AddMeat()
        {
            _poboy.Meat = "Fried Shrimp";
        }

        public override void AddDressings()
        {
            _poboy.Dressings.AddRange(new[] {"Lettuce", "Mayonnaise"});
        }

        public override Burger DeliverBurger()
        {
            return _poboy;
        }
    }
}