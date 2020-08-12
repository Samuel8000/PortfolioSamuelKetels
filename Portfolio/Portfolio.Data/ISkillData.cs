using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Data
{
    public interface ISkillData
    {
        //SkillPath AddNewSkillPath(SkillPath path);
        IEnumerable<Skill> GetAllSkills();
        Skill GetSkillById(int skillId);
        Skill UpdateSkill(Skill updatedSkill);
        Skill Add(Skill newSkill);
        Skill Delete(int skillId);
        int Commit();
    }
}
