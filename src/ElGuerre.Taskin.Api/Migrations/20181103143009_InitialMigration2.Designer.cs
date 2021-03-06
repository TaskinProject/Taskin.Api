﻿// <auto-generated />
using System;
using ElGuerre.Taskin.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ElGuerre.Taskin.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181103143009_InitialMigration2")]
    partial class InitialMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ElGuerre.Taskin.Api.Data.Entity.ProjectEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail");

                    b.Property<string>("ImageUrl");

                    b.Property<int?>("ProjectTypeId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ProjectTypeId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Detail = "Detail for Project 1",
                            ProjectTypeId = 1,
                            Title = "Project 1"
                        },
                        new
                        {
                            Id = 2,
                            Detail = "Detail for Project 2",
                            ProjectTypeId = 1,
                            Title = "Project 2"
                        },
                        new
                        {
                            Id = 3,
                            Detail = "Detail for Project 3",
                            ProjectTypeId = 1,
                            Title = "Project 3"
                        });
                });

            modelBuilder.Entity("ElGuerre.Taskin.Api.Data.Entity.ProjectTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.ToTable("ProjectTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = 0
                        },
                        new
                        {
                            Id = 2,
                            Value = 1
                        },
                        new
                        {
                            Id = 3,
                            Value = 2
                        },
                        new
                        {
                            Id = 4,
                            Value = 3
                        },
                        new
                        {
                            Id = 5,
                            Value = 4
                        },
                        new
                        {
                            Id = 6,
                            Value = 9
                        });
                });

            modelBuilder.Entity("ElGuerre.Taskin.Api.Data.Entity.TaskEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail");

                    b.Property<int>("Effort");

                    b.Property<int>("Priority");

                    b.Property<int?>("ProjectId");

                    b.Property<int?>("TaskTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TaskTypeId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Detail = "Task 1",
                            Effort = 0,
                            Priority = 0,
                            ProjectId = 1,
                            TaskTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Detail = "Task 2",
                            Effort = 1,
                            Priority = -1,
                            ProjectId = 1,
                            TaskTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Detail = "Task 3",
                            Effort = 3,
                            Priority = 1,
                            ProjectId = 1,
                            TaskTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Detail = "Task 4",
                            Effort = 0,
                            Priority = 0,
                            ProjectId = 2,
                            TaskTypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            Detail = "Task 5",
                            Effort = 1,
                            Priority = -1,
                            ProjectId = 2,
                            TaskTypeId = 1
                        },
                        new
                        {
                            Id = 6,
                            Detail = "Task 6",
                            Effort = 3,
                            Priority = 1,
                            ProjectId = 2,
                            TaskTypeId = 1
                        });
                });

            modelBuilder.Entity("ElGuerre.Taskin.Api.Data.Entity.TaskTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.ToTable("TaskTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = 0
                        },
                        new
                        {
                            Id = 2,
                            Value = 1
                        },
                        new
                        {
                            Id = 3,
                            Value = 2
                        },
                        new
                        {
                            Id = 4,
                            Value = 5
                        },
                        new
                        {
                            Id = 5,
                            Value = 9
                        },
                        new
                        {
                            Id = 6,
                            Value = 4
                        },
                        new
                        {
                            Id = 7,
                            Value = 7
                        },
                        new
                        {
                            Id = 8,
                            Value = 8
                        },
                        new
                        {
                            Id = 9,
                            Value = 3
                        },
                        new
                        {
                            Id = 10,
                            Value = 6
                        },
                        new
                        {
                            Id = 11,
                            Value = 20
                        });
                });

            modelBuilder.Entity("ElGuerre.Taskin.Api.Data.Entity.ProjectEntity", b =>
                {
                    b.HasOne("ElGuerre.Taskin.Api.Data.Entity.ProjectTypeEntity", "ProjectType")
                        .WithMany()
                        .HasForeignKey("ProjectTypeId");
                });

            modelBuilder.Entity("ElGuerre.Taskin.Api.Data.Entity.TaskEntity", b =>
                {
                    b.HasOne("ElGuerre.Taskin.Api.Data.Entity.ProjectEntity", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId");

                    b.HasOne("ElGuerre.Taskin.Api.Data.Entity.TaskTypeEntity", "TaskType")
                        .WithMany()
                        .HasForeignKey("TaskTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
