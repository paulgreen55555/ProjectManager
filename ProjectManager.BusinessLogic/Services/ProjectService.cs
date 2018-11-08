using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<ProjectDTO> GetProjectList()
        {

            List<ProjectDTO> resultList = new List<ProjectDTO>();
            IEnumerable<Project> dbList = db.Projects.GetAll();


            foreach (var elProject in dbList)
            {
                ProjectDTO projectDtotemp = new ProjectDTO();

                Mapping.Mapping.Map(elProject, projectDtotemp);
                resultList.Add(projectDtotemp);

            }

            return resultList;
        }

        public void AddProject()
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProect(int id)
        {
            throw new NotImplementedException();
        }
    }
}
