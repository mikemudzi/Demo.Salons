using Microsoft.EntityFrameworkCore;
using Demo.Salons.Salons;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Demo.Salons.EntityFrameworkCore
{
    public static class SalonsDbContextModelCreatingExtensions
    {
        public static void ConfigureSalons(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Address>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "Addresses", SalonsConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.AddressLine1).HasMaxLength(100);
                b.Property(x => x.AddressLine2).HasMaxLength(100);
                b.Property(x => x.Surburb).HasMaxLength(100);
                b.Property(x => x.City).HasMaxLength(100);
                b.Property(x => x.PostalCode).HasMaxLength(10);
            });
            builder.Entity<Booking>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "Bookings", SalonsConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.BookingDateAndTime).IsRequired();
                b.Property(x => x.ClientId).IsRequired();
                b.Property(x => x.EmployeeId).IsRequired();
                b.HasIndex(x => x.BookingDateAndTime);
            });
            builder.Entity<BookingService>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "BookingServices", SalonsConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.BookingId).IsRequired();
                b.Property(x => x.ServiceId).IsRequired();
            });
            builder.Entity<Client>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "Clients", SalonsConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props               
                b.Property(x => x.FirstName).HasMaxLength(50);
                b.Property(x => x.LastName).HasMaxLength(50);
                b.Property(x => x.Code).HasMaxLength(20);
                b.Property(x => x.BusinessNumber).HasMaxLength(50);
            });
            builder.Entity<Country>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "Countries", SalonsConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.CountryName).HasMaxLength(100).IsRequired();
                b.Property(x => x.TwoLetterIsoCode).HasMaxLength(2);
                b.Property(x => x.ThreeLetterIsoCode).HasMaxLength(3);
            });
            builder.Entity<Employee>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "Employees", SalonsConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.FirstName).HasMaxLength(50);
                b.Property(x => x.LastName).HasMaxLength(50);
            });
            builder.Entity<LookupType>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "LookupTypes", SalonsConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.type).HasMaxLength(50).IsRequired();
            });
            builder.Entity<LookupValue>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "LookupValues", SalonsConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Description).HasMaxLength(100).IsRequired();
                b.Property(x => x.ValueCode).HasMaxLength(50);
                b.Property(x => x.ValueName).HasMaxLength(50);
            });
            builder.Entity<OrganisationUnit>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "OrganisationUnits", SalonsConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.OrganisationName).HasMaxLength(150).IsRequired();
                b.Property(x => x.ContactNumber).HasMaxLength(50);
                b.Property(x => x.MainContactEmailAddress).HasMaxLength(250);
                b.Property(x => x.MainContactName).HasMaxLength(150);
            });
            builder.Entity<Person>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "Persons", SalonsConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props               
                b.Property(x => x.FirstName).HasMaxLength(50);
                b.Property(x => x.LastName).HasMaxLength(50);
            });
            builder.Entity<Product>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "Products", SalonsConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props               
            });
            builder.Entity<Service>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "Services", SalonsConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.ServiceName).HasMaxLength(150).IsRequired();
                b.Property(x => x.ServiceCode).HasMaxLength(10);
            });
            builder.Entity<Supplier>(b =>
            {
                b.ToTable(SalonsConsts.DbTablePrefix + "Suppliers", SalonsConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props               
            });
        }
    }
}