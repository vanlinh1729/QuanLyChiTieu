using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace QuanLyChiTieuCaNhan.Pages;

public class Index_Tests : QuanLyChiTieuCaNhanWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
