﻿using System.Data.Common;

namespace Packt.Shared;

public class Person: IComparable<Person?>
{
  #region Properties
  public string? Name { get; set; }
  public DateTimeOffset Born { get; set; }
  public List<Person> Children = new();

  // Allow multiples spouses to be stored for a person
  public List<Person> Spouses = new();

  // A read-only property to show if a person is married to anyone
  public bool Married => Spouses.Count > 0;

  #endregion


  #region Methods
  
  public void WriteToConsole()
  {
    WriteLine($"{Name} was born on a {Born:dddd}.");   
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

    if (p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
    {
      throw new ArgumentException(
        string.Format("{0} is already married to {1}", arg0: p1.Name, arg1: p2.Name));
    }

    p1.Spouses.Add(p2);
    p2.Spouses.Add(p1);
  }

  // Instace Method to marry another person
  public void Marry(Person partner)
  {
    Marry(this, partner); // "this" is the current person
  }

  public void OutputSpouses()
  {
    if(Married)
    {
      string term = Spouses.Count == 1 ? "person" : "people";
      WriteLine($"{Name} is married to {Spouses.Count} {term}");

      foreach(Person spouse in Spouses)
      {
        WriteLine($" {spouse.Name}");
      }
    }
    else
    {
      WriteLine($"{Name} is a Singleton");
    }
  }

  /// <summary>
  /// Static method to "multiply" aka procreate and have a child together.
  /// </summary>
  /// <param name="p1">Parent 1</param>
  /// <param name="p2">Parent 2</param>
  /// <returns>A Person object that is the child of Parent 1 and Parent2.</returns>
  /// <exception cref="ArgumentNullException">If p1 or p2 are null.</exception>
  /// <exception cref="ArgumentException">If p1 and p2 are not married.</exception>
  /// 

  public static Person Procreate(Person p1, Person p2)
  {
    ArgumentNullException.ThrowIfNull(p1);
    ArgumentNullException.ThrowIfNull(p2);

    if(!p1.Spouses.Contains(p2) && !p2.Spouses.Contains(p1))
    {
      throw new ArgumentException(string.Format(
        "{0} must be married to {1} to procreate with them.",
        arg0: p1.Name, arg1: p2.Name)
      );
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

  // Instance method to "multiply"
  public Person ProcreateWith(Person partner)
  {
    return Procreate(this, partner);
  }

  #endregion

  #region Operators

  // Define the + Operator to marry
  public static bool operator +(Person p1, Person p2)
  {
    Marry(p1, p2);

    return p1.Married && p2.Married;
  }

  // Define the * operator to "multiply"
  public static Person operator *(Person p1, Person p2)
  {
    return Procreate(p1, p2);
  }
    
  #endregion

  #region Events

  // Delegate field to define the event
  public EventHandler? shout;

  // Date field related to the event
  public int AngerLevel;

  // Method to trigger the event in certain conditions
  public void Poke()
  {
    AngerLevel++;

    if (AngerLevel < 3) return;

    // if something is listening to the event
    if (shout is not null)
    {
      //...then call the delegate to raise the event
      shout(this, EventArgs.Empty);
    }
  }

    public int CompareTo(Person? other)
    {
      int position;
      if (other is not null)
      {
        if ((Name is not null) && (other.Name is not null))
        {
          // Use the string implementation of CompareTo
          position = Name.CompareTo(other.Name);
        }
        else if ((Name is not null) && (other.Name is null))
        {
          position = -1; // this person precedes the other person
        }
        else if ((Name is null) && (other.Name is not null))
        {
          position = 1; // this person follow other person
        }
        else 
        {
          position = 0; // this and the other are the same position
        }
      }
      else if (other is null)
      {
        position = -1; // this person precedes the other person
      }
      else
      {
        position = 0; // this Person and the other are the same
      }
      return position;
    }

    #endregion
}
