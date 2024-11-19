static double factorial(double n) 
{
  if(n == 0 || n == 1)
  {
    return 1;
  }
  return n * factorial(n-1);
}

//WriteLine(factorial(5));

static double Fibonacci(double n)
{
  if(n == 1 || n == 2)
  {
    return 1;
  }
  return Fibonacci(n -1) + Fibonacci(n - 2);
}
//WriteLine(Fibonacci(5));

WriteLine($"Computer named {Env.MachineName} says \"No\"");


WriteLine();