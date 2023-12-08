using QuanLyChiTieuCaNhan.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QuanLyChiTieuCaNhan.Permissions;

public class QuanLyChiTieuCaNhanPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(QuanLyChiTieuCaNhanPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(QuanLyChiTieuCaNhanPermissions.MyPermission1, L("Permission:MyPermission1"));

        var walletPermission = myGroup.AddPermission(QuanLyChiTieuCaNhanPermissions.Wallet.Default, L("Permission:Wallet"));
        walletPermission.AddChild(QuanLyChiTieuCaNhanPermissions.Wallet.Create, L("Permission:Create"));
        walletPermission.AddChild(QuanLyChiTieuCaNhanPermissions.Wallet.Update, L("Permission:Update"));
        walletPermission.AddChild(QuanLyChiTieuCaNhanPermissions.Wallet.Delete, L("Permission:Delete"));

        var categoryPermission = myGroup.AddPermission(QuanLyChiTieuCaNhanPermissions.Category.Default, L("Permission:Category"));
        categoryPermission.AddChild(QuanLyChiTieuCaNhanPermissions.Category.Create, L("Permission:Create"));
        categoryPermission.AddChild(QuanLyChiTieuCaNhanPermissions.Category.Update, L("Permission:Update"));
        categoryPermission.AddChild(QuanLyChiTieuCaNhanPermissions.Category.Delete, L("Permission:Delete"));

        var transactionPermission = myGroup.AddPermission(QuanLyChiTieuCaNhanPermissions.Transaction.Default, L("Permission:Transaction"));
        transactionPermission.AddChild(QuanLyChiTieuCaNhanPermissions.Transaction.Create, L("Permission:Create"));
        transactionPermission.AddChild(QuanLyChiTieuCaNhanPermissions.Transaction.Update, L("Permission:Update"));
        transactionPermission.AddChild(QuanLyChiTieuCaNhanPermissions.Transaction.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QuanLyChiTieuCaNhanResource>(name);
    }
}
