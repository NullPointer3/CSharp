using static System.Console;

// Unary Operator
//UnaryOperators();
static void UnaryOperators()
{
  int x = 5;
  x++;
  ++x;
  WriteLine(x);

  Type TypeofIntegers = typeof(int);
  string nameOfvariable = nameof(x);
  int sizeOfIntegers = sizeof(int);

  WriteLine("{0}, {1}, {2}", TypeofIntegers, nameOfvariable, sizeOfIntegers);
}

//NullCoalescing();
static void NullCoalescing()
{
  // The ? operator tells the compliler that authorName could be null
  string? authorName = ReadLine();

//  The maxLength variable will be the length of authorName if it is
// not null, or 30 if authorName is null
  int maxlength = authorName?.Length ?? 30;
  WriteLine(maxlength);
}

bool p = true;
bool q = false;

// Exploring Conditional Operators
static bool DoStuff()
{
  return true;
}


//WriteLine($"P & DoStuff() = {p && DoStuff()}");
//WriteLine($"q & DoStuff() = {q && DoStuff()}");

// Exploring bitwise & binary shift operators
int x = 10;
int y = 6;

WriteLine($"Expression | Decimal | Binary");
WriteLine($"-------------------------------");
WriteLine($"x | {x,7} | {x:B8}");
WriteLine($"y | {y,7} | {y:B8}");
WriteLine($"x & y | {x & y,7} | {x & y:B8}");
WriteLine($"x | y | {x | y,7} | {x | y:B8}");
WriteLine($"x ^ y | {x ^ y,7} | {x ^ y:B8}");
