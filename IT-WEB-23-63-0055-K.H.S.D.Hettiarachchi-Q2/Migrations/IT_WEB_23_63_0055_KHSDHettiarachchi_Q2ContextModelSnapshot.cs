﻿// <auto-generated />
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Migrations
{
    [DbContext(typeof(IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context))]
    partial class IT_WEB_23_63_0055_KHSDHettiarachchi_Q2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Model.Student_Info", b =>
                {
                    b.Property<string>("Student_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_Id");

                    b.ToTable("Student_Info");
                });
#pragma warning restore 612, 618
        }
    }
}