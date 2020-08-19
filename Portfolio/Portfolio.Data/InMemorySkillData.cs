using Portfolio.Core;
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

        public Skill Add(Skill newSkill)
        {
            skills.Add(newSkill);
            newSkill.Id = skills.Max(s => s.Id) + 1;
            return newSkill;
        }

        public SkillPath AddNewSkillPath(SkillPath path)
        {
            throw new System.NotImplementedException();
        }

        public int Commit()
        {
            return 0;
        }

        public Skill Delete(int skillId)
        {
            var skill = skills.FirstOrDefault(s => s.Id == skillId);
            if(skill != null)
            {
                skills.Remove(skill);
            }
            return skill;
        }

        public IEnumerable<Skill> GetAllSkills()
        {
            return skills.OrderBy(s => s.Id);
        }

        public Skill GetSkillById(int skillId)
        {
            return skills.SingleOrDefault(s => s.Id == skillId);
        }

        public Skill UpdateSkill(Skill updatedSkill)
        {
            var skill = skills.SingleOrDefault(s => s.Id == updatedSkill.Id);
            if(skill != null)
            {
                skill.SkillName = updatedSkill.SkillName;
                skill.SkillDescription = updatedSkill.SkillDescription;
                skill.LogoFilePath = updatedSkill.LogoFilePath;
                skill.PsDescription = updatedSkill.PsDescription;
                skill.PsChartFilePath = updatedSkill.PsChartFilePath;
                skill.PsSkillIqScore = updatedSkill.PsSkillIqScore;
                skill.PsSkillLevel = updatedSkill.PsSkillLevel;
            }
            return skill;
        }
    }
}
