using System.Threading.Tasks;

namespace QuanLyChiTieuCaNhan.Web.Pages;

public class IndexModel : QuanLyChiTieuCaNhanPageModel
{
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}
