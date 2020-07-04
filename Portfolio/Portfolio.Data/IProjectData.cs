using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio.Data
{
    public interface IProjectData
    {
        IEnumerable<Project> GetAllProjects();

        Project UpdateProject(Project updatedProject);

        Project AddProject(Project newProject);

        int Commit();

    }

    public class SqlProjectData : IProjectData
    {
        private readonly PortfolioDbContext _context;

        public SqlProjectData(PortfolioDbContext context)
        {
            _context = context;
        }

        public Project AddProject(Project newProject)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _context.Projects.OrderBy(p => p.DateCompleted);
        }

        public Project UpdateProject(Project updatedProject)
        {
            throw new NotImplementedException();
        }
    }
}
