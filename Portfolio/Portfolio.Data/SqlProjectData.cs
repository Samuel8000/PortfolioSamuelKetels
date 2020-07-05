using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Data
{
    public class SqlProjectData : IProjectData
    {
        private readonly PortfolioDbContext _context;

        public SqlProjectData(PortfolioDbContext context)
        {
            _context = context;
        }

        public PersonalProject AddProject(PersonalProject newProject)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonalProject> GetAllPersonalProjects()
        {
            return _context.Projects.OrderBy(p => p.DateCompleted);
        }

        public IEnumerable<FreeCodeCampProject> GetFreeCodeCampRWDProjects()
        {
            return _context.FccProjects.Where(f => f.FccCategory == FccCategory.ResponsiveWebDesign);
        }

        public PersonalProject UpdateProject(PersonalProject updatedProject)
        {
            throw new NotImplementedException();
        }
    }
}
