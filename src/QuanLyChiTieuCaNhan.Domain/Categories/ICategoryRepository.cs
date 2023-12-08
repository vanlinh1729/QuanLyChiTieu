using System;
using Volo.Abp.Domain.Repositories;

namespace QuanLyChiTieuCaNhan.Categories;

public interface ICategoryRepository : IRepository<Category, Guid>
{
}
