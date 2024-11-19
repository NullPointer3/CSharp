using Packt.Shared;
using Fruit = (string Name, int Number);

ConfigureConsole();

 Person bob = new()
 {
   Name = "Bob Smith",
   Born = new DateTimeOffset(year: 1965, month: 12, day: 22, hour: 16, minute: 28, second: 0, offset: TimeSpan.FromHours(0)),
   FavoriteAncientWonder = WondersOfTheAncientWorld.TempleOfArtemisAtEphesus,
   BucketList = WondersOfTheAncientWorld.ColossusOfRhodes | WondersOfTheAncientWorld.StatueOfZeusAtOlympia
 };

// Person alfred = new()
// {
//   Name = "Alfred"
// };

// bob.Children.Add(alfred); // works with all versions of c#
// bob.Children.Add(new Person { Name = "Bella" }); // works with c# 3 and later
// bob.Children.Add(new() { Name = "Joe" }); // Wroks with c# 9 and later

// WriteLine(format: "{0} was born on {1:D}.",arg0: bob.Name, arg1: bob.Born);
// WriteLine(
// format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
// arg0: bob.Name,
// arg1: bob.FavoriteAncientWonder,
// arg2: (int)bob.FavoriteAncientWonder);
// WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");
// WriteLine($"{bob.Name} has {bob.Children.Count} children:");

// for(int i = 0; i < bob.Children.Count; i++)
// {
//   WriteLine($"> {bob.Children[i].Name}");
// }

// Making Fields Static
BankAccount.InterestRate = 0.012M; // store a shared value in static field
BankAccount jonesAccount = new()
{
  AccountName = "Jones",
  Balance = 2400,
};
WriteLine(format: "{0} earned {1:C} interest.",
arg0: jonesAccount.AccountName,
arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount AbdallahAccount = new()
{
  AccountName = "Abdallah",
  Balance = 9000
};
WriteLine(format: "{0} earned {1:C} interest.", // The C means use the current culture
arg0: AbdallahAccount.AccountName, 
arg1:AbdallahAccount.Balance * BankAccount.InterestRate );
WriteLine($"{bob.Name} is a {Person.Species}"); // const fields are accessed via the class not instances
WriteLine($"{bob.Name} was born on {bob.HomePlanet}"); // read-only fields are accessed via the instance variable 

// Book book = new()
// {
//   Isbn = "978-1803237800",
//   Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
// };


Person blankPerson = new();
WriteLine(format:
  "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
  arg0: blankPerson.Name,
  arg1: blankPerson.HomePlanet,
  arg2: blankPerson.Instantiated
);

Person ginny = new(initialName: "Ginny", homePlanet: "Mars");
WriteLine(format:
"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: ginny.Name,
arg1: ginny.HomePlanet,
arg2: ginny.Instantiated);

// Seting required field with a constructor
Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
  Author = "Mark Price",
  PageCount = 807,
};
WriteLine("{0}: {1} written by {2} has {3:N0} pages.", book.Isbn, book.Title, book.Author, book.PageCount);

// Methods 
bob.WriteToConsole();
WriteLine(bob.GetOrigin());
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Nuhu")); // method overloading 
WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3,"Jump", 5d, false));
// Naming parameters allows the value to passed in different order
WriteLine(bob.OptionalParameters(count: 4, active: true, command: "Hide!", number: 5.6));
string horizontalLine = new('-', count: 80);
WriteLine(horizontalLine);

int a = 10;
int b = 20;
int c = 30;
int d = 40;

WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

// tuples
(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var (Name, Number) = bob.GetNamedFruit();
WriteLine($"There are {Number} {Name}.");

Fruit fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

var (name1, dob1) = bob; // implicitly calls the Deconstruct method
WriteLine($"Deconstructed person: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

// local functions
int number = 5;
try
{
WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch (Exception ex)
{
WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
}

Person sam = new()
{
  Name = "Sam",
  Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

string color = "black";

try 
{
  sam.FavoritePrimaryColor = color;
  WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");
}
catch(Exception ex)
{
  WriteLine("Tried to set {0} to '{1}': {2}", nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

// Defining indexers
sam.Children.Add(new()
{
  Name = "Charlie",
  Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)
});

sam.Children.Add(new()
{
  Name = "Ella",
  Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero)
});

// Get using Children list.
WriteLine($"Sam's first child is {sam.Children[0].Name}.");
WriteLine($"Sam's second child is {sam.Children[1].Name}.");

// Get using the int indexer.
WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");

// Get using the string indexer.
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");


// Pattern matching with objects
// An array containing a mix of passenger types.
Passenger[] passengers = {
  new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
  new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
  new BusinessClassPassenger { Name = "Janice" },
  new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
  new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" },
};

foreach (Passenger passenger in passengers)
{
  decimal flightCost = passenger switch
  {
    /* C# 8 syntax
    FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
    FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
    FirstClassPassenger _ => 2_000M, */
    FirstClassPassenger p => p.AirMiles switch 
    {
      > 35_000 => 1_500M,
      > 15_000 => 1_750M,
      _ => 2_000M
    },
    BusinessClassPassenger _ => 1_000M,
    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
    CoachClassPassenger _ => 650M,
    _ => 800M
  };
  WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

// init-only properties
ImmutablePerson jeff = new()
{
  FirstName = "Jeff",
  LastName = "Sterling"
};

//jeff.FirstName = "Geoff"; // Immutable after instantiation

// Records 
ImmutableVehicle car = new()
{
  Brand = "Mazda MX-5 RF",
  Color = "Soul Red Crystal Metallic",
  Wheels = 4
};
ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };
WriteLine($"Original car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");

AnimalClass ac1 = new() { Name = "Rex" };
AnimalClass ac2 = new() { Name = "Rex" };

WriteLine($"ac1 == ac2: {ac1 == ac2}");

AnimalRecord ar1 = new() { Name = "Rex" };
AnimalRecord ar2 = new() { Name = "Rex" };
WriteLine($"ar1 == ar2: {ar1 == ar2}");

Headset vp = new("Apple", "Vision Pro");
WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}.");

Headset holo = new();
WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}.");