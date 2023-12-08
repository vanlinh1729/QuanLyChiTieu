using System;
using QuanLyChiTieuCaNhan.Categories.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLyChiTieuCaNhan.Categories;


public interface ICategoryAppService :
    ICrudAppService< 
        CategoryDto, 
        Guid, 
        CategoryGetListInput,
        CreateUpdateCategoryDto,
        CreateUpdateCategoryDto>
{

}