using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Portfolio.Core
{
    public class Certificate
    {
        public int Id { get; set; }
        public string CertificateName { get; set; }
        public string CertificateDescription { get; set; }
        public string CertificateFileName { get; set; } = "NoCertificate.pdf";
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public CourseCategorie CourseCategorie { get; set; }
        public bool Done { get; set; }
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Text)]
        public DateTime DateCompleted { get; set; } = DateTime.Now;
    }
}
