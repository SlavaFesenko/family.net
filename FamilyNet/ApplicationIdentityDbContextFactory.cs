using EntityFramework;
using EntityFramework.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyNet
{
    public class ApplicationIdentityDbContextFactory : IDesignTimeDbContextFactory<ApplicationIdentityDbContext>
    {
        public ApplicationIdentityDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var dbContextBuilder = new DbContextOptionsBuilder<ApplicationIdentityDbContext>();

            var connectionString = configuration["Data:FamilyNetIdentity:ConnectionString"];

            dbContextBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("FamilyNet"));

            return new ApplicationIdentityDbContext(dbContextBuilder.Options);
        }

    }
}
