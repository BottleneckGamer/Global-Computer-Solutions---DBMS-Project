using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalComputerSolutions.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace GlobalComputerSolutions
{
    public class ContextFactory : IDesignTimeDbContextFactory<GCSContext>
    {
        public GCSContext CreateDbContext(string[] args)
        {
            // Get environment
            string environment = Environment.GetEnvironmentVariable("APP_ENVIRONMENT");

            string assemblyName = "GlobalComputerSolutions";

            // Build config
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile($"settings.{environment}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<GCSContext>();
            var connectionString = config.GetConnectionString("GCS");
            optionsBuilder.UseSqlServer(connectionString, c =>
                c.MigrationsAssembly(assemblyName));
            return new GCSContext(optionsBuilder.Options);
        }
    }
}
