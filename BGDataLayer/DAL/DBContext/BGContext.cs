using BGDataLayer.DAL.Entities;
using BGDataLayer.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BGDataLayer.DAL.DBContext
{
    public class BGContext : IdentityDbContext<User,Role,int>
    {
        public BGContext(DbContextOptions<BGContext> options)
            : base(options)
        {
        }

        #region DbSets

        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                 .ToTable("Users");

            modelBuilder.Entity<Role>()
                 .ToTable("Roles");

            modelBuilder.Entity<IdentityUserRole<int>>()
                 .ToTable("UserRoles");

            modelBuilder.Entity<IdentityUserClaim<int>>()
                 .ToTable("UserClaims");

            modelBuilder.Entity<IdentityUserLogin<int>>()
                .ToTable("UserLogins");

            modelBuilder.Entity<IdentityRoleClaim<int>>()
                .ToTable("RoleClaims");

            modelBuilder.Entity<IdentityUserToken<int>>()
                .ToTable("UsersTokens");

            modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1 ,Name = "Admin", NormalizedName = "ADMIN" },
            new Role { Id = 2 ,Name = "User", NormalizedName = "USER" });

        }
    }
}
