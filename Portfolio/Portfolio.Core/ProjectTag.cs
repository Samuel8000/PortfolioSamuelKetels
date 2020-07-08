using System.ComponentModel.DataAnnotations;

namespace Portfolio.Core
{
    public enum ProjectTag
    {
        [Display(Name ="Pick a tag")]
        PickOne,
        [Display(Name ="C#")]
        CSharp,
        [Display(Name ="HTML5")]
        HTML5,
        [Display(Name = "CSS3")]
        CSS3,
        [Display(Name = "JavaScript")]
        JavaScript,
        [Display(Name = "jQuery")]
        jQuery,
        [Display(Name ="ASP.NET")]
        AspNet,
        [Display(Name =".NET Core")]
        NetCore,
        [Display(Name = "Sass")]
        Sass
    }
}
