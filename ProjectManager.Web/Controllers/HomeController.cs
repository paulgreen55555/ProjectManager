using System.Web.Mvc;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.Web.Models;
using ProjectManager.BusinessLogic.DTO;

namespace ProjectManager.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        IProjectService projectService;

        public HomeController(IProjectService projSv)
        {
            projectService = projSv;
        }

        public ActionResult Index()
        {
            ProjectDTO projectDto = projectService.GetProject(1);
            ProjectViewModel projectViewModel = new ProjectViewModel();

            Mapping.Mapping.Map(projectDto, projectViewModel);

            ViewBag.Title = "Home Page";


            return View(projectViewModel);
        }
    }
}
