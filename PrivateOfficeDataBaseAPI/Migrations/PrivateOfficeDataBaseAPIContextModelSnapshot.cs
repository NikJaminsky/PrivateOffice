﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrivateOfficeDataBaseAPI.Data;

namespace PrivateOfficeDataBaseAPI.Migrations
{
    [DbContext(typeof(PrivateOfficeDataBaseAPIContext))]
    partial class PrivateOfficeDataBaseAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Classes", b =>
                {
                    b.Property<int>("IdClasses")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountTime")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("IdCourse")
                        .HasColumnType("int");

                    b.Property<string>("NameClasses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("IdClasses");

                    b.HasIndex("IdCourse");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Course", b =>
                {
                    b.Property<int>("IdCourse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdTeacher")
                        .HasColumnType("int");

                    b.Property<string>("NameCourse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCourse");

                    b.HasIndex("IdTeacher");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Teacher", b =>
                {
                    b.Property<int>("IdTeacher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTeacher");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Classes", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Course", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Teacher", "Teacher")
                        .WithMany("Course")
                        .HasForeignKey("IdTeacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
