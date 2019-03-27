
using Microsoft.EntityFrameworkCore;
using MVC_EF_Start.Models;

namespace MVC_EF_Start.DataAccess
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Equity> Equities { get; set; }
    }

    /***
     * 
    string connectionString = "Server=tcp:colyertest.database.windows.net,1433;Initial Catalog = FinanceSite; Persist Security Info=False;User ID = colyer.sigety@gmail.com; Password=Tr0ffles15; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";

    using (SqlConnection connection = new SqlConnection(connectionString))  
    {  
        connection.Open();  
        // Do work here.  
    }
    ***/
}

