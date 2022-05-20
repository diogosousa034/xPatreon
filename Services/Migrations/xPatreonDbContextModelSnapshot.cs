﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Services;

namespace Services.Migrations
{
    [DbContext(typeof(xPatreonDbContext))]
    partial class xPatreonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataBase.ContentComments", b =>
                {
                    b.Property<int>("Comment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CommentData")
                        .HasColumnType("datetime2");

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("Content_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Comment_ID");

                    b.HasIndex("Content_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("ContentComments");
                });

            modelBuilder.Entity("DataBase.Page", b =>
                {
                    b.Property<int>("Page_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutPage")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CreatingWhat")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("IsAreCreating")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("PageCreationData")
                        .HasColumnType("datetime2");

                    b.Property<string>("PageName")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.HasKey("Page_ID");

                    b.HasIndex("PageName")
                        .IsUnique()
                        .HasFilter("[PageName] IS NOT NULL");

                    b.HasIndex("User_ID")
                        .IsUnique();

                    b.ToTable("Page");
                });

            modelBuilder.Entity("DataBase.PageContent", b =>
                {
                    b.Property<int>("Content_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("MainContent")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("Page_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublicationData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Content_ID");

                    b.HasIndex("Page_ID");

                    b.ToTable("PageContents");
                });

            modelBuilder.Entity("DataBase.Patrons", b =>
                {
                    b.Property<int>("PatronFollow_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Page_ID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("PatronFollow_ID");

                    b.HasIndex("Page_ID");

                    b.HasIndex("UserID");

                    b.ToTable("Patrons");
                });

            modelBuilder.Entity("DataBase.User", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("RegistrationData")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("User_ID");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DataBase.ContentComments", b =>
                {
                    b.HasOne("DataBase.PageContent", "PageContent")
                        .WithMany("Comments")
                        .HasForeignKey("Content_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataBase.User", "user")
                        .WithMany("comments")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DataBase.Page", b =>
                {
                    b.HasOne("DataBase.User", "User")
                        .WithOne("Page")
                        .HasForeignKey("DataBase.Page", "User_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DataBase.PageContent", b =>
                {
                    b.HasOne("DataBase.Page", "Page")
                        .WithMany("Contents")
                        .HasForeignKey("Page_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataBase.Patrons", b =>
                {
                    b.HasOne("DataBase.Page", "Page")
                        .WithMany("patrons")
                        .HasForeignKey("Page_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBase.User", "user")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
