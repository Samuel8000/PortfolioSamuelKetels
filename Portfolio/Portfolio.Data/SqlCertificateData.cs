using Microsoft.EntityFrameworkCore;
using Portfolio.Core;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Data
{
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
}
