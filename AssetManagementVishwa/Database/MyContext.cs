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

        public virtual DbSet<AssetMainModel> AssetMain { get; set; }

        public virtual DbSet<AssetTempModel> AssetTemp { get; set; }

        public virtual DbSet<KeyGeneratorModel> KeyGenerator { get; set; }
    }
}
