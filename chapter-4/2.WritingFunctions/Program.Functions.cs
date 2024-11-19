using System.Globalization;
using System.Security.Cryptography;
using System.Security.Principal;

partial class Program
{
  static void TimesTable(byte number, byte size = 12)
  {
    WriteLine($"This is the {number} times table with {size} rows");
    WriteLine();

    for(int row = 1; row <= size; row++)
    {
      WriteLine($"{number} x {row} = {row * number}");
    }
    WriteLine();
  }

  static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
  {
    decimal rate = twoLetterRegionCode switch 
    {
      "CH" => 0.08M, // Switzerland
      "DK" or "NO" => 0.25M, // Denmark, Norway
      "GB" or "FR" => 0.2M, // UK, France
      "HU" => 0.27M, // Hungary
      "OR" or "AK" or "MT" => 0.0M, // Oregon, Alaska, Montana
      "ND" or "WI" or "ME" or "VA" => 0.05M,
      "CA" => 0.0825M, // California
      _ => 0.06M // Most other states.
    };
    return amount * rate;
  }

  static void ConfigureConsole(string culture = "en-us" , bool useComputerCulture = false)
  {
    // To Enable unicode characters like symbol in the console
    OutputEncoding = System.Text.Encoding.UTF8;

    if(!useComputerCulture)
    {
      CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
    }
    WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
  }

  /// <summary>
  /// Pass a 32-bit unsigned integer and it will be converted into its ordinal equivalent
  /// </summary>
  /// <param name="number"> Number as a cardinal value e.g. 1, 2, 3, and soon.
  /// </param>
  /// <returns> Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on. </returns>

  static string CardinalToOrdinal(uint number)
  {
    uint lastTwoDigits = number % 100;

    switch (lastTwoDigits)
    {
      case 11:
      case 12:
      case 13:
        return $"{number:N0}th";
      default:
        uint lastDigit = number % 10;

        string suffix = lastDigit switch 
        {
          1 => "st",
          2 => "nd",
          3 => "rd",
          _ => "th"
        };
        return $"{number:N0}{suffix}";
    }
  }

  static int Factorial(int number)
  {
    if(number < 0)
    {
      throw new ArgumentOutOfRangeException(
        message: $"Defined on for non negevite integers input:{number}",
        paramName: nameof(number)
      );
    }
    else if(number == 0)
    {
      return 1;
    }
    checked
    {
      return number * Factorial(number - 1);
    }
  }

  static int FiboImperative(uint term)
  {
    if (term == 0)
    {
      throw new ArgumentOutOfRangeException();
    }
    else if (term == 1) return 0;
    else if (term == 2 | term == 3) return 1;
    return FiboImperative(term - 1) + FiboImperative(term - 2);
  }

  static int FiboFunctional(uint term) => term switch
  {
    0 => throw new ArgumentOutOfRangeException(),
    1 => 0,
    2 or 3 => 1,
    _ => FiboFunctional(term - 1) + FiboFunctional(term - 2)
  };
}