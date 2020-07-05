using Portfolio.Core;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface IProjectData
    {
        IEnumerable<PersonalProject> GetAllPersonalProjects();
        IEnumerable<FreeCodeCampProject> GetFreeCodeCampRWDProjects();

        PersonalProject UpdateProject(PersonalProject updatedProject);

        PersonalProject AddProject(PersonalProject newProject);

        int Commit();

    }
}
