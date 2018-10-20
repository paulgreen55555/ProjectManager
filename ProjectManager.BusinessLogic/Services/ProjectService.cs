using ProjectManager.BusinessLogic.DTO;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.Data.Entities;
using ProjectManager.Data.Interfaces;


namespace ProjectManager.BusinessLogic.Services
{
    public class ProjectService : IProjectService
    {
        private IUnitOfWork db { get; set; }

        public ProjectService(IUnitOfWork uow)
        {
            db = uow;
        }

        public ProjectDTO GetProject(int id)
        {
            Project project = db.Projects.Get(id);
            ProjectDTO projectDto = new ProjectDTO();

            Mapping.Mapping.Map(project, projectDto);

            return projectDto;
        }

        public System.Collections.Generic.IEnumerable<ProjectDTO> GetProjectList(int?[] ids)
        {
            throw new System.NotImplementedException();
        }
    }
}
