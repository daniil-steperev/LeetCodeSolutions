namespace LeetCodeSolutions.LengthOfTheLastWord
{
  public class Solution58
  {
    public int LengthOfLastWord(string s)
    {
      int wordLength = 0;
      int i = s.Length - 1;
      while (s[i] == ' ')
      {
        i--;
      }

      for (; i >= 0; i--)
      {
        if (s[i] == ' ')
        {
          return wordLength;
        }

        wordLength++;
      }

      return wordLength;
    }
  }
}
