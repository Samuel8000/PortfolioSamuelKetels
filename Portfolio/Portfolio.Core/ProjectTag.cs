using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core
{
    public enum ProjectTag
    {
        [Display(Name ="C#")]
        CSharp,
        HTML5,
        CSS3,
        JavaScript,
        jQuery,
        [Display(Name ="ASP.NET")]
        AspNet,
        [Display(Name =".NET Core")]
        NetCore
    }
}
