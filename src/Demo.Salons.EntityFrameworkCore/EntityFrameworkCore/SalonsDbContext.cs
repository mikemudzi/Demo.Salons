using Microsoft.EntityFrameworkCore;
using Demo.Salons.Users;
using Demo.Salons.Salons;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Demo.Salons.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See SalonsMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class SalonsDbContext : AbpDbContext<SalonsDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingService> BookingServices { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LookupType> LookupTypes { get; set; }
        public DbSet<LookupValue> LookupValues { get; set; }
        public DbSet<OrganisationUnit> OrganisationUnits { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside SalonsDbContextModelCreatingExtensions.ConfigureSalons
         */

        public SalonsDbContext(DbContextOptions<SalonsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the SalonsEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureSalons method */

            builder.ConfigureSalons();
        }
    }
}
