using AssetManagementVishwa.Model;
using System.Data.Entity;

namespace AssetManagementVishwa.Database
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyDB")
        {
        }
        public virtual DbSet<LoginModel> UserManagement { get; set; }
    }
}
