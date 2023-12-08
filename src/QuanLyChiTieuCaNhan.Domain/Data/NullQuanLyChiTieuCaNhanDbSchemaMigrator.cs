using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace QuanLyChiTieuCaNhan.Data;

/* This is used if database provider does't define
 * IQuanLyChiTieuCaNhanDbSchemaMigrator implementation.
 */
public class NullQuanLyChiTieuCaNhanDbSchemaMigrator : IQuanLyChiTieuCaNhanDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
