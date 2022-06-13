using BankServer.Models;

namespace BankServer
{
    public class DataAccessDB
    {
        protected readonly IApplicationDbContext applicationDbContext;

        public DataAccessDB(IApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
    }
}
