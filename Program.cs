// Move all common properties in your vehicles to a new Vehicle class.
// Create an instance of each vehicle.
// Define a different value for each vehicle's properties.
// Create a Drive() method in the Vehicle class.
// Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!").

using System;

namespace colors_sounds
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
    // VIRTUAL FN THAT CAN BE OVERRIDEN BY A DERIVED CLASS
    public virtual void Drive()
    {
      Console.WriteLine("Vrooom!");
    }
  }

  public class Zero : Vehicle
  {  // Electric motorcycle
    public double BatteryKWh { get; set; }
    public void ChargeBattery() { System.Console.WriteLine("Charged"); }
    public override void Drive()
    {
      System.Console.WriteLine("Brrrrrrrrr!!!!");
    }
  }

  public class Cessna : Vehicle
  {  // Propellor light aircraft
    public void RefuelTank() { System.Console.WriteLine("Fueled"); }
    public override void Drive()
    {
      Console.WriteLine("Zoooooom!");
    }
  }


public class Tesla : Vehicle
{  // Electric car
  public double BatteryKWh { get; set; }
  public void ChargeBattery() { System.Console.WriteLine("Charged"); }
  public override void Drive()
  {
    System.Console.WriteLine("Zooooooooink!");
  }
}
public class Ram : Vehicle
{  // Gas powered truck
  public double FuelCapacity { get; set; }
  public void RefuelTank() { System.Console.WriteLine("Fueled"); }
  public override void Drive()
  {
    System.Console.WriteLine("Chakachakachakachaka!");
  }
}


class Program
{
  static void Main(string[] args)
  {
      Zero motorcycle = new Zero(){MainColor="Black", MaximumOccupancy="1"};
      Cessna cess = new Cessna(){MainColor="White", MaximumOccupancy="4"};
      Tesla musk = new Tesla(){MainColor="Blue", MaximumOccupancy="5"};
      Ram dixie = new Ram(){MainColor="Red", MaximumOccupancy="6"};

      motorcycle.Drive();
      cess.Drive();
      musk.Drive();
      dixie.Drive();
  }
}
}