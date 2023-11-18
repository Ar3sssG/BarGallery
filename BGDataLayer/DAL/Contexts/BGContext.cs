using BGDataLayer.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BGDataLayer.DAL.Contexts
{
    public class BGContext : IdentityDbContext<User, Role, int>
    {
        private string _connectionString;
        public BGContext(DbContextOptions<BGContext> options)
            : base(options)
        {
        }

        public BGContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region DBSets

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UsersTokens");
        }
    }
}
