﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Data;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerContext))]
    [Migration("20200404034128_FirstSpeaker")]
    partial class FirstSpeaker
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Meeting", b =>
                {
                    b.Property<Guid>("MeetingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClosingHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClosingHymnNumber")
                        .HasColumnType("int");

                    b.Property<string>("ClosingPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conducting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstSpeaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntermediateHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IntermediateHymnNumber")
                        .HasColumnType("int");

                    b.Property<string>("OpeningHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpeningHymnNumber")
                        .HasColumnType("int");

                    b.Property<string>("OpeningPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SacramentHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SacramentHymnNumber")
                        .HasColumnType("int");

                    b.Property<string>("SecondSpeaker")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeetingID");

                    b.ToTable("Meeting");
                });
#pragma warning restore 612, 618
        }
    }
}