// WorkingWithIntegers();

static void WorkingWithIntegers()
{
  int a = 18;
  int b = 12;
  int c = a + b;
  int d = (a + b) /c;
  int e = (a + b) % c;
  Console.WriteLine(c);
  Console.WriteLine(d);
  Console.WriteLine(e);

  // range
  int max = int.MaxValue;
  int min = int.MinValue;
  Console.WriteLine($"The range of integers is {max} and {min}"); 

  // overflow
  int overflow = max + 3;
  Console.WriteLine($"An example of overflow is : {overflow}");
}

static void WorkingWithDouble()
{
  double a = 18;
  double b = 89;
  double c = 10;
  double d = b + c;
  double e = d / a;
  Console.WriteLine(d);
  Console.WriteLine(e);

  // range 
  double max = double.MaxValue;
  double min = double.MinValue;
  Console.WriteLine($"The range of double is {max} and {min}");

  double third = 1.0 / 3.0;
  Console.WriteLine(third);
}

// WorkingWithDouble();


static void WorkingWithDecimals()
{
  decimal a = 1.0M;
  decimal b = 3.0M;
  decimal c = a / b;
  Console.WriteLine(c);

  double PI = Math.PI;
  double radius = 2.50;
  double area = PI * radius * radius;
  Console.WriteLine(area);
}
//WorkingWithDecimals();

///////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////   Mark Price ////////////////////////////////////////////////////////

uint naturalNumber = 23;
int anotherNaturalNumber = -23;

int decimalNotation = 2_000_000;
int binaryNotation = 0b111_101_000_010_010_000_000;
int hexadecimalNotation = 0x1E8480;

WriteLine($"{decimalNotation} - {binaryNotation} - {hexadecimalNotation}");
WriteLine($"{hexadecimalNotation == decimalNotation}");
WriteLine($"{binaryNotation == hexadecimalNotation}");

// output the values in decimal
WriteLine($"{hexadecimalNotation:N0}");

// output the values in hexadecimal
// WriteLine($"{decimalNotation:X}");
// WriteLine($"{binaryNotation:X}");
// WriteLine($"{hexadecimalNotation:X}");

// WriteLine();

// WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
// WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
// WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

WriteLine();
static void CompareDoubleandDecimal()
{
  WriteLine("Using Double");
  double a = 0.1;
  double b = 0.2;
  if(a + b == 0.3)
  {
    WriteLine($"{a} + {b} is equal to {0.3}");
  }
  else
  {
    WriteLine($"{a} + {b} is not equal to {0.3}");
  }
}
CompareDoubleandDecimal();

WriteLine($"{sizeof(uint)}");

unsafe
{
WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}.");
WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
}