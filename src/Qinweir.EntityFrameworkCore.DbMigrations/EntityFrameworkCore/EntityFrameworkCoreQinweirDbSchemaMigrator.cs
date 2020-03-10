﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Qinweir.Data;
using Volo.Abp.DependencyInjection;

namespace Qinweir.EntityFrameworkCore
{
    public class EntityFrameworkCoreQinweirDbSchemaMigrator
        : IQinweirDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreQinweirDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the QinweirMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<QinweirMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}