using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdTinderv2.DAL
{
    public partial class ModelContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual Microsoft.EntityFrameworkCore.DbSet<BirdUser> BirdUser { get; set; }

        public virtual Microsoft.EntityFrameworkCore.DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=model;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BirdUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__BirdUser__1788CC4C632C9601");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.UserBio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id)
                .HasName("PK__User__1887C48C632236DJ");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);

                entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);

                entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);

                entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false);

                entity.Property(e => e.Token)
                .HasMaxLength(255)
                .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
