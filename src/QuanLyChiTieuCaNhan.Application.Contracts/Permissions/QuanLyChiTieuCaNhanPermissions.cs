namespace QuanLyChiTieuCaNhan.Permissions;

public static class QuanLyChiTieuCaNhanPermissions
{
    public const string GroupName = "QuanLyChiTieuCaNhan";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public class Wallet
    {
        public const string Default = GroupName + ".Wallet";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
    public class Category
    {
        public const string Default = GroupName + ".Category";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
    public class Transaction
    {
        public const string Default = GroupName + ".Transaction";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
