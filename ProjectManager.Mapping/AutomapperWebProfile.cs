using AutoMapper;
using ProjectManager.Entities.DTO;
using ProjectManager.Entities.ViewModels;
using ProjectManager.Entities.ViewModels.Project;

namespace ProjectManager.Mapping
{
    public class AutomapperWebProfile : Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<ProjectViewModel,ProjectDTO>();
            CreateMap<ProjectDTO, ProjectViewModel>();

            CreateMap<ProjectDTO, ProjectAddViewModel>();
            CreateMap<ProjectAddViewModel, ProjectDTO>();
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