using System.Collections.Generic;
using ProjectManager.Entities.DTO;

namespace ProjectManager.BusinessLogic.Interfaces
{
    public interface IProjectService
    {
        ProjectDTO GetProject(int id);
        List<ProjectDTO> GetProjectList();

        void AddProject();

        void UpdateProject(int id);

        void DeleteProect(int id);

    }
}
