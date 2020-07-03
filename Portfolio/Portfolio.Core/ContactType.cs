using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core
{
    public enum ContactType
    {
        
        Employer,
        Recruiter,
        [Display(Name = "Project Manager")]
        ProjectManager,
        [Display(Name = "Just Interested")]
        JustInterested
    }
}
