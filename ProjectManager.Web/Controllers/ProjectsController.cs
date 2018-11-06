using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.Entities.DTO;
using ProjectManager.Entities.ViewModels;
using System.Web.Script.Serialization;

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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
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
            return new JavaScriptSerializer().Serialize(projectViewModel); ;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
