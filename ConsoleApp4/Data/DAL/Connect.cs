using ConsoleApp4.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.DAL
{
    class Connect:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=215-16;Database=Blog;Trusted_Connection=TRUE;");
        }
       public DbSet<Post> Posts { get; set; }

    }
}
