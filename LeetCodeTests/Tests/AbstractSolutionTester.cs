using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests
{
  [TestClass]
  public abstract class AbstractSolutionTester<Solution> where Solution : new()
  {
    protected Solution solution;

    [TestInitialize]
    public void SetUp() => solution = new Solution();
  }
}
