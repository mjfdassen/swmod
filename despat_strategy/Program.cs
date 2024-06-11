using System;
namespace StrategyPattern
{
    public abstract class VehicleBehavior
    {
        public abstract void AboutMe(string vehicle);
    }

    class FloatBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My {vehicle} can float now.");
        }
    }
  
    class FlyBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My {vehicle} can fly now.");
        }
    }

    class InitialBehavior : VehicleBehavior
    {
        public override void AboutMe(string vehicle)
        {
            Console.WriteLine($"My {vehicle} is just born.It cannot do anything special.");
        }
    }
 
    public class Vehicle
    {
        VehicleBehavior behavior;
        string vehicleType;
        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
            //Setting the initial behavior
            this.behavior = new InitialBehavior();
        }
 
        public void SetVehicleBehavior(VehicleBehavior behavior)
        {
            this.behavior = behavior;
        }
   
        public void DisplayAboutMe()
        {
            behavior.AboutMe(vehicleType);
        }
    }

    class Client
    {
        static void Main(string[] args)
            {
                Console.WriteLine("***Strategy Pattern Demo.***\n");
                Vehicle context = new Vehicle("Aeroplane");
                context.DisplayAboutMe();
                Console.WriteLine("Setting flying capability to vehicle.");
                context.SetVehicleBehavior(new FlyBehavior());
                context.DisplayAboutMe();
                Console.WriteLine("Changing the vehicle behavior again.");
                context.SetVehicleBehavior(new FloatBehavior());
                context.DisplayAboutMe();
                Console.ReadKey();
        }
    }
}