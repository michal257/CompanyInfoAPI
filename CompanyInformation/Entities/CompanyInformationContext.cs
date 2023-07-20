using Microsoft.EntityFrameworkCore;

namespace CompanyInformation.Entities
{
    public class CompanyInformationContext : DbContext
    {
        public CompanyInformationContext(DbContextOptions<CompanyInformationContext> options) : base(options)
        {

        }
        
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
    }
}
