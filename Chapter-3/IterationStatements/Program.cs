using static System.Console;

int x = 0;
while(x < 10)
{
  WriteLine(x);
  x++;
}

string? actualPassword = "Pa$$w0rd";
string? password;

// do 
// {
//   WriteLine("Enter your password");
//   password = ReadLine();
// }
// while(password != actualPassword);
// WriteLine("Correct");

// Looping with the for statement 
for(int i = 0; i < 10; i+=2)
{
  WriteLine(i);
}

// foreach
// it is read-only
string[] names = ["nuhu", "musah", "ibrahim"];
foreach(string name in names)
{
  WriteLine($"{name} has {name.Length} characters");
}

