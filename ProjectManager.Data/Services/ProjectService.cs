using ProjectManager.Data.Actions;
using ProjectManager.Data.Interfaces;
using ProjectManager.Data.Translators;

namespace ProjectManager.Data.Services
{
    public class ProjectService : IProjectService 
    {
        public BusinessLogic.Models.Project GetProjectById()
        {
            return ProjectTranslator.ToBusiness(ProjectAction.GetProjectById());
        }
    }
}
