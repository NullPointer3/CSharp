using static System.Console;

partial class Program 
{
  static void WhatsMyNamespace()
  {
    WriteLine("Namspace of the class Program: {0}", 
    typeof(Program).Namespace ?? "null");
  }
}