using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.Entities.DTO;
using ProjectManager.Entities.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjectManager.Entities.ViewModels.Project;

namespace ProjectManager.Web.Controllers
{
    public class ProjectsController : ApiController
    {
        IProjectService projectService;

        public ProjectsController(IProjectService projSv)
        {
            projectService = projSv;
        }

        public IHttpActionResult Get()
        {
            List<string> result = new List<string>();

            List<ProjectViewModel> resultList = new List<ProjectViewModel>();
            List<ProjectViewModel> projectViewModels = new List<ProjectViewModel>();


            List<JObject> jObjectList = new List<JObject>();
            try
            {
                List<ProjectDTO> projectDtoList = projectService.GetProjectList();

                if (projectDtoList.Count == 0)
                {
                    return NotFound();
                }

                foreach (var elProject in projectDtoList)
                {
                    ProjectViewModel projectViewModelTemp = new ProjectViewModel();

                    Mapping.Mapping.Map(elProject, projectViewModelTemp);
                    resultList.Add(projectViewModelTemp);

                }

                foreach (var el in resultList)
                {
                    jObjectList.Add(JObject.Parse(JsonConvert.SerializeObject(el)));
                }
                

            }
            catch (ValidationException ex)
            {

            }

            return Ok(jObjectList);
        }

        public IHttpActionResult Get(int id)
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            try
            {
                ProjectDTO projectDto = projectService.GetProject(id);
                Mapping.Mapping.Map(projectDto, projectViewModel);
            }
            catch (ValidationException ex)
            {

            }

           var jObject = JObject.Parse(JsonConvert.SerializeObject(projectViewModel));

            return Ok(jObject);
        }

        [HttpPost]
        public IHttpActionResult Post(ProjectAddViewModel project )
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            try
            {
                ProjectDTO projectDto = new ProjectDTO();
                Mapping.Mapping.Map(project, projectDto);
                projectService.AddProject(projectDto);
            }
            catch (ValidationException e)
            {
                
            }
           
            return Ok();
        }

        public IHttpActionResult Put(ProjectViewModel project)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            try
            {
                ProjectDTO projectDto = new ProjectDTO();
                Mapping.Mapping.Map(project, projectDto);
                projectService.UpdateProject(projectDto);
            }
            catch (ValidationException e)
            {

            }

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            projectService.DeleteProject(id);
            return Ok();
        }

    }
}
