using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Demo.Salons.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class SalonsMigrationsDbContextFactory : IDesignTimeDbContextFactory<SalonsMigrationsDbContext>
    {
        public SalonsMigrationsDbContext CreateDbContext(string[] args)
        {
            SalonsEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SalonsMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new SalonsMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Demo.Salons.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
