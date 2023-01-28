using System.Collections.Generic;

namespace LeetCodeSolutions.Solutions.ValidAnagram
{
  public class Solution242
  {
    public bool IsAnagram(string s, string t)
    {
      Dictionary<char, int> charDict = new Dictionary<char, int>();
      char[] sChars = s.ToCharArray();
      char[] tChars = t.ToCharArray();

      if (sChars.Length != tChars.Length)
      {
        return false;
      }

      var totalChars = sChars.Length;
      foreach (var letter in sChars)
      {
        if (!charDict.ContainsKey(letter))
        {
          charDict.Add(letter, 1);
        }
        else
        {
          charDict[letter]++;
        }
      }

      foreach (var letter in tChars)
      {
        if (!charDict.ContainsKey(letter))
        {
          return false;
        }

        var number = charDict[letter];
        if (number == 1)
        {
          charDict.Remove(letter);
        }
        else
        {
          charDict[letter] = number - 1;
        }
      }

      return charDict.Count == 0;
    }
  }
}
