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
      string exWord = "Hello@@";
      string weWant = "hello";
      Assert.AreEqual(weWant, Word.SymbolChecker(exWord));

    }
    [TestMethod]
    public void Word_CreatesNewInstancesOfWordWithChosenWord_eye()
    {
      Word aWordCan = new Word("My eye is on the sparrow.", "eye");
      Assert.AreEqual(aWordCan.Count, "eye");
    }
    [TestMethod]
    public void HowManyWordsASent_ReturnsHowManyWordsASent_()
    {
      Word aWordCan = new Word("My eye is on the sparrow.", "eye");
      Assert.AreEqual(1, aWordCan.HowManyWordsASent());

    }
  }
}
