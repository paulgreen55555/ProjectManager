using System.Web.Mvc;
using ProjectManager.BusinessLogic.Services;

namespace ProjectManager.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";


            

            return View();
        }
    }
}
