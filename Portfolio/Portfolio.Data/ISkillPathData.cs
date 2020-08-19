using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface ISkillPathData
    {
        SkillPath AddNewSkillPath(SkillPath path);
        int CommitSP();
    }
    public class SqlSkillPathData : ISkillPathData
    {
        private readonly PortfolioDbContext _context;

        public SqlSkillPathData(PortfolioDbContext context)
        {
            _context = context;
        }
        public SkillPath AddNewSkillPath(SkillPath path)
        {
            _context.SkillPaths.Add(path);
            return path;
        }

        public int CommitSP()
        {
            return _context.SaveChanges();
        }
    }
}
