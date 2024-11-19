using static System.Console;

// 1. Dividing int by zero throws an exception
// 2. Dividing double by zero gives infinity
// 3. Overflowing an int returns min value or close to the min value
/******
  4. Posfix x++, increment is done after assigning the variable,
    prefix ++x, you assign the variable, then increment it
******/
/*****
  5. break: breaks/ends the loop
     continue: the loop continues to run
     return: returns to the caller of the loop  
/*****
  6. inittializer
     condition
     iterator 

  7. for(; ;): Complies as an infite loop
*****/

int x = 3 << 2;
int y = 10 >> 1;
WriteLine($"{x}, {y}");

// FIzzBuzz
for(int i = 1; i <= 100; i++)
{
  if(i % 3 == 0 && (i % 5 != 0)) Write("Fizz, ");
  else if(i % 5 == 0 && (i % 3 != 0)) Write("Buzz, ");
  else if((i % 3 == 0) && (i % 5 == 0)) Write("FizzBuzz, ");
  else Write($"{i}, ");
}

// Practice Exception handling
Write("Enter a number between 0 and 255 ");
string input1 = ReadLine()!;
Write("Enter another number between 0 and 255 ");
string input2 = ReadLine()!;

try 
{
  int number1 = int.Parse(input1);
  int number2 = int.Parse(input2);
  WriteLine($"{number1} divided by {number2} is {number1 / number2}");
}
catch(Exception ex)
{ 
  WriteLine($"{ex.GetType()}: {ex.Message}");
}