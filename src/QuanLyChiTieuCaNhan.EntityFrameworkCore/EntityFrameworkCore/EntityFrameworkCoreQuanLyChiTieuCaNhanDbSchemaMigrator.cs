using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuanLyChiTieuCaNhan.Data;
using Volo.Abp.DependencyInjection;

namespace QuanLyChiTieuCaNhan.EntityFrameworkCore;

public class EntityFrameworkCoreQuanLyChiTieuCaNhanDbSchemaMigrator
    : IQuanLyChiTieuCaNhanDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreQuanLyChiTieuCaNhanDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the QuanLyChiTieuCaNhanDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<QuanLyChiTieuCaNhanDbContext>()
            .Database
            .MigrateAsync();
    }
}
