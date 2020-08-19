﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Data;

namespace Portfolio.Data.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    partial class PortfolioDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portfolio.Core.AboutMeInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DevelopmentInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Live")
                        .HasColumnType("bit");

                    b.Property<string>("PersonalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutMe");
                });

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

                    b.Property<int>("CourseCategorie")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCompleted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

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
                            CertificateFileName = "NoCertificate.pdf",
                            CertificateName = "HTML5 Fundamentals",
                            CourseCategorie = 0,
                            DateCompleted = new DateTime(2020, 8, 19, 8, 34, 26, 238, DateTimeKind.Local).AddTicks(4819),
                            Done = false,
                            SkillId = 1
                        },
                        new
                        {
                            Id = 2,
                            CertificateDescription = "Basics of CSS3",
                            CertificateFileName = "NoCertificate.pdf",
                            CertificateName = "Introduction to CSS",
                            CourseCategorie = 0,
                            DateCompleted = new DateTime(2020, 8, 19, 8, 34, 26, 246, DateTimeKind.Local).AddTicks(727),
                            Done = false,
                            SkillId = 2
                        },
                        new
                        {
                            Id = 3,
                            CertificateDescription = "Basics of CSS3",
                            CertificateFileName = "NoCertificate.pdf",
                            CertificateName = "Your First Day with CSS",
                            CourseCategorie = 0,
                            DateCompleted = new DateTime(2020, 8, 19, 8, 34, 26, 246, DateTimeKind.Local).AddTicks(1018),
                            Done = false,
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

                    b.Property<string>("ContactPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactType")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateContacted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Portfolio.Core.EmailSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FromAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmailSettings");
                });

            modelBuilder.Entity("Portfolio.Core.FreeCodeCampProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FccCategory")
                        .HasColumnType("int");

                    b.Property<string>("FccProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FccProjectLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FccProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FccProjectThumb")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FccProjects");
                });

            modelBuilder.Entity("Portfolio.Core.PPTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonalProjectId")
                        .HasColumnType("int");

                    b.Property<int>("Tag1")
                        .HasColumnType("int");

                    b.Property<int>("Tag2")
                        .HasColumnType("int");

                    b.Property<int>("Tag3")
                        .HasColumnType("int");

                    b.Property<int>("Tag4")
                        .HasColumnType("int");

                    b.Property<int>("Tag5")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonalProjectId");

                    b.ToTable("PersonalProjectTags");
                });

            modelBuilder.Entity("Portfolio.Core.PersonalProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCompleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectThumb")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
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

            modelBuilder.Entity("Portfolio.Core.SkillPath", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<string>("SkillPathName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillPaths");
                });

            modelBuilder.Entity("Portfolio.Core.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Portfolio.Core.Certificate", b =>
                {
                    b.HasOne("Portfolio.Core.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Portfolio.Core.PPTag", b =>
                {
                    b.HasOne("Portfolio.Core.PersonalProject", "PersonalProject")
                        .WithMany()
                        .HasForeignKey("PersonalProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Portfolio.Core.SkillPath", b =>
                {
                    b.HasOne("Portfolio.Core.Skill", "Skill")
                        .WithMany("SkillPaths")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
