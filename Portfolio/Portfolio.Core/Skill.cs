namespace Portfolio.Core
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public string LogoFilePath { get; set; }
        public string PsDescription { get; set; }
        public int PsSkillIqScore { get; set; }
        public string PsChartFilePath { get; set; }
        public SkillLevel PsSkillLevel { get; set; }
    }
}
