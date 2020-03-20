using System;
using System.Linq;
using System.Collections.Generic;

namespace Counter.Models
{
  public class Word
  {
    public string FullSent { get; set; }
    public string Count { get; set; }
    public static char[] _numbersArr = new Char[]
    {'1','2','3','4','5','6','7','8','9','0'};
    public static char[] _symbolsArr = new Char[]
    {'!', '@', '#', '$', '^', '&', '*', '(', ')','.','-','=','+',',','_'};


    public Word(string sent, string word)
    {
      FullSent = sent;
      Count = word;
    }


    public static string SymbolChecker(string word)
    {
      string chompNumbers = word.Trim(_numbersArr).ToLower();
      string chompAll = chompNumbers.Trim(_symbolsArr).ToLower();

      return chompAll;
    }

    public int HowManyWordsASent()
    {

      string[] headCounts = FullSent.Split();
      var iFound = from head in headCounts
                  where head.ToLower() == Count.ToLower()
                  select head;
      return iFound.Count();
    }

  }
}


