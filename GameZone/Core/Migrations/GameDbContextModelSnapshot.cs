﻿// <auto-generated />
using GameZone.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameZone.Migrations
{
    [DbContext(typeof(GameDbContext))]
    partial class GameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameZone.Models.Categorey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            Name = "RPG"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Simulation"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Puzzle"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Racing"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Shooter"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Horror"
                        });
                });

            modelBuilder.Entity("GameZone.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ICone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ICone = "pc_icon.png",
                            Name = "PC"
                        },
                        new
                        {
                            Id = 2,
                            ICone = "ps_icon.png",
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 3,
                            ICone = "xbox_icon.png",
                            Name = "Xbox"
                        },
                        new
                        {
                            Id = 4,
                            ICone = "switch_icon.png",
                            Name = "Nintendo Switch"
                        },
                        new
                        {
                            Id = 5,
                            ICone = "mobile_icon.png",
                            Name = "Mobile"
                        },
                        new
                        {
                            Id = 6,
                            ICone = "tablet_icon.png",
                            Name = "Tablet"
                        },
                        new
                        {
                            Id = 7,
                            ICone = "vr_icon.png",
                            Name = "VR Headset"
                        });
                });

            modelBuilder.Entity("GameZone.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameZone.Models.GameDevice", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "DeviceId");

                    b.HasIndex("DeviceId");

                    b.ToTable("GamesDevices");
                });

            modelBuilder.Entity("GameZone.Models.Game", b =>
                {
                    b.HasOne("GameZone.Models.Categorey", "Categoriy")
                        .WithMany("Games")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoriy");
                });

            modelBuilder.Entity("GameZone.Models.GameDevice", b =>
                {
                    b.HasOne("GameZone.Models.Device", "Device")
                        .WithMany("Games")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameZone.Models.Game", "Game")
                        .WithMany("Devices")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GameZone.Models.Categorey", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("GameZone.Models.Device", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("GameZone.Models.Game", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
