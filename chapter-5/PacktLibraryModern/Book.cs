using System.Diagnostics.CodeAnalysis; // To use [SetsRequiredMembers].

namespace Packt.Shared;

public class Book 
{
  // Needs .Net 7 or later and C# 11 or later
  public required string? Isbn;
  public required string? Title;

  // Works with any version of .NET
  public string? Author;
  public int PageCount;

  // Constructor for use with object initializer syntax
  public Book() {}

  // Constructor with params to set the required fields
  [SetsRequiredMembers]
  public Book (string? isbn, string? title)
  {
    Isbn = isbn;
    Title = title;
  } 
}