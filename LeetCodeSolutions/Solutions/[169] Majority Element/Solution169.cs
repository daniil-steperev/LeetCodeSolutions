using System.Collections.Generic;

namespace LeetCodeSolutions.Solutions.MajorityElement
{
  public class Solution169
  {
    public int MajorityElement(int[] nums)
    {
      IDictionary<int, int> elementsHashMap = new Dictionary<int, int>();
      foreach (int num in nums)
      {
        if (elementsHashMap.ContainsKey(num))
        {
          elementsHashMap[num]++;
        }
        else
        {

          elementsHashMap.Add(num, 1);
        }
      }

      foreach (KeyValuePair<int, int> countedElement in elementsHashMap)
      {
        int correctQuantity = (nums.Length + 1) / 2;
        if (countedElement.Value >= correctQuantity)
        {
          return countedElement.Key;
        }
      }

      return -1;
    }
  }
}
