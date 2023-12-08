using QuanLyChiTieuCaNhan.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace QuanLyChiTieuCaNhan.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(QuanLyChiTieuCaNhanEntityFrameworkCoreModule),
    typeof(QuanLyChiTieuCaNhanApplicationContractsModule)
    )]
public class QuanLyChiTieuCaNhanDbMigratorModule : AbpModule
{
}
