using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dbfirstef.Models
{
    public partial class TestDbContext : DbContext
    {
        public TestDbContext()
        {
        }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Many> Manies { get; set; } = null!;
        public virtual DbSet<Manytomany> Manytomanys { get; set; } = null!;
        public virtual DbSet<Oness> Onesses { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<ToOne> ToOnes { get; set; } = null!;
        public virtual DbSet<Tomany1> Tomany1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestDb;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Many>(entity =>
            {
                entity.ToTable("many");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasMany(d => d.Tomany2s)
                    .WithMany(p => p.Manys)
                    .UsingEntity<Dictionary<string, object>>(
                        "Manymanytomany",
                        l => l.HasOne<Manytomany>().WithMany().HasForeignKey("Tomany2sid"),
                        r => r.HasOne<Many>().WithMany().HasForeignKey("Manysid"),
                        j =>
                        {
                            j.HasKey("Manysid", "Tomany2sid");

                            j.ToTable("manymanytomany");

                            j.HasIndex(new[] { "Tomany2sid" }, "IX_manymanytomany_tomany2sid");

                            j.IndexerProperty<int>("Manysid").HasColumnName("manysid");

                            j.IndexerProperty<int>("Tomany2sid").HasColumnName("tomany2sid");
                        });
            });

            modelBuilder.Entity<Manytomany>(entity =>
            {
                entity.ToTable("manytomanys");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Oness>(entity =>
            {
                entity.ToTable("oness");

                entity.HasIndex(e => e.Tomany1id, "IX_oness_tomany1id");

                entity.Property(e => e.Tomany1id).HasColumnName("tomany1id");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Tomany1)
                    .WithMany(p => p.Onesses)
                    .HasForeignKey(d => d.Tomany1id);
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasKey(e => e.Parentkey);

                entity.ToTable("parents");

                entity.Property(e => e.Parentkey).HasColumnName("parentkey");

                entity.Property(e => e.Hobby).HasColumnName("hobby");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ToOne>(entity =>
            {
                entity.ToTable("to_Ones");

                entity.HasIndex(e => e.RelatedtoOneId, "IX_to_Ones_relatedto_oneId");

                entity.Property(e => e.RelatedtoOneId).HasColumnName("relatedto_oneId");

                entity.HasOne(d => d.RelatedtoOne)
                    .WithMany(p => p.ToOnes)
                    .HasForeignKey(d => d.RelatedtoOneId);
            });

            modelBuilder.Entity<Tomany1>(entity =>
            {
                entity.ToTable("tomany1s");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
