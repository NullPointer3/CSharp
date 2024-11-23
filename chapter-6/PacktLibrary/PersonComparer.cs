namespace Packt.Shared;

public class PersonComparer : IComparer<Person?>
{
  public int Compare(Person? x, Person? y)
  {
    int position;

    if ((x is not null) && (y is not null))
    {
      if ((x.Name is not null) && (y.Name is not null))
      {
        // Compare the name length
        int result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
          //...then compare by the names
          return x.Name.CompareTo(y.Name);
        }
        else 
        {
          // otherwise compare by length
          position = result;
        }
      }
      else if ((x.Name is not null) && (y.Name is null))
      {
        position = -1; // x person precedes y person
      }
      else if ((x.Name is null) && (y.Name is not null))
      {
        position = 1; // x person follows y person
      }
      else 
      {
        position = 0; // both x and y are null
      }
    }
    else if ((x is not null) && (y is null))
    {
      position = -1; // x Person precedes the y Person
    }
    else if ((x is null) && (y is not null))
    {
      position = 1; // x Person follows y Person
    }
    else // x and y are both null
    {
      position = 0;
    }
    return position;
  }
}