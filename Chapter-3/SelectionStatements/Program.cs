using static System.Console;
// Pattern matching with the if statement
object o = 3;
int j = 4;

if(o is int i) // stores the value of o in i if it is an int 
{
  WriteLine($"{i} x {j} = {i * j}");
}
else
{
  WriteLine("O is not an int so it cannot multiply");
}

BranchSwitch();
static void BranchSwitch()
{
  int number = Random.Shared.Next(minValue: 1, maxValue: 7);
  WriteLine($"My number is {number}");

  switch (number)
  {
    case 1:
      WriteLine("One");
      break;
    case 2:
      WriteLine("Two");
      goto case 1;
    case 3:
    case 4:
      WriteLine("Three or Four");
      goto case 1;
    case 5:
      goto A_label;
    default:
      WriteLine("default");
      break;
  }
  WriteLine("After end of switch");
  A_label:
  WriteLine($"After A_label");
}

var animals = new Animal?[]
{
  new Cat {
    Name ="Karen",
    Birth = new(year: 2022, month: 8, day: 23),
    Legs = 4,
    IsDomestic = true
  },
  null,
  new Cat { 
    Name = "Mufasa", 
    Birth = new(year: 1994, month: 6,day: 12) 
  },

  new Spider { 
    Name = "Sid Vicious", 
    Birth = DateTime.Today,
    IsPoisonous = true
  },
  new Spider { 
    Name = "Captain Furry", 
    Birth = DateTime.Today 
  }
};

foreach( Animal? animal in animals)
{
  string message;

  switch (animal)
  {
    case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
    message = $"The cat named {fourLeggedCat.Name} has four legs.";
    break;
    case Cat wildCat when wildCat.IsDomestic == false:
    message = $"The non-domestic cat is named {wildCat.Name}.";
    break;
    case Cat cat:
    message = $"The cat is named {cat.Name}.";
    break;
    default: // default is always evaluated last.
    message = $"{animal.Name} is a {animal.GetType().Name}.";
    break;
    case Spider spider when spider.IsPoisonous:
    message = $"The {spider.Name} spider is poisonous. Run!";
    break;
    case null:
    message = "The animal is null.";
    break;
}
  WriteLine($"switch statement: {message}");
}