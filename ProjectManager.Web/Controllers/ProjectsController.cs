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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
