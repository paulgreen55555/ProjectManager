using System.Collections.Generic;
using ProjectManager.Entities.DTO;

namespace ProjectManager.BusinessLogic.Interfaces
{
    public interface IProjectService
    {
        ProjectDTO GetProject(int id);
        List<ProjectDTO> GetProjectList();

        void AddProject(ProjectDTO project);

        void UpdateProject(ProjectDTO project);

        void DeleteProject(int id);

    }
}
