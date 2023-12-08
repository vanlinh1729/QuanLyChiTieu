using System.Threading.Tasks;

namespace QuanLyChiTieuCaNhan.Data;

public interface IQuanLyChiTieuCaNhanDbSchemaMigrator
{
    Task MigrateAsync();
}
