﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrivateOfficeDataBaseAPI.Data;

namespace PrivateOfficeDataBaseAPI.Migrations
{
    [DbContext(typeof(PrivateOfficeDataBaseAPIContext))]
    [Migration("20200206094124_UpdateDataBase")]
    partial class UpdateDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("DaysWeek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("IdCourse")
                        .HasColumnType("int");

                    b.Property<int?>("IdGroup")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("NameClasses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReplayClasses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<string>("TypeClasses")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClasses");

                    b.HasIndex("IdCourse");

                    b.HasIndex("IdGroup");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.ControlMeasures", b =>
                {
                    b.Property<int>("IdControlMeasures")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountControlMeasures")
                        .HasColumnType("int");

                    b.Property<int>("IdClasses")
                        .HasColumnType("int");

                    b.Property<int?>("IdStudent")
                        .HasColumnType("int");

                    b.Property<string>("NameControlMeasures")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdControlMeasures");

                    b.HasIndex("IdClasses");

                    b.HasIndex("IdStudent");

                    b.ToTable("ControlMeasures");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Course", b =>
                {
                    b.Property<int>("IdCourse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountTime")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<int?>("IdGroup")
                        .HasColumnType("int");

                    b.Property<int>("IdTeacher")
                        .HasColumnType("int");

                    b.Property<string>("NameCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameUniversity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("IdCourse");

                    b.HasIndex("IdGroup");

                    b.HasIndex("IdTeacher");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Group", b =>
                {
                    b.Property<int>("IdGroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameGroup")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGroup");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Questions", b =>
                {
                    b.Property<int>("IdQuestions")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentQuestions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountQuestions")
                        .HasColumnType("int");

                    b.Property<int>("IdControlMeasures")
                        .HasColumnType("int");

                    b.Property<int?>("IdTicket")
                        .HasColumnType("int");

                    b.Property<float>("Point")
                        .HasColumnType("real");

                    b.HasKey("IdQuestions");

                    b.HasIndex("IdControlMeasures");

                    b.HasIndex("IdTicket");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Report", b =>
                {
                    b.Property<int>("IdReport")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdClasses")
                        .HasColumnType("int");

                    b.Property<int?>("IdStudent")
                        .HasColumnType("int");

                    b.Property<string>("NameReport")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReport");

                    b.HasIndex("IdClasses");

                    b.HasIndex("IdStudent");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Student", b =>
                {
                    b.Property<int>("IdStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ConfirmVisit")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdGroup")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visited")
                        .HasColumnType("bit");

                    b.HasKey("IdStudent");

                    b.HasIndex("IdGroup");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Task", b =>
                {
                    b.Property<int>("IdTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentTask")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountTask")
                        .HasColumnType("int");

                    b.Property<int>("IdControlMeasures")
                        .HasColumnType("int");

                    b.Property<int?>("IdTicket")
                        .HasColumnType("int");

                    b.Property<float>("Point")
                        .HasColumnType("real");

                    b.HasKey("IdTask");

                    b.HasIndex("IdControlMeasures");

                    b.HasIndex("IdTicket");

                    b.ToTable("Task");
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

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Ticket", b =>
                {
                    b.Property<int>("IdTicket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountTicket")
                        .HasColumnType("int");

                    b.Property<int>("IdControlMeasures")
                        .HasColumnType("int");

                    b.Property<int>("NumberTicket")
                        .HasColumnType("int");

                    b.HasKey("IdTicket");

                    b.HasIndex("IdControlMeasures");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Classes", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Course", "Course")
                        .WithMany("Classes")
                        .HasForeignKey("IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Group", "Group")
                        .WithMany("Classes")
                        .HasForeignKey("IdGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.ControlMeasures", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Classes", "Classes")
                        .WithMany("ControlMeasures")
                        .HasForeignKey("IdClasses")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Student", "Student")
                        .WithMany("ControlMeasures")
                        .HasForeignKey("IdStudent");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Course", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Group", "Group")
                        .WithMany("Course")
                        .HasForeignKey("IdGroup");

                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Teacher", "Teacher")
                        .WithMany("Course")
                        .HasForeignKey("IdTeacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Questions", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.ControlMeasures", "ControlMeasures")
                        .WithMany("Questions")
                        .HasForeignKey("IdControlMeasures")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Ticket", "Ticket")
                        .WithMany("Questions")
                        .HasForeignKey("IdTicket");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Report", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Classes", "Classes")
                        .WithMany("Report")
                        .HasForeignKey("IdClasses");

                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Student", "Student")
                        .WithMany("Report")
                        .HasForeignKey("IdStudent");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Student", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Group", "Group")
                        .WithMany("Student")
                        .HasForeignKey("IdGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Task", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.ControlMeasures", "ControlMeasures")
                        .WithMany("Task")
                        .HasForeignKey("IdControlMeasures")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivateOfficeDataBaseAPI.Models.Ticket", "Ticket")
                        .WithMany("Task")
                        .HasForeignKey("IdTicket");
                });

            modelBuilder.Entity("PrivateOfficeDataBaseAPI.Models.Ticket", b =>
                {
                    b.HasOne("PrivateOfficeDataBaseAPI.Models.ControlMeasures", "ControlMeasures")
                        .WithMany("Ticket")
                        .HasForeignKey("IdControlMeasures")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}