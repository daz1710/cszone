using System;
using System.Collections.Generic;
using System.Linq;

public class CountPositivesSumNegatives
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        // Convert to list to use Linq
        var list = input?.ToList();
      
        // If empty, return an enpty array
        if(!ValidatePositives(list))
            return new int[]{};

        // Find all positives numbers
        var positivesCount = list.Where(where => IsPositive(where)).ToList().Count();

        // Get all the negatives
        var negatives = list.Where(where => !IsPositive(where)).ToList();

        // Sum all the numbers
        var sum = negatives.Take(negatives.Count()).Sum();

        return new int[] { positivesCount, sum };
    }
  
    private static bool IsPositive(int number) => number > 0 ? true : false;
  
    private static bool ValidatePositives(List<int> input)
    {
        if (input == null)
            return false;

        if (input.Count() == 0)
            return false;

        return true;
    } 
}