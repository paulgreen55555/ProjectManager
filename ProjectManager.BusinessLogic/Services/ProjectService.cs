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
                throw new ValidationException(String.Format("Project with id={0} doesn't exists.", id), "");
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

        public void AddProject(ProjectDTO project)
        {
            try
            {
                Project projectDb = new Project();
                Mapping.Mapping.Map(project, projectDb);
                db.Projects.Create(projectDb);
                db.Save();

            }
            catch (Exception e)
            {
                throw new ValidationException("Can't add to Data Base.", "");
            }

        }

        public void UpdateProject(ProjectDTO project)
        {
            ProjectDTO oldProject = GetProject(project.ProjectId);

            if (oldProject != null)
            {
                Project newProject = new Project();
                oldProject = project;
                Mapping.Mapping.Map(oldProject, newProject);
                db.Projects.Update(newProject);
                db.Save();
            }
            else
            {
                throw new ValidationException("Can't edit project.", "");
            }

        }

        public void DeleteProject(int id)
        {
            throw new NotImplementedException();
        }
    }
}
