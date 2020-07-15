using Microsoft.EntityFrameworkCore;
using Portfolio.Core;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Data
{
    public class SqlAboutMe : IAboutMeData
    {
        private readonly PortfolioDbContext _context;

        public SqlAboutMe(PortfolioDbContext context)
        {
            _context = context;
        }

        public AboutMeInfo AddNewInfo(AboutMeInfo newInfo)
        {
            _context.Add(newInfo);
            return newInfo;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public AboutMeInfo EditInfo(AboutMeInfo updatedInfo)
        {
            var entity = _context.AboutMe.Attach(updatedInfo);
            entity.State = EntityState.Modified;
            return updatedInfo;
        }

        public IEnumerable<AboutMeInfo> GetAllEntries()
        {
            return _context.AboutMe.OrderByDescending(a => a.DateUpdated);
        }

        public AboutMeInfo GetAboutMeInfoById(int infoId)
        {
            return _context.AboutMe.Find(infoId);
        }

        public AboutMeInfo GetAboutMeInfoLive()
        {
            return _context.AboutMe.FirstOrDefault(a => a.Live == true);
        }
    }
}
