using BankServer.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTests
{
    public static class ApplicationDbContextStub
    {
        public static IApplicationDbContext GetApplicationDbContextForTests()
        {
            var mock = new Mock<IApplicationDbContext>();

            // Stubs for entity list.
            mock.Setup(i => i.Transactions).Returns(GetQueryMockableSet(TestData.Transactions));

            return mock.Object;
        }

        private static DbSet<T> GetQueryMockableSet<T>(List<T> source) where T : class
        {
            var queryable = source.AsQueryable();
            var dbSet = new Mock<DbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(x => x.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(x => x.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(x => x.Expression).Returns(queryable.Expression);
            return dbSet.Object;
        }
    }
}
