using static System.Console;

string[] names; // declared an array of strings
names = new string[4]; // allocate memory for 4 strings in an array

names[0] = "Kate";
names[1] = "jack";
names[2] = "Radri";
names[3] = "KDB";

// alternative syntax for creating and initializing an array
string[] names2 = {"Kate", "Jack", "Rodri", "KDB"};

for(int i = 0; i < names2.Length; i++)
{
  WriteLine($"{names2[i]} is at position {i}");
}

// Multi-Dimensional Array
string[,] grid1 = {
  {"Alpha", "Beta", "Gamma", "Delta"},
  {"Anne", "Ben", "Charlie", "Doug"},
  {"Aardvark", "Bear", "Cat", "Dog"}
};

WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

// Looping through a multi-dimensional array
for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
  for (int col = 0; col <= grid1.GetUpperBound(1); col++)
  {
    WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
  }
}

// Alternatively
string[,] grid2 = new string[3,4]; // Allocate memory
grid2[0,0] = "Alpha";
grid2[0,1] = "Beta";
//and so on

// Jagged Arrays
string[][] jagged = {
  new[] {"Alpah", "Beta", "Gamma"},
  new[] {"Anne", "Ben", "Charlie", "Doug"},
  new[] {"Aardvark", "Bear"}
};

WriteLine("Upper bound of the array of arrays is: {0}", jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
  WriteLine("Upper bound of array {0} is: {1}",
  arg0: array,
  arg1: jagged[array].GetUpperBound(0));
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
  for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
  {
    WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
  }
}

int[] sequentialNumbers = {1,2,3,4,5,6,7};
int[] oneTwoNumbers = {1,2};
int[] oneTwoTenNumbers = {1,2,10};
int[] oneTwoThreeTenNumbers = {1,2,3,10};
int[] primeNumbers = {2,3,5,7,11,13,17,19,23,29};
int[] fibonacciNumbers = {0,1,1,2,3,5,8,13,21,34,55,89};
int[] emptyNumbers = {}; // OR Array.Empty<int>()
int[] threeNumbers = {3,4,7};
int[] sixNumbers = {2,4,5,7,8,9};

string horizantalLine = new('-', count: 80);
WriteLine(horizantalLine);
WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch 
{
  [] => "Empty array",
  [1, 2, _ ,10] => "Contains 1,2 any single number, 10",
  [1, 2, .. ,10] => "Contains 1,2, any range including empty, 10",
  [1, 2] => "Contains 1 then 2",
  [int item1, int item2, int item3] => $"Contains {item1}, {item2}, {item3}",
  [0, _] => "Starts with 0 then any other number",
  [0, ..] => "Starts with 0, then any range of numbers",
  [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
  [..] => "Any items in any order"
};

/**
  Good Practice: If you do not need to dynamically add and remove items, then you should
  use an array instead of a collection like List<T> because arrays are more efficient in
  memory use and the items are stored contiguously, which can improve performance.
**/

