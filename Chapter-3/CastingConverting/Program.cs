using static System.Convert;
using System.Globalization;
// Converting is known as Casting 
// Varieties of casting: Implicit and explicit
// Implicit: safe, no loss of information
// Explicit: performed manually, may lose information eg: precision

/***
  Casting Numbers implicitly and explicitly
***/

// an int can be safely cast into double (implicitly)
int a = 10;
double b = a;
WriteLine($"a = {a} and b = {b}");

// A double cannot be safely cast into int, can only be done explicitly
double c = 9.8;
//int d = c; // compiler gives an error that you cannot implicitly cast a double into an int
int d = (int)c; // Explicitly casting a double into int
WriteLine($"c = {c} and d = {d}"); // d losses the .8 part

// You perform explicit casting when converting numbers from larger to smaller integers 
// Like the case of converting from long(64-bit) to int(32-bit) 
long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");

WriteLine($"------------------------------------------------------");
// How negative numbers are represented in binary
WriteLine("{0,12} {1,34}", "Decimal", "Binary");
WriteLine("{0,12} {0,34:B32}", int.MaxValue);

for(int i = 8; i >= -8; i--)
{
  WriteLine("{0,12} {0,34:B32}", i);
}
WriteLine("{0,12} {0,34:B32}", int.MinValue);

/****
  Note ,12 and ,34 mean right-align within those column widths. :B32 means
  format as binary padded with leading zeros to a width of 32.
****/

/// Converting with the System.Convert
/// You can only cast between similar types, like whole numbers byte, int, long or class and its subclasses
double g = 9.8;
int h = ToInt32(g); // A method of System.Convert
WriteLine($"g is {g} and h is {h}");

/******
  An important difference between casting and converting is that converting rounds the
  double value 9.8 up to 10 instead of trimming the part after the decimal point. Another
  is that casting can allow overflows while converting will throw an exception.
******/

// Rounding numbers and the default rounding rule
double[,] doubles = {
  { 9.49, 9.5, 9.51 },
  { 10.49, 10.5, 10.51 },
  { 11.49, 11.5, 11.51 },
  { 12.49, 12.5, 12.51 } ,
  { -12.49, -12.5, -12.51 },
  { -11.49, -11.5, -11.51 },
  { -10.49, -10.5, -10.51 },
  { -9.49, -9.5, -9.51 }
};

WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
for(int row = 0; row <= doubles.GetUpperBound(0); row++)
{
  for(int col = 0; col <= doubles.GetUpperBound(1); col++ )
  {
    Write($"| {doubles[row, col],6} | {ToInt32(doubles[row, col]),7} ");
  }
  WriteLine("|");
}
WriteLine();

// Converting from any type to String
// The ToString() method converts the current value of any type to a string
int number = 37;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());

/*****
  Passing any object to the WriteLine method implicitly converts it into a string, so it is
  not necessary to explicitly call ToString
*****/

// Converting from binary object to a string
// ToBase64String and FromBase64String
byte[] binaryObject = new byte[128]; // Allocate an array of 128 bytes

// Populate the array with random bytes
Random.Shared.NextBytes(binaryObject);

WriteLine("Binary Objects as bytes");
for(int i = 0; i < binaryObject.Length; i++)
{
  Write($" {binaryObject[i]:X2} ");
}
WriteLine();

string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");

// Parsing from strings to numbers, or dates and times
// using System.Globalization
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
int friends = int.Parse("24");
DateTime birthday = DateTime.Parse("4 June 1920");
WriteLine($"I have {friends} friends to invite to my party.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

// Avoiding Parse exception by using the TryParse method
/**** 
  One problem of the parse method is that it gives 
  error when it cannot parse the given arg 
****/ 

//int count = int.Parse("abc"); -> throws an exception
Write("How many eggs are there ");
string? input = ReadLine();

if(int.TryParse(input, out int count))
{
  WriteLine($"There are {input} eggs");
}
else
{
  WriteLine($"Parse Error");
}

// Handling Exceptions