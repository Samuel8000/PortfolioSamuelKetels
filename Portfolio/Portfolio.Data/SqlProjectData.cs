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
            _context.Projects.Add(newProject);
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


        #region FCC
        public FreeCodeCampProject GetFreeCodeCampProjectById(int fccProjectId)
        {
            return _context.FccProjects.Find(fccProjectId);
        }

        public IEnumerable<FreeCodeCampProject> GetFreeCodeCampProjects(FccCategory fccCategory)
        {
            return _context.FccProjects.Where(f => f.FccCategory == fccCategory);
        }

        public FreeCodeCampProject AddFccProject(FreeCodeCampProject newProject)
        {
            _context.FccProjects.Add(newProject);
            return newProject;
        }

        public FreeCodeCampProject UpdateFccProject(FreeCodeCampProject updatedProject)
        {
            var entity = _context.FccProjects.Attach(updatedProject);
            entity.State = EntityState.Modified;
            return updatedProject;
        }

        #endregion


        #region Tags
        public IEnumerable<PPTag> GetTagsPerPersonalProject(int projectId)
        {
            return _context.PersonalProjectTags.Where(p => p.PersonalProjectId == projectId);
        }

        public PPTag GetPPTagsByPersonalProjectId(int projectId)
        {
            return _context.PersonalProjectTags.FirstOrDefault(t => t.PersonalProjectId == projectId);
        }

        public PPTag AddTags(PPTag newPPTag)
        {
            _context.PersonalProjectTags.Add(newPPTag);
            return newPPTag;
        }

        public PPTag UpdateTags(PPTag updatedPPTag)
        {
            var entity = _context.PersonalProjectTags.Attach(updatedPPTag);
            entity.State = EntityState.Modified;
            return updatedPPTag;
        }

        public IEnumerable<PPTag> GetAllTagsWithProject()
        {
            return _context.PersonalProjectTags
                .Include(p => p.PersonalProject);
        }

        public IEnumerable<PPTag> GetPPTags()
        {
            return _context.PersonalProjectTags;
        }

        #endregion
    }
}
