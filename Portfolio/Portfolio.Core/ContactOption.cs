using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core
{
    public enum ContactOption
    {
        [Display(Name="Just wanted to check if it works...")]
        CheckIfWorks,
        [Display(Name ="I would like access to your CMS")]
        AccessToCMS,
        [Display(Name ="I would like to talk to you about a job offer")]
        JobOffer,
        [Display(Name ="I would like to collaborate on a project")]
        ProjectCollaboration,
        [Display(Name ="You seem nice! Let's grab a coffee")]
        GrabACoffee
    }
}
