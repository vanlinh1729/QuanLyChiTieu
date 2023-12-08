using QuanLyChiTieuCaNhan.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QuanLyChiTieuCaNhan.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class QuanLyChiTieuCaNhanController : AbpControllerBase
{
    protected QuanLyChiTieuCaNhanController()
    {
        LocalizationResource = typeof(QuanLyChiTieuCaNhanResource);
    }
}
