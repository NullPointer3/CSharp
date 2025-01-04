using Packt.Shared;

Person harry = new() 
{
  Name = "Harry",
  Born = new(year: 2001, month: 3, day: 25, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

harry.WriteToConsole();

// Implementing functionality using methods 
Person lamech = new() { Name = "lamech"};
Person adah = new() { Name = "Ada"};
Person zillah = new() { Name = "Zillah" };

// call instance method to marry Lamech and Ada
lamech.Marry(adah);

// call static method to marry lamech and zilla
Person.Marry(lamech, zillah);

lamech.OutputSpouses();
zillah.OutputSpouses();
adah.OutputSpouses();


// call instance method to make a baby
Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jamal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

// call static method to make a baby
Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tucheliban";


adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for(int i = 0; i < lamech.Children.Count; i++)
{
  WriteLine(format: "{0}'s child #{1} is named \"{2}\"", arg0: lamech.Name, arg1: i, arg2: lamech.Children[i].Name);
}

// non-generic lookup collection
System.Collections.Hashtable lookupObject = [];
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Omega");
lookupObject.Add(key: harry, value: "Gamma");

int key = 2;

WriteLine(format: "Key {0} has value {1}", arg0: key, arg1: lookupObject[key]);
WriteLine(format: "Key {0} has value {1}", arg0: harry, arg1: lookupObject[harry]);

// Define a generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Omega");

key = 3;
WriteLine(format: "Key {0} has value: {1}", arg0: key, arg1: lookupIntString[key]);
