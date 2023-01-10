namespace LeetCodeSolutions.PlusOne
{
  public class Solution66
  {
    private const int OverflowingNumber = 10;

    public int[] PlusOne(int[] digits)
    {
      int digitsLength = digits.Length;
      for (int i = digitsLength - 1; i >= 0; i--)
      {
        digits[i]++;

        if (digits[i] != OverflowingNumber)
        {
          return digits;
        }

        digits[i] = 0;
      }

      if (digits[0] != 0)
      {
        return digits;
      }

      digits[0] = 0;
      int[] digitsWithAppendedElement = new int[digitsLength + 1];
      digitsWithAppendedElement[0] = 1;
      digits.CopyTo(digitsWithAppendedElement, 1);

      return digitsWithAppendedElement;
    }
  }
}
