﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NurseryMgrData;

namespace NurseryMgrData.Migrations
{
    [DbContext(typeof(NurseryDbContext))]
    partial class NurseryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("NurseryMgrData.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("SchoolId");

                    b.Property<int?>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("NurseryMgrData.Models.DailyActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChildId");

                    b.Property<string>("Comment");

                    b.Property<DateTime>("DateRecorded");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.ToTable("Activitties");
                });

            modelBuilder.Entity("NurseryMgrData.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("NurseryMgrData.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("PrincipalId");

                    b.HasKey("Id");

                    b.HasIndex("PrincipalId");

                    b.ToTable("School");
                });

            modelBuilder.Entity("NurseryMgrData.Models.Child", b =>
                {
                    b.HasBaseType("NurseryMgrData.Models.Person");

                    b.Property<int?>("ClassId");

                    b.Property<int?>("ParentId");

                    b.HasIndex("ClassId");

                    b.HasIndex("ParentId");

                    b.HasDiscriminator().HasValue("Child");
                });

            modelBuilder.Entity("NurseryMgrData.Models.Parent", b =>
                {
                    b.HasBaseType("NurseryMgrData.Models.Person");

                    b.HasDiscriminator().HasValue("Parent");
                });

            modelBuilder.Entity("NurseryMgrData.Models.Principal", b =>
                {
                    b.HasBaseType("NurseryMgrData.Models.Person");

                    b.HasDiscriminator().HasValue("Principal");
                });

            modelBuilder.Entity("NurseryMgrData.Models.Teacher", b =>
                {
                    b.HasBaseType("NurseryMgrData.Models.Person");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("NurseryMgrData.Models.Class", b =>
                {
                    b.HasOne("NurseryMgrData.Models.School", "School")
                        .WithMany("Classes")
                        .HasForeignKey("SchoolId");

                    b.HasOne("NurseryMgrData.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("NurseryMgrData.Models.DailyActivity", b =>
                {
                    b.HasOne("NurseryMgrData.Models.Child", "Child")
                        .WithMany("DailyActivity")
                        .HasForeignKey("ChildId");
                });

            modelBuilder.Entity("NurseryMgrData.Models.School", b =>
                {
                    b.HasOne("NurseryMgrData.Models.Principal", "Principal")
                        .WithMany()
                        .HasForeignKey("PrincipalId");
                });

            modelBuilder.Entity("NurseryMgrData.Models.Child", b =>
                {
                    b.HasOne("NurseryMgrData.Models.Class", "Class")
                        .WithMany("Children")
                        .HasForeignKey("ClassId");

                    b.HasOne("NurseryMgrData.Models.Parent", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
