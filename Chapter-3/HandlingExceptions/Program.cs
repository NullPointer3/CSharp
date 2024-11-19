using static System.Console;
// Handling Exceptions
// Wrap error-prone statements in try blocks
// statements in the catch block will be executed only if an exception is thrown by the try block

WriteLine("Before Parsing");
Write("How old are you? ");

string? input = ReadLine();
try
{
  int age = int.Parse(input!);
  WriteLine($"You are {input} yrs old");
}
catch(Exception ex) // catching all exceptions
{
  WriteLine($"{ex.GetType()} {ex.Message}");
}
WriteLine("After Parsing");


// Catching specific Exceptions
// catch(FormatException)

// Catching with filers
Write("Enter an amount: ");
string amount = ReadLine()!;
if (string.IsNullOrEmpty(amount)) return;

try
{
decimal amountValue = decimal.Parse(amount);
WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains("$"))
{
WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
WriteLine("Amounts must only contain digits!");
}

