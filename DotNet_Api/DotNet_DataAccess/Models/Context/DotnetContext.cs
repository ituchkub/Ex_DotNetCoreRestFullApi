using System;
using System.Collections.Generic;
using Dotnet_DataAccess.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_DataAccess.Models.Context;

public partial class DotnetContext : DbContext
{
    public DotnetContext()
    {
    }

    public DotnetContext(DbContextOptions<DotnetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MasEmployee> MasEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-BM4E60L\\SQLEXPRESS;Initial Catalog=Dotnet;Integrated Security=False;User ID=admin;Password=admin;Min Pool Size=10;Max Pool Size=200;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MasEmployee>(entity =>
        {
            entity.Property(e => e.EmpId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
