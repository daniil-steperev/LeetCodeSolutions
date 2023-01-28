using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions.Solutions.SqrtX;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests._69__Sqrt_x_
{
  [TestClass]
  public class Solution69Tester : AbstractSolutionTester<Solution69>
  {
    [TestMethod]
    public void EasySqrtTest()
    {
      int correctSqrt = 2;
      int testValue = 4;

      int methodSqrt = solution.MySqrt(testValue);

      Assert.AreEqual(correctSqrt, methodSqrt);
    }

    [TestMethod]
    public void RoundedSqrtTest()
    {
      int correctSqrt = 2;
      int testValue = 8;

      int methodSqrt = solution.MySqrt(testValue);

      Assert.AreEqual(correctSqrt, methodSqrt);
    }
  }
}
