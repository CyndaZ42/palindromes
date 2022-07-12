using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName;

namespace Palindromes.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    // Test methods go here
    [TestMethod]
    public void Method_Behavior_ReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("Behavior is behaving", ClassName.Method("Behavior"));
    }
  }
}