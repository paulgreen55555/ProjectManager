using AutoMapper;
using ProjectManager.Entities.DTO;
using ProjectManager.Entities.ViewModels;

namespace ProjectManager.Mapping
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