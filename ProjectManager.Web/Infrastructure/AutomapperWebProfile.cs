using AutoMapper;
using ProjectManager.BusinessLogic.DTO;
using ProjectManager.Web.Models;

namespace ProjectManager.Web.Infrastructure
{
    public class AutomapperWebProfile : Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<ProjectViewModel,ProjectDTO>();
            CreateMap<ProjectDTO, ProjectViewModel>();
        }

        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutomapperWebProfile>();
            });
        }
    }
}