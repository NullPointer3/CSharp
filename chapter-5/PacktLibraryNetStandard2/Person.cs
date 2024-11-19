namespace Packt.Shared;

public partial class Person: object
{
  #region Fields: Data or state for this Person
  public string? Name;
  public DateTimeOffset Born;

  // This has been moved to PersonAutoGen.cs as a property.
  // public WondersOfTheAncientWorld FavoriteAncientWonder;
  public WondersOfTheAncientWorld BucketList;
  public List<Person> Children = new();
  public const string Species = "Homo Sepiens";
  public readonly string HomePlanet = "Earth";
  public readonly DateTime Instantiated;

  #endregion  

  #region Constructors: Called when using new to instantiate a type
  public Person()
  {
    // constructors can set default values for fields
    Name = "Unknown";
    Instantiated = DateTime.Now;
  }

  // You can have multiple constructors in a type
  public Person(string initialName, string homePlanet)
  {
    Name = initialName;
    HomePlanet = homePlanet;
    Instantiated = DateTime.Now;
  }
  #endregion

  #region Methods: Actions the type can perform
  public void WriteToConsole()
  {
    WriteLine($"{Name} was born on {Born:dddd}");
  }

  public string GetOrigin()
  {
    return $"{Name} was born on {HomePlanet}";
  }

  public string SayHello()
  {
    return $"{Name} says Hello!";
  }
  public string SayHello(string name) // method overloading
  {
    return $"{Name} says Hello to {name}!";
  }

  public string OptionalParameters(int count, string command = "Run!", double number = 0.0, bool active = true)
  {
    return $"count is {count}, command is {command}, number is {number}, active is {active}";
  }

  // Passing Parameters 
  public void PassingParameters(int w, in int x, ref int y, out int z)
  {
    // out parameters cannot have default and must be 
    // Innitialized inside the method
    z = 100;

    // Increment each param except the in param (read-only)
    w++;
    // x++ gives compile error as the param is read-only 
    y++;
    z++;
    WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
  }

  public (string, int) GetFruit()
  {
    return ("Apple", 50);
  }

  // naming the fields of a tuple
  public (string Name, int Number) GetNamedFruit()
  {
    return (Name: "Oranges", Number: 12);
  }

  // Deconstructing other types using tuples
  public void Deconstruct(out string? name, out DateTimeOffset dob)
  {
    name = Name;
    dob = Born;
  } 

  public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
  {
    name = Name;
    dob = Born;
    fav = FavoriteAncientWonder;
  }

  // implementing local functions
  public static int Factorial(int number)
  {
    if(number < 0)
    {
      throw new ArgumentException($"{nameof(number)} cannot be less than zero");
    }
    return localFactorial(number);

    int localFactorial(int localNumber)
    {
      if (localNumber == 0) return 1;
      return localNumber * localFactorial(localNumber - 1);
    }
  }
  #endregion

}