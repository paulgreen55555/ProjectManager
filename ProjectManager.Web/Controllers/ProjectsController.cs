using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.Entities.DTO;
using ProjectManager.Entities.ViewModels;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProjectManager.Web.Controllers
{
    public class ProjectsController : ApiController
    {
        IProjectService projectService;

        public ProjectsController(IProjectService projSv)
        {
            projectService = projSv;
        }

        // GET api/values
        public IHttpActionResult Get()
        {
            List<string> result = new List<string>();

            List<ProjectViewModel> resultList = new List<ProjectViewModel>();
            List<ProjectViewModel> projectViewModels = new List<ProjectViewModel>();


            List<JObject> jObjectList = new List<JObject>();
            try
            {
                List<ProjectDTO> projectDtoList = projectService.GetProjectList();

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

        // GET api/values/5
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

    }
}
