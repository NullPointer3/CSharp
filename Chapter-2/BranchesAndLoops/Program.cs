//ExploreIf();

static void ExploreIf()
{
  int a = 10;
  int b = 4;
  int d = a + b;
  if(d > 12)
  {
    Console.WriteLine($"{d} is greater than 12");
  }
  else
  {
    Console.WriteLine($"{d} is less than 12");
  }
}

static void WorkingWithWhileLoops()
{
  int counter = 0;
  while(counter <= 12)
  {
    Console.WriteLine(counter);
    counter+=2;
  }

  int result = 1;
  int counter1 = 0;
  while(counter1 < 10)
  {
    result *= 2;
    counter1 += 1;
  }
  Console.WriteLine(result);
}

//WorkingWithWhileLoops();

//WorkingWithForLoops();
static void WorkingWithForLoops()
{
  for(int i = 0; i <= 12; i+=2)
  {
    Console.WriteLine(i);
  }

  // Nested Loops
  for(int row = 1; row < 11; row++)
  {
    for(char column = 'a'; column < 'k'; column++)
    {
      Console.WriteLine($"The cell is {row}, {column}");
    }
  }
  // Breaking out of a loop( using the break keywork)
  for(int current = 20; ; current++)
  {
    if(current % 7 == 0)
    {
      Console.WriteLine(current);
      break;
    }
  }
}

static int Exercise()
{
  int result = 0;
  for(int i = 1; i <= 20; i++){
    if(i % 3 == 0)
    {
      result+=i;
    }
  }
  return result;
}