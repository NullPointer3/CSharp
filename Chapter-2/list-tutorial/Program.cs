// List<string> names = ["Nuhu", "Musah", "Ibrahim"];

// names.Add("Khaleel");
// names.Add("Aquinas");
// foreach(string name in names)
// {
//   Console.WriteLine(name);
// }

// // Count returns the length of a list
// Console.WriteLine($"The list has {names.Count} names in it");

// // Sort() sorts list in the normal order
// names.Sort();
// foreach(string name in names)
// {
//   Console.WriteLine(name);
// }

static void WorkingWithLists()
{
  List<int> fibo = [1,1];
  int previous = fibo[fibo.Count - 1];
  int previous2 = fibo[fibo.Count - 2];

  fibo.Add(previous + previous2);
  foreach(var item in fibo)
  {
    Console.WriteLine(item);
  }
}
//WorkingWithLists();

static void Fibonacci()
{
  List<int> Fibo = [1,1];
  
  for(int i = 2; i <= 20; i++)
  {
    int prev = Fibo[i-1];
    int prev2 = Fibo[i-2];
    int next = prev + prev2;
    Fibo.Add(next);
  }
  foreach(var item in Fibo)
  {
    Console.WriteLine(item);
  }
}
Fibonacci();




