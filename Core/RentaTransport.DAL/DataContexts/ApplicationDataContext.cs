using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentaTransport.DAL.DAOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaTransport.DAL.DataContexts
{
   public class ApplicationDataContext : IdentityDbContext<UserDao, RoleDao, Guid, UserClaimDao, UserRoleDao, UserLoginDao, RoleClaimDao, UserTokenDao>
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
            builder.Entity<UserDao>(b =>
            {
                b.HasKey(u => u.Id);
                b.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
                b.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");
                b.ToTable(name: "Users");
                b.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();
                b.Property(u => u.UserName).HasMaxLength(256);
                b.Property(u => u.NormalizedUserName).HasMaxLength(256);
                b.Property(u => u.Email).HasMaxLength(256);
                b.Property(u => u.NormalizedEmail).HasMaxLength(256);
                b.HasMany<UserClaimDao>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();
                b.HasMany<UserLoginDao>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();
                b.HasMany<UserTokenDao>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();
                b.HasMany<UserRoleDao>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            });

            builder.Entity<UserClaim>(b =>
            {
                b.HasKey(uc => uc.Id);
                b.ToTable("UserClaims");
            });

            builder.Entity<UserLoginDao>(b =>
            {
                b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
                b.Property(l => l.LoginProvider).HasMaxLength(128);
                b.Property(l => l.ProviderKey).HasMaxLength(128);
                b.ToTable("UserLogins");
            });

            builder.Entity<UserTokenDao>(b =>
            {
                b.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
                b.Property(t => t.LoginProvider).HasMaxLength(256);
                b.Property(t => t.Name).HasMaxLength(256);
                b.ToTable("UserTokens");
            });

            builder.Entity<RoleDao>(b =>
            {
                b.HasKey(r => r.Id);
                b.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();
                b.ToTable("Roles");
                b.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();
                b.Property(u => u.Name).HasMaxLength(256);
                b.Property(u => u.NormalizedName).HasMaxLength(256);
                b.HasMany<UserRoleDao>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();
                b.HasMany<RoleClaimDao>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();
            });

            builder.Entity<RoleClaimDao>(b =>
            {
                b.HasKey(rc => rc.Id);
                b.ToTable("RoleClaims");
            });

            builder.Entity<UserRoleDao>(b =>
            {
                b.HasKey(r => new { r.UserId, r.RoleId });
                b.ToTable("UserRoles");
            });
        }
        }
}
