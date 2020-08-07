using Portfolio.Core.Modelhelpers;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core
{
    public class Skill
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string SkillName { get; set; }
        [Display(Name = "Personal Evaluation")]
        [StringLength(500)]
        public string SkillDescription { get; set; }
        public string LogoFilePath { get; set; } = "NoLogo.png";
        [Display(Name = "Courses Summary")]
        public string PsDescription { get; set; }
        [Display(Name = "Skill IQ")]
        [MaxValue(300, "Value can't be higher than 300")]
        public int PsSkillIqScore { get; set; }
        [Display(Name = "Name")]
        public string PsChartFilePath { get; set; } = "NoChart.png";
        [Display(Name = "Skill IQ Level")]
        public SkillLevel PsSkillLevel { get; set; }
    }
}
