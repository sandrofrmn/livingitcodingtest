using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextProcessor;
using System;
using System.Collections.Generic;

namespace TextProcessorTests
{
    [TestClass]
    public class Tests : TestBase
    {
        [TestMethod]
        public void CalculateHighestWordCountTest()
        {
            // Correct sentence
            string text = "The hunter was shooting a deer while the fox was being attacked by the lion";
            int count = Interactor.CalculateHighestWordCount(text);
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void CalculateWordCountTest()
        {
            string text = "I I I hello hello maybe";
            string word = "hello";
            int count = Interactor.CalculateWordCount(text, word);
            // hello is 2 times in the sentence above, hence it should be equal to 2.
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void GetMostCountedWords()
        {
            string text = "A a b b b c c c bel bel";
            int top = 4;
            //List<IWordCount> wordCountObjects = Interactor.GetMostCountedWords(text, top);
            //List<IWordCount> test = new List<IWordCount>();
            //test.Add(new WordCount("h",1));
            //Assert.AreEqual((2, 5), wordCountObjects);
        }
    }
}
