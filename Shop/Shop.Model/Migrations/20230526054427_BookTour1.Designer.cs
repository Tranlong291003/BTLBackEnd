﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Model.Entities;

#nullable disable

namespace Shop.Model.Migrations
{
    [DbContext(typeof(ShopOnlineContext))]
    [Migration("20230526054427_BookTour1")]
    partial class BookTour1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Shop.Model.Entities.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberImage3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberName3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("introduce")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("Shop.Model.Entities.BookTour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BookTours");
                });

            modelBuilder.Entity("Shop.Model.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Shop.Model.Entities.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Shop.Model.Entities.Footer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ID");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Footers");
                });

            modelBuilder.Entity("Shop.Model.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int")
                        .HasColumnName("GroupID");

                    b.Property<string>("Name")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Target")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Url")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("URL");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Shop.Model.Entities.MenuGroup", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("MenuGroups");
                });

            modelBuilder.Entity("Shop.Model.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("CustomerAddress")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("CustomerEmail")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CustomerMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerMobile")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PaymentMethod")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PaymentStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Shop.Model.Entities.OrderDetail", b =>
                {
                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Shop.Model.Entities.Page", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MetaKeyWord")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Shop.Model.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Image")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Shop.Model.Entities.PostCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("PostCategories");
                });

            modelBuilder.Entity("Shop.Model.Entities.PostTag", b =>
                {
                    b.Property<int?>("PostId")
                        .HasColumnType("int")
                        .HasColumnName("PostID");

                    b.Property<string>("TagId")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TagID");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("Shop.Model.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int?>("Amountofpeople")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<int?>("Day")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DaySubmit")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("Evaluate")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MoreImage")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal?>("Promotion")
                        .HasColumnType("decimal(18,0)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int");

                    b.Property<int?>("Warranty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shop.Model.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Shop.Model.Entities.ProductTag", b =>
                {
                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<string>("TagId")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TagID");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("Shop.Model.Entities.Slide", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("URL");

                    b.HasKey("Id");

                    b.ToTable("Slides");
                });

            modelBuilder.Entity("Shop.Model.Entities.SupportOnline", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Department")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Facebook")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Skype")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SupportOnlines");
                });

            modelBuilder.Entity("Shop.Model.Entities.SystemConfig", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ValueInt")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ValueString")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("SystemConfigs");
                });

            modelBuilder.Entity("Shop.Model.Entities.Tag", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Shop.Model.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Shop.Model.Entities.VisitorStaticti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ipaddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("IPAddress");

                    b.Property<DateTime>("VisitedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("VisitorStatictis");
                });

            modelBuilder.Entity("Shop.Model.Entities.Menu", b =>
                {
                    b.HasOne("Shop.Model.Entities.MenuGroup", "Group")
                        .WithMany("Menus")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK__Menus__GroupID__4F7CD00D");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Shop.Model.Entities.OrderDetail", b =>
                {
                    b.HasOne("Shop.Model.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__OrderDeta__Order__49C3F6B7");

                    b.HasOne("Shop.Model.Entities.ProductCategory", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__OrderDeta__Produ__4AB81AF0");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop.Model.Entities.Post", b =>
                {
                    b.HasOne("Shop.Model.Entities.PostCategory", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Posts__CategoryI__3E52440B");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Shop.Model.Entities.PostTag", b =>
                {
                    b.HasOne("Shop.Model.Entities.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK__PostTags__PostID__44FF419A");

                    b.HasOne("Shop.Model.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK__PostTags__TagID__45F365D3");

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Shop.Model.Entities.Product", b =>
                {
                    b.HasOne("Shop.Model.Entities.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Products__Catego__398D8EEE");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Shop.Model.Entities.ProductTag", b =>
                {
                    b.HasOne("Shop.Model.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__ProductTa__Produ__4222D4EF");

                    b.HasOne("Shop.Model.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK__ProductTa__TagID__4316F928");

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Shop.Model.Entities.MenuGroup", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("Shop.Model.Entities.PostCategory", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Shop.Model.Entities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
