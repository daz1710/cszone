using System.Linq;
using System;
using System.Collections.Generic;

public class DigitalCypher
{
  public static int[] Encode(string str, int n)
  {
    var digitalCypher = GenerateList();
    var cryptKey = GenerateListNumber(n);

    var sequence = new List<int>();

    foreach(var letter in str)
        sequence.Add(digitalCypher.FirstOrDefault(first => first.Key == letter).Value);

    var cryptSequence = new List<int>();
    var index = 0;

    foreach(var number in sequence)
    {
        if (index >= cryptKey.Count)
            index = 0;

        cryptSequence.Add(number + cryptKey[index]);
        index++;
    }

    return cryptSequence.ToArray();
  }

  private static List<KeyValuePair<char, int>> GenerateList()
  {
    // declare list of chars
    string alpha = "abcdefghijklmnopqrstuvwxyz"; 

    var list = new List<KeyValuePair<char,int>>();
    var index = 1;

    foreach(var letter in alpha)
    {
        list.Add(new KeyValuePair<char, int>(letter, index));
        index++;
    }

    return list;
  }

  private static List<int> GenerateListNumber(int n)
  {
    var result = new List<int>();

    foreach(var number in n.ToString())
    {
        result.Add(Int32.Parse(number.ToString()));
    }

    return result;
  }
}