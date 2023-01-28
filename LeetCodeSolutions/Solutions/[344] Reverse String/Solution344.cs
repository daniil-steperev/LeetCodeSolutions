namespace LeetCodeSolutions.Solutions.ReverseString
{
  public class Solution344
  {
    public char[] ReverseString(char[] s)
    {
      int length = s.Length;
      for (int i = 0; i < length / 2; i++)
      {
        (s[i], s[length - i - 1]) = (s[length - i - 1], s[i]);
      }

      return s;
    }
  }
}
