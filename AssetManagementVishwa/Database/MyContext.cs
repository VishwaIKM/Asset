using AssetManagementVishwa.Model;
using System.Data.Entity;

namespace AssetManagementVishwa.Database
{
    internal class MyContext : DbContext
    {
        internal MyContext() : base("MyDB")
        {
        }
        internal virtual DbSet<LoginModel> UserManagement { get; set; }
    }
}
