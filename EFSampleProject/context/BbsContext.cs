using System;
using System.Collections.Generic;
using EFSampleProject.models;
using Microsoft.EntityFrameworkCore;

namespace EFSampleProject.context;

public class BbsContext : DbContext
{
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
            optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=dlwhdgns;database=BBS",
                new MySqlServerVersion(new Version(8, 1, 0)));
    }

    public virtual DbSet<Board> Boards { get; set; }

    public virtual DbSet<User> Users { get; set; }
}
