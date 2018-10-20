using AutoMapper;
using ProjectManager.Data.Entities;
using ProjectManager.BusinessLogic.DTO;

namespace ProjectManager.BusinessLogic.Infrastructure
{
    public class AutomapperBLProfile : Profile
    {
        public AutomapperBLProfile()
        {
            CreateMap<Project,ProjectDTO>();
            CreateMap<ProjectDTO, Project>();
        }

        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutomapperBLProfile>();
            });
        }
    }
}
