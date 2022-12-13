using System;
using System.Collections.Generic;
using ITuCHCore.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace ITuCHCore.Models.Context;

public partial class UserDataContext : DbContext
{
    public UserDataContext()
    {
    }

    public UserDataContext(DbContextOptions<UserDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MasEmployee> MasEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-BM4E60L\\SQLEXPRESS;Initial Catalog=UserData;Integrated Security=False;User ID=admin;Password=admin;Min Pool Size=10;Max Pool Size=200;Trust Server Certificate=true");

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
