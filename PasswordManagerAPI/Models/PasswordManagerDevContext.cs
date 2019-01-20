using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PasswordManagerAPI.Models
{
    public partial class PasswordManagerDevContext : DbContext
    {
        public PasswordManagerDevContext()
        {
        }

        public PasswordManagerDevContext(DbContextOptions<PasswordManagerDevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PasswordManager> PasswordManager { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CLC7U5P\\SQLEXPRESS;Initial Catalog=PasswordManagerDev;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PasswordManager>(entity =>
            {
                entity.HasKey(e => e.PasswordId);

                entity.Property(e => e.PasswordId).HasColumnName("PasswordID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Engine)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PasswordManager)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PasswordM__UserI__398D8EEE");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SignUpDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username).HasMaxLength(20);
            });
        }
    }
}
