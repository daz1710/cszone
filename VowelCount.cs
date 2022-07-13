using System;
using System.Linq;
using System.Collections.Generic;

public static class VowelCount
{
  public static int GetVowelCount(string str)
  {
      var result = 0;
      var vowels = new List<string>() { "a", "e", "i", "o", "u" };

      foreach(var word in str)
      {
          if (vowels.Any(any => any.Contains(word)))
              result++;
      }

      return result;
  }
}