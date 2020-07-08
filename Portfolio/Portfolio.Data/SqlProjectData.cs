using Microsoft.EntityFrameworkCore;
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

        public PersonalProject AddPersonalProject(PersonalProject newProject)
        {
            _context.Add(newProject);
            return newProject;
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

        public PersonalProject UpdatePersonalProject(PersonalProject updatedProject)
        {
            var entity = _context.Projects.Attach(updatedProject);
            entity.State = EntityState.Modified;
            return updatedProject;
        }

        public FreeCodeCampProject GetFreeCodeCampProjectById(int fccProjectId)
        {
            return _context.FccProjects.Find(fccProjectId);
        }

        public IEnumerable<FreeCodeCampProject> GetFreeCodeCampRWDProjects()
        {
            return _context.FccProjects.Where(f => f.FccCategory == FccCategory.ResponsiveWebDesign);
        }

        public IEnumerable<PPTag> GetTagsPerPersonalProject(int projectId)
        {
            return _context.PersonalProjectTags.Where(p => p.PersonalProjectId == projectId);
        }

        public PPTag GetPPTagsByPersonalProjectId(int projectId)
        {
            return _context.PersonalProjectTags.Find(projectId);
        }

        public PPTag AddTags(PPTag newPPTag)
        {
            _context.Add(newPPTag);
            return newPPTag;
        }

        public PPTag UpdateTags(PPTag updatedPPTag)
        {
            var entity = _context.PersonalProjectTags.Attach(updatedPPTag);
            entity.State = EntityState.Modified;
            return updatedPPTag;
        }

        public IEnumerable<PPTag> GetAllTagsWithProject(int projectId)
        {
            return _context.PersonalProjectTags
                .Include(p => p.PersonalProject)
                .Where(p => p.PersonalProjectId == projectId);
        }
    }
}
