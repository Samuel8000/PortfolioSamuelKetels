using Microsoft.EntityFrameworkCore;
using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Data
{
    public interface ICertificateData
    {
        IEnumerable<Certificate> GetAllCertificates();
    }

    public class SqlCertificateData : ICertificateData
    {
        private readonly PortfolioDbContext _context;

        public SqlCertificateData(PortfolioDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Certificate> GetAllCertificates()
        {


            return _context.Certificates
                  .Include(c => c.Skill)
                 .OrderBy(c => c.SkillId);
             


        }
    }

    public class InMemoryCertificateData : ICertificateData
    {
        List<Certificate> certificates;

        public InMemoryCertificateData()
        {
            certificates = new List<Certificate>()
            {
                new Certificate { Id = 1, CertificateName = "HTML5 Fundamentals", SkillId = 1},
                new Certificate {Id = 2, CertificateName = "Introduction to CSS", SkillId = 2}
            };
        }
        public IEnumerable<Certificate> GetAllCertificates()
        {
            return certificates.OrderBy(c => c.SkillId);
        }
    }
}
