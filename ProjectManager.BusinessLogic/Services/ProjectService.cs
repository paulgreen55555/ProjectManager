using ProjectManager.BusinessLogic.DTO;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.BusinessLogic.Mapping;
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
            return ProjectMapper.ProjectToBussines(db.Projects.Get(id));
        }

        public System.Collections.Generic.IEnumerable<ProjectDTO> GetProjectList(int?[] ids)
        {
            throw new System.NotImplementedException();
        }
    }
}
