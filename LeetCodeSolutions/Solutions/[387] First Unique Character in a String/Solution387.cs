using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions.Solutions.FirstUniqueCharacterInString
{
  public class Solution387
  {
    // Time complexity: O(N).
    // Space complexity: O(N).
    public int FirstUniqChar(string s)
    {
      char[] letters = s.ToCharArray();
      char[] lettersCount = new char[26];
      Dictionary<char, int> firstLettersDict = new Dictionary<char, int>();
      for (int i = 0; i < letters.Length; i++)
      {
        var letter = letters[i];
        lettersCount[letter - 'a']++;
        if (lettersCount[letter - 'a'] > 1)
        {
          firstLettersDict.Remove(letter);
        }
        else
        {
          firstLettersDict.Add(letter, i);
        }
      }

      return firstLettersDict.Count != 0 ? firstLettersDict.Values.Min() : -1;
    }
  }
}
