using Packt.Shared;

Person harry = new()
{
  Name = "Harry",
  Born = new(year: 2000, month: 4, day: 16, hour: 11, minute: 0, second: 0, offset: TimeSpan.Zero)
};

harry.WriteToConsole();
harry.WriteChildrenToConsole();

// Implementing functionality using methods
Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

// call the instance method to marry lamech to adah
lamech.Marry(adah);

// call the static method to marry lamech and zillah
//Person.Marry(lamech, zillah);

lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();

// Call the instance method to make a baby
Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

// call static method to make a baby
//Person baby2 = Person.Procreate(lamech, zillah);
//baby2.Name = "Tucheliban";

adah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();

// Loop through lamech's children
for(int i = 0; i < lamech.Children.Count; i++)
{
  WriteLine("{0}'s Child #{1} is named \"{2}\".", lamech.Name, i, lamech.Children[i].Name);
}

if (lamech + zillah)
{
  WriteLine($"{lamech.Name} and {zillah.Name} successfully got married");
}

// use * operator to multiply
Person baby3 = lamech * adah;
baby3.Name = "Artenyahu";

Person baby4 = zillah * lamech;
baby4.Name = "Hansi";