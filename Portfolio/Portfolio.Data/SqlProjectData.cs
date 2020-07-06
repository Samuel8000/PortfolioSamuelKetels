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
            return _context.SaveChanges();
        }

        public IEnumerable<PersonalProject> GetAllPersonalProjects()
        {
            return _context.Projects.OrderBy(p => p.DateCompleted);
        }

        public PersonalProject GetPersonalProjectById(int projectId)
        {
            return _context.Projects.Find(projectId);
        }

        public PersonalProject UpdateProject(PersonalProject updatedProject)
        {
            throw new NotImplementedException();
        }

        public FreeCodeCampProject GetFreeCodeCampProjectById(int fccProjectId)
        {
            return _context.FccProjects.Find(fccProjectId);
        }

        public IEnumerable<FreeCodeCampProject> GetFreeCodeCampRWDProjects()
        {
            return _context.FccProjects.Where(f => f.FccCategory == FccCategory.ResponsiveWebDesign);
        }

    }
}
