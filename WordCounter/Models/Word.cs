using System;
using System.Collections.Generic;

namespace Counter.Models
{
  public class Word
  {
    public static char[] _numbersArr = new Char[]
    {'1','2','3','4','5','6','7','8','9','0'};
    public static char[] _symbolsArr = new Char[]
    {'!', '@', '#', '$', '^', '&', '*', '(', ')','.','-','=','+',',','_'};

    public static string SymbolChecker(string word)
    {
      string withNumbers = word.Trim(_numbersArr).ToLower();
      string withSymbols = word.Trim(_symbolsArr).ToLower();
      string combinedChecks = withNumbers + withSymbols;
      return combinedChecks;
    }
  }
}
