using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCounter.Test
{
    [TestClass]
    public class WordCounterTest
    {
       

        [TestMethod]
        public void TestNull()
        {
            var results = WordCounter.Count(null);
            Assert.IsNull(results);
        }

        [TestMethod]
        public void TestEmpty()
        {
            var results = WordCounter.Count(string.Empty);
            Assert.AreEqual(results.Count, 0);
        }

        [TestMethod]
        public void TestWordLessThan4Letters()
        {
            var results = WordCounter.Count(string.Empty);
            Assert.AreEqual(results.Count, 0);
        }

        [TestMethod]
        public void TestWordWith4Letters()
        {
            var results = WordCounter.Count("word");
            Assert.AreEqual(results.Count, 1);
            Assert.AreEqual(results["word"], 1);
        }

        [TestMethod]
        public void Test2Words()
        {
            var results = WordCounter.Count("word test");
            Assert.AreEqual(results.Count, 2);
            Assert.AreEqual(results["word"], 1);
            Assert.AreEqual(results["test"], 1);
        }

        [TestMethod]
        public void Test3Words()
        {
            var results = WordCounter.Count("I have an good wife.");
            Assert.AreEqual(results.Count, 3);
            Assert.AreEqual(results["have"], 1);
            Assert.AreEqual(results["good"], 1);
            Assert.AreEqual(results["wife"], 1);
        }

        [TestMethod]
        public void TestCaseSensitive()
        {
            var results = WordCounter.Count("word Word WORD");
            Assert.AreEqual(results.Count, 1);
            Assert.AreEqual(results["word"], 3);
        }

        [TestMethod]
        public void TestNumberAtHeader()
        {
            var results = WordCounter.Count("1word 2Word WORD3");
            Assert.AreEqual(results.Count, 1);
            Assert.AreEqual(results["word"], 3);
        }

        [TestMethod]
        public void TestWordsWithNumbersTail()
        {
            var results = WordCounter.Count("I have iphone4 iphone6 iphone5 iphone6s iphone5s");
            Assert.AreEqual(results.Count, 4);
            Assert.AreEqual(results["have"], 1);
            Assert.AreEqual(results["iphone"], 3);
            Assert.AreEqual(results["iphone6s"], 1);
            Assert.AreEqual(results["iphone5s"], 1);
        }

        [TestMethod]
        public void TestLongSentence()
        {
            var results = WordCounter.Count("Word is case insensitive, i.e. \"file\", \"FILE\" and \"File\" are considered the same word.");
            Assert.AreEqual(results.Count, 6);
            Assert.AreEqual(results["word"], 2);
            Assert.AreEqual(results["case"], 1);
            Assert.AreEqual(results["insensitive"], 1);
            Assert.AreEqual(results["file"], 3);
            Assert.AreEqual(results["considered"], 1);
            Assert.AreEqual(results["same"], 1);
        }
    }
}
