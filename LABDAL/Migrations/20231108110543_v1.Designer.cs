﻿// <auto-generated />
using System;
using LABDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LABDAL.Migrations
{
    [DbContext(typeof(labclass.LabDBcontetxt))]
    [Migration("20231108110543_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LABDAL.labclass+company", b =>
                {
                    b.Property<int>("company_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("company_id"), 1L, 1);

                    b.Property<string>("company_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("relatedto_studentstudent_Id")
                        .HasColumnType("int");

                    b.HasKey("company_id");

                    b.HasIndex("relatedto_studentstudent_Id");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("LABDAL.labclass+course", b =>
                {
                    b.Property<int>("course_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("course_id"), 1L, 1);

                    b.Property<string>("course_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tomanystudentsstudent_id")
                        .HasColumnType("int");

                    b.HasKey("course_id");

                    b.HasIndex("tomanystudentsstudent_id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("LABDAL.labclass+student", b =>
                {
                    b.Property<int>("student_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("student_Id"), 1L, 1);

                    b.Property<string>("course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("tomanycoursecourse_id")
                        .HasColumnType("int");

                    b.HasKey("student_Id");

                    b.HasIndex("tomanycoursecourse_id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("LABDAL.labclass+tomanycourse", b =>
                {
                    b.Property<int>("course_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("course_id"), 1L, 1);

                    b.HasKey("course_id");

                    b.ToTable("tomanycourses1");
                });

            modelBuilder.Entity("LABDAL.labclass+tomanystudents", b =>
                {
                    b.Property<int>("student_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("student_id"), 1L, 1);

                    b.HasKey("student_id");

                    b.ToTable("tomanystudents1");
                });

            modelBuilder.Entity("LABDAL.labclass+company", b =>
                {
                    b.HasOne("LABDAL.labclass+student", "relatedto_student")
                        .WithMany()
                        .HasForeignKey("relatedto_studentstudent_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("relatedto_student");
                });

            modelBuilder.Entity("LABDAL.labclass+course", b =>
                {
                    b.HasOne("LABDAL.labclass+tomanystudents", null)
                        .WithMany("Toomanystudents")
                        .HasForeignKey("tomanystudentsstudent_id");
                });

            modelBuilder.Entity("LABDAL.labclass+student", b =>
                {
                    b.HasOne("LABDAL.labclass+tomanycourse", null)
                        .WithMany("Toomanycourses")
                        .HasForeignKey("tomanycoursecourse_id");
                });

            modelBuilder.Entity("LABDAL.labclass+tomanycourse", b =>
                {
                    b.Navigation("Toomanycourses");
                });

            modelBuilder.Entity("LABDAL.labclass+tomanystudents", b =>
                {
                    b.Navigation("Toomanystudents");
                });
#pragma warning restore 612, 618
        }
    }
}
