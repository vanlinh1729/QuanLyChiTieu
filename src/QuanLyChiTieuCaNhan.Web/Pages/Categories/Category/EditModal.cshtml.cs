using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyChiTieuCaNhan.Categories;
using QuanLyChiTieuCaNhan.Categories.Dtos;
using QuanLyChiTieuCaNhan.Web.Pages.Categories.Category.ViewModels;

namespace QuanLyChiTieuCaNhan.Web.Pages.Categories.Category;

public class EditModalModel : QuanLyChiTieuCaNhanPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditCategoryViewModel ViewModel { get; set; }

    private readonly ICategoryAppService _service;

    public EditModalModel(ICategoryAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<CategoryDto, CreateEditCategoryViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCategoryViewModel, CreateUpdateCategoryDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}