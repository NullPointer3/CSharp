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


