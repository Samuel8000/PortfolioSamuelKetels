using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core
{
    public enum CourseCategorie
    {
        [Display(Name ="Back End")]
        Backend,
        [Display(Name ="Front End")]
        Frontend,
        [Display(Name ="Development Tools")]
        Tools,
        [Display(Name="Portfolio Projects")]
        Project
    }
}
