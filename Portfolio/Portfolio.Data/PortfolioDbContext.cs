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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>()
                .HasData(
                new Skill { Id = 1, SkillName = "HTML5", SkillDescription = "Personal Description and evaluation", LogoFilePath = "html5logo.png", PsChartFilePath = "HTMLSkillIQ.png", PsSkillLevel = SkillLevel.Expert, PsSkillIqScore = 230, PsDescription = "Summary of courses followed" },
                new Skill { Id = 2, SkillName = "CSS3", SkillDescription = "Personal Description and evaluation", LogoFilePath = "css3logo.png", PsChartFilePath = "CSSSkillIQ.png", PsSkillLevel = SkillLevel.Proficient, PsSkillIqScore = 198, PsDescription = "Summary of courses followed" }
                );
        }
    }
}
