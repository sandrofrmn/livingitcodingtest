using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankServer.Models;
using BankLibrary;
using BankServer.Interactors;
using BankServer;

namespace BankTests
{
    [TestClass]
    public class TestBase
    {
        protected readonly IApplicationDbContext applicationDbContext;
        public Interactor Interactor;

        public TestBase(IApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public TestBase()   { }

        [TestInitialize]
        public void Setup()
        {
            IApplicationDbContext applicationDbContext = ApplicationDbContextStub.GetApplicationDbContextForTests();
            DataAccessDB dataAccess = new DataAccessDB(applicationDbContext);
            Interactor = new Interactor(dataAccess);
        }

        // Writes test message to the console.
        protected void WriteTestMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
