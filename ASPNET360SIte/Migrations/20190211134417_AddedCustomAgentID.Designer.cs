﻿// <auto-generated />
using ASPNET360SIte.Models; using ASPNET360SIte.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNET360SIte.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190211134417_AddedCustomAgentID")]
    partial class AddedCustomAgentID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNET360SIte.Models.FloorPlan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomPropertyID");

                    b.Property<string>("FloorPlanLabel");

                    b.Property<string>("MainImagePath");

                    b.HasKey("ID");

                    b.ToTable("FloorPlan");
                });

            modelBuilder.Entity("ASPNET360SIte.Models.Property", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Build");

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<string>("CustomAgentID");

                    b.Property<string>("Locality");

                    b.Property<string>("MainImagePath");

                    b.Property<string>("PostCode")
                        .HasMaxLength(10);

                    b.Property<string>("Street");

                    b.Property<string>("Town");

                    b.HasKey("ID");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("ASPNET360SIte.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomFloorPlanID");

                    b.Property<string>("MainImagePath");

                    b.Property<string>("RoomLabel");

                    b.HasKey("ID");

                    b.ToTable("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
