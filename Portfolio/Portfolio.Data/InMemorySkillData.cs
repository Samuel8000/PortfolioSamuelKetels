﻿using Portfolio.Core;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Data
{
    public class InMemorySkillData : ISkillData
    {
        List<Skill> skills;

        public InMemorySkillData()
        {
            skills = new List<Skill>()
            {
                new Skill {Id = 1, SkillName = "HTML5", SkillDescription="Personal Description and evaluation", LogoFilePath = "html5logo.png", PsChartFilePath="HTMLSkillIQ.png", PsSkillLevel = SkillLevel.Expert, PsSkillIqScore = 230, PsDescription = "Summary of courses followed"},
                new Skill {Id = 2, SkillName = "CSS3", SkillDescription="Personal Description and evaluation", LogoFilePath = "css3logo.png", PsChartFilePath="CSSSkillIQ.png", PsSkillLevel = SkillLevel.Proficient, PsSkillIqScore = 198, PsDescription = "Summary of courses followed"}
            };
        }
        public IEnumerable<Skill> GetAllSkills()
        {
            return skills.OrderBy(s => s.Id);
        }

        public Skill GetSkillById(int skillId)
        {
            return skills.SingleOrDefault(s => s.Id == skillId);
        }
    }
}
