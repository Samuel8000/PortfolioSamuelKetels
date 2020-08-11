using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portfolio.Core
{
    public class SkillPath
    {
        public int Id { get; set; }
        public string SkillPathName { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
