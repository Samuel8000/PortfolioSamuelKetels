﻿using Microsoft.EntityFrameworkCore;
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

        public Certificate GetCertificateById(int certificateId)
        {
            return _context.Certificates.Find(certificateId);
        }

        public IEnumerable<Certificate> GetCertificatesBySkill(int skillId)
        {
            return _context.Certificates.Where(c => c.SkillId == skillId);
        }
    }
}