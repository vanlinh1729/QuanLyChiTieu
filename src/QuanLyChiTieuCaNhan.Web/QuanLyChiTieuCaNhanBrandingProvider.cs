using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace QuanLyChiTieuCaNhan.Web;

[Dependency(ReplaceServices = true)]
public class QuanLyChiTieuCaNhanBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "QuanLyChiTieuCaNhan";
}
