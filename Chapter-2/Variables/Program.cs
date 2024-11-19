// Storing any type with object
// The type of object is not known at compile time
using System.Xml;
using static System.Console;

object height = 1.88;
object name = "Travis";
WriteLine($"{name} is {height} meters tall");

//int length1 = name.Length; // cannot invoke this method as the type of name is unknown
int length2 = ((string)name).Length; // casting
WriteLine($"{name} has {length2} Characters");

// Storing Dynamic types using dynamic
// Values stored in dynamic can have its members invoked without an explicit casting
// Comes at the cost of performance
// Takes the type the last data type it is stored to

dynamic something; // declaring a dynamic var
something = new[] {3,5,7}; //storing an array of int type in a dynamic var
something = 12; // stroring an int in dynamic type
something = "Travis"; // string a string in a dynamic type

WriteLine($"The Length of something is {something.Length}"); //might throw an exception error at run-time
WriteLine($"something is {something.GetType()}");

/// Specifying the types of local variables
var population = 67_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "apple";
var letter = 'Z';
var happy = false;

var xml1 = new XmlDocument();
XmlDocument xml2 = new(); // target-typed

/// Getting default types
WriteLine($"default(int) = {default(int)}");
WriteLine($"default(bool) = {default(bool)}");
WriteLine($"default(DateTime) = {default(DateTime)}");
WriteLine($"default(string) = {default(string)}");

// Outputs ABC in the same line
Write("A");
Write("B");
Write("C");

WriteLine();

// Formatting using numbers Positional Arguments
int numberOfApples = 12;
decimal pricePerApple = 0.45M;
WriteLine(
  format: "{0} apples cost {1:c}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples 
);

WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.",
"Roger", "Cevung", "Stockholm", "Education", "Optimizely");

// Promting the user for input
WriteLine("Type Your first name and press Enter");
string? firstName = ReadLine();

WriteLine("Enter your age");
string age = ReadLine()!;

WriteLine($"{firstName} is {age} years old");