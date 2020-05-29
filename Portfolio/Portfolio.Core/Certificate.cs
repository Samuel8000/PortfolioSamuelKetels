using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Core
{
    public class Certificate
    {
        public int Id { get; set; }
        public string CertificateName { get; set; }
        public string CertificateDescription { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
