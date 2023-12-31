﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using empsysef;

#nullable disable

namespace empsysef.Migrations
{
    [DbContext(typeof(testempDB))]
    partial class testempDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("empsysef.employee1", b =>
                {
                    b.Property<int>("empId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("empId"), 1L, 1);

                    b.Property<string>("empname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ph_no")
                        .HasColumnType("int");

                    b.HasKey("empId");

                    b.ToTable("employee1");
                });
#pragma warning restore 612, 618
        }
    }
}
