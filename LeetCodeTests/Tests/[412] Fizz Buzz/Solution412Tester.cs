using System.Collections.Generic;
using LeetCodeSolutions.Solutions.FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests._412__Fizz_Buzz
{
  [TestClass]
  public class Solution412Tester : AbstractSolutionTester<Solution412>
  {
    [TestMethod]
    public void SmallFuzzTest()
    {
      int testNumber = 3;
      List<string> correctAnswer = new List<string>(new[] { "1", "2", "Fizz" });

      List<string> methodAnswer = new List<string>(solution.FizzBuzz(testNumber));

      CollectionAssert.AreEqual(correctAnswer, methodAnswer);
    }

    [TestMethod]
    public void MediumFuzzTest()
    {
      int testNumber = 5;
      List<string> correctAnswer = new List<string>(new[] { "1", "2", "Fizz", "4", "Buzz" });

      List<string> methodAnswer = new List<string>(solution.FizzBuzz(testNumber));

      CollectionAssert.AreEqual(correctAnswer, methodAnswer);
    }

    [TestMethod]
    public void BigFuzzTest()
    {
      int testNumber = 15;
      List<string> correctAnswer = new List<string>(new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" });

      List<string> methodAnswer = new List<string>(solution.FizzBuzz(testNumber));

      CollectionAssert.AreEqual(correctAnswer, methodAnswer);
    }
  }
}
