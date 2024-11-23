using Packt.Shared;

Person harry = new()
{
  Name="Harry",
	Born = new(year: 2001, month: 3, day: 25, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

harry.WriteToConsole();

// Implementing functionality using method
Person lamech = new() {Name = "Lamech"};
Person adah = new() {Name = "Adah"};
Person zillah = new() {Name = "Zillah"};

// call the instance method to marry lamech and adah
lamech.Marry(adah);

// Call static method to marry lamech and zillah
Person.Marry(lamech, zillah);

lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();


// call the instance method to make a baby
Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

// Call the static method to make a baby
Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tucheliban";

adah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();

for(int i = 0; i < lamech.Children.Count; i++)
{
	WriteLine(format: "{0}'s child #{1} is named \"{2}\".", 
	arg0: lamech.Name, arg1: i, arg2: lamech.Children[i].Name);
}

// Implementing functionality using operators
// if(lamech + zillah)
// {
// 	WriteLine($"{lamech.Name} and {zillah.Name} successfully got married");
// }

// // Use the * operator to "multiply".
// Person baby3 = lamech * adah;
// baby3.Name = "Jubal";
// Person baby4 = zillah * lamech;
// baby4.Name = "Naamah";

// Non-generic lookup Collection
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;
WriteLine(format: "Key {0} has value: {1}", arg0: key, arg1: lookupObject[key]);
WriteLine(format: "Key {0} has value: {1}", arg0: harry, arg1: lookupObject[harry]);

// Using Generic types
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Omega");

key = 3;
WriteLine(format: "Key {0} has value: {1}", arg0: key, arg1: lookupIntString[key]);

harry.shout = Harry_shout;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();