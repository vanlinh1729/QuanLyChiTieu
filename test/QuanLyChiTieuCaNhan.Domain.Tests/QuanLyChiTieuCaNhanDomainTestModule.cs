using QuanLyChiTieuCaNhan.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QuanLyChiTieuCaNhan;

[DependsOn(
    typeof(QuanLyChiTieuCaNhanEntityFrameworkCoreTestModule)
    )]
public class QuanLyChiTieuCaNhanDomainTestModule : AbpModule
{

}
