using ProjectManager.BusinessLogic.Models;
using ProjectManager.Data.Interfaces;

namespace ProjectManager.BusinessLogic.Services
{
    public class ProjectService : IProjectService
    {
        public IProjectService projectService = new Data.Services.ProjectService();

        public Project GetProjectById()
        {
           return projectService.GetProjectById();
        }
    }
}
