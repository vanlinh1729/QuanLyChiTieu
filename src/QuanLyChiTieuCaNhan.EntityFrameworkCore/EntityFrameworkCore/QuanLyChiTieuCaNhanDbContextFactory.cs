using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QuanLyChiTieuCaNhan.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class QuanLyChiTieuCaNhanDbContextFactory : IDesignTimeDbContextFactory<QuanLyChiTieuCaNhanDbContext>
{
    public QuanLyChiTieuCaNhanDbContext CreateDbContext(string[] args)
    {
        QuanLyChiTieuCaNhanEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<QuanLyChiTieuCaNhanDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new QuanLyChiTieuCaNhanDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../QuanLyChiTieuCaNhan.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
