﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RESTful_API.Data;

#nullable disable

namespace RESTful_API.Migrations
{
    [DbContext(typeof(EcomeraceDbContext))]
    partial class EcomeraceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RESTful_API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("displayOrder")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            displayOrder = 1,
                            title = "Nokia"
                        },
                        new
                        {
                            Id = 2,
                            displayOrder = 2,
                            title = "Apple"
                        },
                        new
                        {
                            Id = 3,
                            displayOrder = 3,
                            title = "Xiomi"
                        },
                        new
                        {
                            Id = 4,
                            displayOrder = 4,
                            title = "Oppo"
                        },
                        new
                        {
                            Id = 5,
                            displayOrder = 5,
                            title = "Vivo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
