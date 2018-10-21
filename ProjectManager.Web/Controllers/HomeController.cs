using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.Web.Models;
using ProjectManager.BusinessLogic.DTO;

namespace ProjectManager.Web.Controllers
{
    public class HomeController : Controller
    {
        IProjectService projectService;

        public HomeController(IProjectService projSv)
        {
            projectService = projSv;
        }

        public ActionResult Index()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            try
            {
                ProjectDTO projectDto = projectService.GetProject(5);
                Mapping.Mapping.Map(projectDto, projectViewModel);
            }
            catch (ValidationException ex)
            {
                return Content(ex.Message);
            }
            

            

            ViewBag.Title = "Home Page";


            return View(projectViewModel);
        }
    }
}
