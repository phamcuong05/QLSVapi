﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentAPI.Models;

namespace StudentAPI.Migrations
{
    [DbContext(typeof(StudentDBContext))]
    partial class StudentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("StudentAPI.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("specialist")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}
