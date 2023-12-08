using Volo.Abp.Modularity;

namespace QuanLyChiTieuCaNhan;

[DependsOn(
    typeof(QuanLyChiTieuCaNhanApplicationModule),
    typeof(QuanLyChiTieuCaNhanDomainTestModule)
    )]
public class QuanLyChiTieuCaNhanApplicationTestModule : AbpModule
{

}
