using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word.Models;
using System;

namespace Word.Test
{
  [TestClass]
  public class MakeFileTests
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
