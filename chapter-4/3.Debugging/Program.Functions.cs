
partial class Program 
{
  static int Fibonacci(uint term) => term switch
  {
    0 => throw new ArgumentOutOfRangeException(),
    1 => 0,
    2 or 3 => 1,
    _ => Fibonacci(term -1) + Fibonacci(term - 2)
  };

  /// <summary>
  /// Function for calculating the factorial of a number
  /// </summary>
  /// <param name="number">
  /// The non-negative number for which we want to calculate the factorial for, 0,1,2...
  /// </param>
  /// <returns>
  /// returns the factorial of the number, 0! = 1, 5! = 120, etc.
  /// </returns>
  /// <exception cref="ArgumentOutOfRangeException">
  /// Factorial for a negative number is not defined hence an exception is thrown
  /// </exception>
  static int Factorial(int number)
  {
    if( number < 0)
    {
      throw new ArgumentOutOfRangeException();
    }
    else if (number == 0 | number == 1)
    {
      return 1;
    }
    checked
    {
      return number * Factorial(number - 1);
    }
  }
  
}
