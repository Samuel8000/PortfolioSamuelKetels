﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Data;

namespace Portfolio.Data.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20200606093631_AddedContactDate")]
    partial class AddedContactDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portfolio.Core.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertificateDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificateFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("Certificates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CertificateDescription = "Basics of HTML5",
                            CertificateName = "HTML5 Fundamentals",
                            SkillId = 1
                        },
                        new
                        {
                            Id = 2,
                            CertificateDescription = "Basics of CSS3",
                            CertificateName = "Introduction to CSS",
                            SkillId = 2
                        },
                        new
                        {
                            Id = 3,
                            CertificateDescription = "Basics of CSS3",
                            CertificateName = "Your First Day with CSS",
                            SkillId = 2
                        });
                });

            modelBuilder.Entity("Portfolio.Core.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactOption")
                        .HasColumnType("int");

                    b.Property<int>("ContactType")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateContacted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Portfolio.Core.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LogoFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PsChartFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PsSkillIqScore")
                        .HasColumnType("int");

                    b.Property<int>("PsSkillLevel")
                        .HasColumnType("int");

                    b.Property<string>("SkillDescription")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LogoFilePath = "html5logo.png",
                            PsChartFilePath = "HTMLSkillIQ.png",
                            PsDescription = "Summary of courses followed",
                            PsSkillIqScore = 230,
                            PsSkillLevel = 3,
                            SkillDescription = "Personal Description and evaluation",
                            SkillName = "HTML5"
                        },
                        new
                        {
                            Id = 2,
                            LogoFilePath = "css3logo.png",
                            PsChartFilePath = "CSSSkillIQ.png",
                            PsDescription = "Summary of courses followed",
                            PsSkillIqScore = 198,
                            PsSkillLevel = 2,
                            SkillDescription = "Personal Description and evaluation",
                            SkillName = "CSS3"
                        });
                });

            modelBuilder.Entity("Portfolio.Core.Certificate", b =>
                {
                    b.HasOne("Portfolio.Core.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
