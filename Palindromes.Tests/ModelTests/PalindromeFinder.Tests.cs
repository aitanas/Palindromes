using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeFinderTests
  {
    [TestMethod]
    public void CreateArray_StoreInputArray()
    {
      PalindromeFinder testPalindrome = new PalindromeFinder();
      string[] inputArray = {"m", "o", "m"};
      string[] reverseArray = Array.Reverse(inputArray);
      Assert.AreEqual(true, testPalindrome.CreateArray(inputArray, reverseArray));
    }
    //Array

    // string[] inputArray = {input};
    // string[n] {"input"} --> 
  }
}
// [TestMethod]
// public void TestStartsWithUpper()
// {
//     // Tests that we expect to return true.
//     string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
//     foreach (var word in words)
//     {
//         bool result = word.StartsWithUpper();
//         Assert.IsTrue(result,
//                 string.Format("Expected for '{0}': true; Actual: {1}",
//                               word, result));
//     }
// }