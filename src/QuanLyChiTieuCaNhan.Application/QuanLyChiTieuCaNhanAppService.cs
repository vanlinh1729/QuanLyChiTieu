using System;
using System.Collections.Generic;
using System.Text;
using QuanLyChiTieuCaNhan.Localization;
using Volo.Abp.Application.Services;

namespace QuanLyChiTieuCaNhan;

/* Inherit your application services from this class.
 */
public abstract class QuanLyChiTieuCaNhanAppService : ApplicationService
{
    protected QuanLyChiTieuCaNhanAppService()
    {
        LocalizationResource = typeof(QuanLyChiTieuCaNhanResource);
    }
}
