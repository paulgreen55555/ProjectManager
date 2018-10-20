using Ninject.Modules;
using ProjectManager.BusinessLogic.Interfaces;
using ProjectManager.BusinessLogic.Services;

namespace ProjectManager.Web.Util
{
    public class ProjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProjectService>().To<ProjectService>();
        }
    }
}