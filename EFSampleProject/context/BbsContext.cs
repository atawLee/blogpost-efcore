using System;
using System.Collections.Generic;
using EFSampleProject.models;
using Microsoft.EntityFrameworkCore;

namespace EFSampleProject.context;

public partial class BbsContext : DbContext
{
    public BbsContext(DbContextOptions<BbsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Board> Boards { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Board>(entity =>
        {
            entity.HasKey(e => e.BoardId).HasName("PRIMARY");

            entity.ToTable("BOARD");

            entity.HasIndex(e => e.UserId, "UserId");

            entity.Property(e => e.Contents).HasColumnType("text");
            entity.Property(e => e.PostDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasOne(d => d.User).WithMany(p => p.Boards)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("BOARD_ibfk_1");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("USERS");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMail");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
