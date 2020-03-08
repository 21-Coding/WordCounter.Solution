using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;


namespace Counter.Test
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void SymbolChecker_ReturnsSymbolChecker_ReturnObject()
    {
      string exWord = "Hello";
      string weWant = "hello";
      Assert.AreEqual(weWant, Word.SymbolChecker(exWord));

    }
  }
}
