namespace ST10468422_CLDV_Part1.Data { 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ST10468422_CLDV_Part1.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=EventEaseDB;Trusted_Connection=True;"
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
}
