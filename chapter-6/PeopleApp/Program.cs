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