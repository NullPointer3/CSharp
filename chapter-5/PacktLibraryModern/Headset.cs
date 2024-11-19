namespace Packt.Shared;

// Defining one constructor as part of the class definition
public class Headset(string manufacturer, string productName)
{
  public string Manufacturer { get; set; } = manufacturer;
  public string ProductName { get; set; } = productName;

  public Headset() : this("Microsoft", "HoloLens") { }
}