using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lvt_2310900103.Models;

public partial class LeVietTien2310900103Context : DbContext
{
    public LeVietTien2310900103Context()
    {
    }

    public LeVietTien2310900103Context(DbContextOptions<LeVietTien2310900103Context> options)
        : base(options)
    {
    }

    public virtual DbSet<LvtEmployee> LvtEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-SO4PPTO\\TIENLE;Database=LeVietTien_2310900103;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LvtEmployee>(entity =>
        {
            entity.HasKey(e => e.LvtEmpId).HasName("PK__LvtEmplo__2691417FB4D38288");

            entity.ToTable("LvtEmployee");

            entity.Property(e => e.LvtEmpId)
                .ValueGeneratedNever()
                .HasColumnName("lvtEmpId");
            entity.Property(e => e.LvtEmpLevel).HasColumnName("lvtEmpLevel");
            entity.Property(e => e.LvtEmpName)
                .HasMaxLength(50)
                .HasColumnName("lvtEmpName");
            entity.Property(e => e.LvtEmpStartDate).HasColumnName("lvtEmpStartDate");
            entity.Property(e => e.LvtEmpStatus).HasColumnName("lvtEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
