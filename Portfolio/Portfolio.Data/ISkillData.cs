using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Data
{
    public interface ISkillData
    {
        IEnumerable<Skill> GetAllSkills();
        Skill GetSkillById(int skillId);

        Skill UpdateSkill(Skill updatedSkill);
        int Commit();
    }
}
