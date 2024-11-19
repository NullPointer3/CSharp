
//TimesTable(number: 9, size: 20);

ConfigureConsole(culture: "gh-GH");

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in tax.");

//RunCardinalToOrdinal();
static void RunCardinalToOrdinal()
{
  for(uint number = 1; number <= 1000; number++)
  {
    Write($"{CardinalToOrdinal(number)} ");
  }
  WriteLine();
}

//RunFactorial();
static void RunFactorial()
{
  for(int i = -2; i <= 20; i++)
  {
    try
    {
      WriteLine($"{i}! in decimal = {Factorial(i):N0}"); 
    }
    catch(OverflowException)
    {
      WriteLine($"{i}! is too big for a 32-bit integer");
    }
    catch(Exception ex)
    {
      WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
    }
  }
}

string horizontalLine = new('-', count: 80);
WriteLine(horizontalLine);

//RunFiboImperative();
static void RunFiboImperative()
{
  for(uint i = 1; i <= 30; i++)
  try
  {
    WriteLine($"The {CardinalToOrdinal(number: i)} term of the fibonacci sequence is {FiboImperative(term: i)}");
  }
  catch(Exception ex)
  {
    WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
  }
}

RunFiboFunctional();
static void RunFiboFunctional()
{
  for(uint i = 1; i <= 30; i++)
  {
    WriteLine($"The {CardinalToOrdinal(number: i)} term of the fibonacci sequence is {FiboFunctional(term: i)}");
  }
}