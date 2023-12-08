using System.Threading.Tasks;
using QuanLyChiTieuCaNhan.Permissions;
using QuanLyChiTieuCaNhan.Localization;
using QuanLyChiTieuCaNhan.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace QuanLyChiTieuCaNhan.Web.Menus;

public class QuanLyChiTieuCaNhanMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<QuanLyChiTieuCaNhanResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                QuanLyChiTieuCaNhanMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
        /*if (await context.IsGrantedAsync(QuanLyChiTieuCaNhanPermissions.Wallet.Default))
        {
            context.Menu.AddItem(
                new ApplicationMenuItem(QuanLyChiTieuCaNhanMenus.Wallet, l["Menu:Wallet"], "/Wallets/Wallet")
            );
        }
        if (await context.IsGrantedAsync(QuanLyChiTieuCaNhanPermissions.Category.Default))
        {
            context.Menu.AddItem(
                new ApplicationMenuItem(QuanLyChiTieuCaNhanMenus.Category, l["Menu:Category"], "/Categories/Category")
            );
        }
        if (await context.IsGrantedAsync(QuanLyChiTieuCaNhanPermissions.Transaction.Default))
        {
            context.Menu.AddItem(
                new ApplicationMenuItem(QuanLyChiTieuCaNhanMenus.Transaction, l["Menu:Transaction"], "/Transactions/Transaction")
            );
        }*/
    }
}
