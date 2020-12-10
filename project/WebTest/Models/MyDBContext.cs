using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace WebTest.Models
{
    public class MyDBContext: DbContext
    {
        public virtual DbSet<UserInfo> Users { get; set; }


        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserInfo>(entity => {
               entity.Property(t => t.UserName).HasDefaultValue("xuyang");
            });
        }
    }
}
