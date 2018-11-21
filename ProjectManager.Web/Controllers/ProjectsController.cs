using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.Entities.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjectManager.Entities.ViewModels.Project;

namespace ProjectManager.Web.Controllers
{
    public class ProjectsController : ApiController
    {
        private readonly  IProjectService _projectService;

        public ProjectsController(IProjectService projSv)
        {
            _projectService = projSv;
        }

        public IHttpActionResult Get()
        {

            List<ProjectViewModel> resultList = new List<ProjectViewModel>();

            List<JObject> jObjectList = new List<JObject>();
            try
            {
                List<ProjectDTO> projectDtoList = _projectService.GetProjectList();

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
                ProjectDTO projectDto = _projectService.GetProject(id);
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
                _projectService.AddProject(projectDto);
            }
            catch (ValidationException e)
            {
                
            }
           
            return Ok();
        }

        public IHttpActionResult Put(ProjectEditViewModel project)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            try
            {
                ProjectDTO projectDto = new ProjectDTO();
                Mapping.Mapping.Map(project, projectDto);
                _projectService.UpdateProject(projectDto);
            }
            catch (ValidationException e)
            {

            }

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            _projectService.DeleteProject(id);
            return Ok();
        }

    }
}
