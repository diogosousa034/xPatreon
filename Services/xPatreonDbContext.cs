using DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class xPatreonDbContext : DbContext
    {
        public xPatreonDbContext(DbContextOptions<xPatreonDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                    .HasKey(o => o.User_ID);
            modelBuilder.Entity<User>()
                .Property(e => e.User_ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<UserContent>()
                    .HasKey(o => o.Content_ID);
            modelBuilder.Entity<UserContent>()
                .Property(e => e.Content_ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<UserContent>()
                .HasOne<User>(s => s.User)
                .WithMany(g => g.Contents)
                .HasForeignKey(s => s.User_ID)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserContent> UserContents { get; set; }
    }
}
