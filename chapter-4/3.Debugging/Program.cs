
//RunFibonacci();
static void RunFibonacci()
{
  for (uint i = 1; i <= 30; i++)
  {
  try
  {
    WriteLine($"{i} fibonacci term is {Fibonacci(term: i)}");
  }
  catch(Exception ex)
  {
    WriteLine($"{ex.GetType()}: No fibonacci term defined for {i} term");
  }
  }
}

RunFactorial();
static void RunFactorial()
{
  for(int i = -5; i <= 30; i++)
  {
    try
    {
      WriteLine($"{i}! = {Factorial(number: i)}");
    }
    catch(OverflowException)
    {
      WriteLine($"{i}! is too big for a 32-bit integer");
    }
    catch(ArgumentOutOfRangeException)
    {
      WriteLine($"Not defined for {i}!");
    }
  }
}