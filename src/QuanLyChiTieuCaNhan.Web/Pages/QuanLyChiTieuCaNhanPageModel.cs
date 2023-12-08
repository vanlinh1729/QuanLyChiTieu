using QuanLyChiTieuCaNhan.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace QuanLyChiTieuCaNhan.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class QuanLyChiTieuCaNhanPageModel : AbpPageModel
{
    protected QuanLyChiTieuCaNhanPageModel()
    {
        LocalizationResourceType = typeof(QuanLyChiTieuCaNhanResource);
    }
}
