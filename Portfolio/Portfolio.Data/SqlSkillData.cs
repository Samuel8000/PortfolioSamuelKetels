using Microsoft.EntityFrameworkCore;
using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Data
{
    public class SqlSkillData : ISkillData
    {
        private readonly PortfolioDbContext _context;

        public SqlSkillData(PortfolioDbContext context)
        {
            _context = context;
        }

        public Skill Add(Skill newSkill)
        {
            _context.Add(newSkill);
            return newSkill;
        }


        public int Commit()
        {
            return _context.SaveChanges();
        }

        public Skill Delete(int skillId)
        {
            var skill = GetSkillById(skillId);
            if(skill != null)
            {
                _context.Skills.Remove(skill);
            }
            return skill;
        }

        public IEnumerable<Skill> GetAllSkills()
        {
            return _context.Skills.OrderBy(s => s.Id);
        }

        public Skill GetSkillById(int skillId)
        {
            return _context.Skills.Find(skillId);
        }

        public Skill UpdateSkill(Skill updatedSkill)
        {
            var entity = _context.Skills.Attach(updatedSkill);
            entity.State = EntityState.Modified;
            return updatedSkill;
        }
    }
}
