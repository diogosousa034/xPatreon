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

            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            modelBuilder.Entity<Page>()
                    .HasKey(o => o.Page_ID);
            modelBuilder.Entity<Page>()
                .Property(e => e.Page_ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Page>()
                .HasIndex(u => u.PageName)
                .IsUnique();

            modelBuilder.Entity<PageContent>()
                    .HasKey(o => o.Content_ID);
            modelBuilder.Entity<PageContent>()
                .Property(e => e.Content_ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Patrons>()
                    .HasKey(o => o.PatronFollow_ID);
            modelBuilder.Entity<Patrons>()
                .Property(e => e.PatronFollow_ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<ContentComments>()
                    .HasKey(o => o.Comment_ID);
            modelBuilder.Entity<ContentComments>()
                .Property(e => e.Comment_ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Page>()
                .HasOne<User>(s => s.User)
                .WithOne(g => g.Page)
                .HasForeignKey<Page>(s => s.User_ID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PageContent>()
                .HasOne<Page>(s => s.Page)
                .WithMany(g => g.Contents)
                .HasForeignKey(s => s.Page_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Patrons>()
                .HasOne<Page>(s => s.Page)
                .WithMany(g => g.patrons)
                .HasForeignKey(s => s.Page_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ContentComments>()
                .HasOne<PageContent>(s => s.PageContent)
                .WithMany(g => g.Comments)
                .HasForeignKey(s => s.Content_ID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ContentComments>()
                 .HasOne<User>(s => s.user)
                 .WithMany(g => g.comments)
                 .HasForeignKey(s => s.User_ID)
                 .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<PageContent> PageContents { get; set; }
        public DbSet<Patrons> Patrons { get; set; }
        public DbSet<ContentComments> ContentComments { get; set; }
    }
}
