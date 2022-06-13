using Microsoft.EntityFrameworkCore;

namespace BankServer.Models
{
    public partial class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            SetAdditionalConfiguration(builder);            
        }

        /// <summary>
        /// Sets additional configuration for the tables.
        /// </summary>
        /// <param name="builder"></param>
        private void SetAdditionalConfiguration(ModelBuilder builder)
        {
            SetAdditionalConfiguration_Transactions(builder);
            SeedDatabase_Transactions(builder);
        }

        static partial void SetAdditionalConfiguration_Transactions(ModelBuilder builder);
        static partial void SeedDatabase_Transactions(ModelBuilder builder);
    }
}
