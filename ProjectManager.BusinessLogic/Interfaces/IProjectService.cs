using System.Collections.Generic;
using ProjectManager.BusinessLogic.DTO;

namespace ProjectManager.BusinessLogic.Interfaces
{
    public interface IProjectService
    {
        ProjectDTO GetProject(int id);
        IEnumerable<ProjectDTO> GetProjectList(int?[] ids);

    }
}
