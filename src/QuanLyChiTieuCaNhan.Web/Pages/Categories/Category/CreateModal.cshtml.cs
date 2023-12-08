using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyChiTieuCaNhan.Categories;
using QuanLyChiTieuCaNhan.Categories.Dtos;
using QuanLyChiTieuCaNhan.Web.Pages.Categories.Category.ViewModels;

namespace QuanLyChiTieuCaNhan.Web.Pages.Categories.Category;

public class CreateModalModel : QuanLyChiTieuCaNhanPageModel
{
    [BindProperty]
    public CreateEditCategoryViewModel ViewModel { get; set; }

    private readonly ICategoryAppService _service;

    public CreateModalModel(ICategoryAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCategoryViewModel, CreateUpdateCategoryDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}