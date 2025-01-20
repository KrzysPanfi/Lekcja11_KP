using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lekcja11_KP.Models;

public partial class _2019sbdContext : DbContext
{
    public _2019sbdContext()
    {
    }

    public _2019sbdContext(DbContextOptions<_2019sbdContext> options)
        : base(options)
    {
    }

  
    public virtual DbSet<Student> Students { get; set; }

  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=db-mssql;Database=2019SBD;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("l0860");

  
      

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PK__Student__2E8946D4AB05B363");

            entity.ToTable("Student");

            entity.Property(e => e.IdProduct).ValueGeneratedNever();
            entity.Property(e => e.Lname)
                .HasMaxLength(200)
                .HasColumnName("LName");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

       
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
