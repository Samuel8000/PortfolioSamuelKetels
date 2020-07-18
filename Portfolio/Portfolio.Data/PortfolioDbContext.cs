using Microsoft.EntityFrameworkCore;
using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options): base(options)
        {

        }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EmailSetting> EmailSettings { get; set; }
        public DbSet<PersonalProject> Projects { get; set; }
        public DbSet<FreeCodeCampProject> FccProjects { get; set; }
        public DbSet<PPTag> PersonalProjectTags { get; set; }
        public DbSet<AboutMeInfo> AboutMe { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>()
                .HasData(
                new Skill { Id = 1, SkillName = "HTML5", SkillDescription = "Personal Description and evaluation", LogoFilePath = "html5logo.png", PsChartFilePath = "HTMLSkillIQ.png", PsSkillLevel = SkillLevel.Expert, PsSkillIqScore = 230, PsDescription = "Summary of courses followed" },
                new Skill { Id = 2, SkillName = "CSS3", SkillDescription = "Personal Description and evaluation", LogoFilePath = "css3logo.png", PsChartFilePath = "CSSSkillIQ.png", PsSkillLevel = SkillLevel.Proficient, PsSkillIqScore = 198, PsDescription = "Summary of courses followed" }
                );

            modelBuilder.Entity<Certificate>()
                .HasData(
                new Certificate { Id = 1, CertificateName = "HTML5 Fundamentals", SkillId = 1, CertificateDescription ="Basics of HTML5" },
                new Certificate { Id = 2, CertificateName = "Introduction to CSS", SkillId = 2, CertificateDescription = "Basics of CSS3" },
                new Certificate { Id = 3, CertificateName = "Your First Day with CSS", SkillId = 2, CertificateDescription = "Basics of CSS3" }
                );
        }
    }
}
