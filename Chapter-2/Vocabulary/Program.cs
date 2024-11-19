using System.Reflection;

// Implicitly Importing the System.Console method
WriteLine($"The PC is called {Env.MachineName}");

// Assembly? myApp = Assembly.GetEntryAssembly();

// if(myApp is null) return;

// foreach(AssemblyName name in myApp.GetReferencedAssemblies())
// {
//   Assembly a = Assembly.Load(name);

//   int methodCount = 0;
//   foreach (TypeInfo t in a.DefinedTypes)
//   {
//   // Add up the counts of all the methods.
//   methodCount += t.GetMethods().Length;
//   }

//   WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
//   arg0: a.DefinedTypes.Count(),
//   arg1: methodCount,
//   arg2: name.Name);
// }

// nameof returns the name of a variable
double heightInMeters = 1.88;
WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}");

char letter = 'A'; //Assigning Literal Characters

string horizontalLine = new('-', count: 70);
WriteLine(horizontalLine);

string grinningEmoji = char.ConvertFromUtf32(0x1F600);
WriteLine(grinningEmoji);

string name = "Gary Cooper";
int age = 50;

// Raw Interpolated String Literal
string json = $$"""
              {
                "name": {{name}},
                "age": {{age}}
              }
              """;
WriteLine(json);