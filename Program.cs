// Move all common properties in your vehicles to a new Vehicle class.
// Create an instance of each vehicle.
// Define a different value for each vehicle's properties.
// Create a Drive() method in the Vehicle class.
// Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!").
// using System;

namespace colors_sounds
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
  }

  public class Zero : Vehicle
  {  // Electric motorcycle
    public double BatteryKWh { get; set; }
    public void ChargeBattery() { System.Console.WriteLine("Charged"); }
  }

  public class Cessna : Vehicle
  {  // Propellor light aircraft
    public string MaximumOccupancy { get; set; }
    public void RefuelTank() { System.Console.WriteLine("Fueled"); }
  }

  public class Tesla : Vehicle
  {  // Electric car
    public double BatteryKWh { get; set; }
    public void ChargeBattery() { System.Console.WriteLine("Charged"); }
  }
  public class Ram : Vehicle
  {  // Gas powered truck
    public double FuelCapacity { get; set; }
    public void RefuelTank() { System.Console.WriteLine("Fueled"); }
  }




  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
