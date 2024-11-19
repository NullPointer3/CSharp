﻿namespace Packt.Shared;

public class Person
{
  #region Properties
  public string? Name { get; set; }
  public DateTimeOffset Born { get; set; }
  public List<Person> Children = new();

  // Allow multiple spouses to be stored for a person
  public List<Person> Spouses = new();
  // A read-only property to show if a person is married or not
  public bool Married => Spouses.Count > 0;
  #endregion

  #region Methods
  public void WriteToConsole()
  {
    WriteLine($"{Name} was born on a {Born:dddd}");
  } 

  public void WriteChildrenToConsole()
  {
    string term = Children.Count == 1 ? "Child" : "Children";
    WriteLine($"{Name} has {Children.Count} {term}");
  }

  // Static Method to marry two people
  public static void Marry(Person p1, Person p2)
  {
    ArgumentNullException.ThrowIfNull(p1);
    ArgumentNullException.ThrowIfNull(p2);

    if(p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
    {
      throw new ArgumentException(string.Format("{0} is already married to {1}", arg0: p1.Name, p2.Name));
    }

    p1.Spouses.Add(p2);
    p2.Spouses.Add(p1);
  }

  // Instance method to marry two people
  public void Marry(Person partner)
  {
    Marry(this, partner); // "this" is the current person.
  }

  public void OutputSpouses()
  {
    if(Married)
    {
      string term = Spouses.Count == 1 ? "Person" : "People";
      WriteLine($"{Name} is married to {Spouses.Count} {term}");

      foreach(Person spouse in Spouses)
      {
        WriteLine($"  {spouse.Name}");
      }
    }
    else
    {
      WriteLine($"{Name} is a Singleton");
    }
  }

  /// <summary> 
  /// A static method to multiple "Have children" together
  /// </summary>
  /// <param name="p1">Parent 1</param>
  /// <param name="p2">Parent 2</param>
  /// <returns>A person object that is a child of parent 1 and parent 2</return>
  /// <exception cref="ArgumentNullException">If p1 or p2 are null</exception>
  /// <exception cref="ArgumentException">If p1 and p2 are not married</exception>
  
  public static Person Procreate(Person p1, Person p2)
  {
    ArgumentNullException.ThrowIfNull(p1);
    ArgumentNullException.ThrowIfNull(p2);

    if(!p1.Spouses.Contains(p2) && !p2.Spouses.Contains(p1))
    {
      throw new ArgumentException(string.Format("{0} must be married with {1} to procreate", arg0: p1.Name, arg1: p2.Name));
    }

    Person baby = new()
    {
      Name = $"Baby of {p1.Name} and {p2.Name}",
      Born = DateTimeOffset.Now
    };

    p1.Children.Add(baby);
    p2.Children.Add(baby);

    return baby;
  }

  // An Instance method to "multiply"
  public Person ProcreateWith(Person partner)
  {
    return Procreate(this, partner);
  }
  #endregion

  #region Operators

  // Define the + operator to "Marry"
  public static bool operator +(Person p1, Person p2)
  {
    Marry(p1, p2);

    // Confirm the marriage
    return p1.Married && p2.Married;
  }  

  // Define the * operator to procreate
  public static Person operator *(Person p1, Person p2)
  {
    return Procreate(p1, p2);
  }
  #endregion
}
