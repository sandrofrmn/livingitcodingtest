using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TextProcessor;

namespace TextProcessorTests
{
    [TestClass]
    public class TestBase
    {
        protected WordCountAnalyser Interactor;

        [TestInitialize]
        public void Setup()
        {
            Interactor = new WordCountAnalyser();
        }

        // Writes test message to the console.
        protected void WriteTestMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
