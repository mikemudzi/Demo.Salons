using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Demo.Salons.Data;
using Volo.Abp.DependencyInjection;

namespace Demo.Salons.EntityFrameworkCore
{
    public class EntityFrameworkCoreSalonsDbSchemaMigrator
        : ISalonsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreSalonsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the SalonsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<SalonsMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}