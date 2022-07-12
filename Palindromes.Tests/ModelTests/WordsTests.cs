using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
  [TestClass]
  public class WordsTests
  {
    [TestMethod]
    public void Backwards_ReverseAnArray_dooF()
    {
      string myWord = "Food";
      Assert.AreEqual("dooF", Words.Backwards(myWord));
    }

    [TestMethod]
    public void isPalindrome_CheckIfStringIsPalindrome_True()
    {
      string myWord = "racecar";
      Assert.AreEqual(true, Words.isPalindrome(myWord));
    }

    [TestMethod]
    public void isPalindrome_WillIgnoreCase_True()
    {
      string myWord = "RaCecAr";
      Assert.AreEqual(true, Words.isPalindrome(myWord));
    }

    [TestMethod]
    public void isPalindrome_ReturnIfNotPalindrome_False()
    {
      string myWord = "bear";
      Assert.AreEqual(false, Words.isPalindrome(myWord));
    }
  }
}