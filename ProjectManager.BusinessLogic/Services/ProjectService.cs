using System;
using ProjectManager.BusinessLogic.Infrastructure;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.Entities.DTO;
using ProjectManager.Data.Interfaces;
using ProjectManager.Entities.DataEntities;


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
            if (project == null)
            {
                throw new ValidationException(String.Format("Project with id={0} doesn't exists.",id), "");
            }

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
