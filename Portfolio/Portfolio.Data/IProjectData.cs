using Portfolio.Core;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface IProjectData
    {
        IEnumerable<PersonalProject> GetAllPersonalProjects();
        IEnumerable<FreeCodeCampProject> GetFreeCodeCampRWDProjects();

        IEnumerable<PPTag> GetTagsPerPersonalProject(int projectId);

        PPTag GetPPTagsByPersonalProjectId(int projectId);

        PersonalProject GetPersonalProjectById(int projectId);

        FreeCodeCampProject GetFreeCodeCampProjectById(int fccProjectId);

        PersonalProject UpdatePersonalProject(PersonalProject updatedProject);

        PersonalProject AddPersonalProject(PersonalProject newProject);

        IEnumerable<PPTag> GetAllTagsWithProject();

        IEnumerable<PPTag> GetPPTags();
        PPTag AddTags(PPTag newPPTag);
        PPTag UpdateTags(PPTag updatedPPTag);

        int Commit();

    }
}
