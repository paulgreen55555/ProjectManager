using AutoMapper;
using ProjectManager.Entities.DataEntities;
using ProjectManager.Entities.DTO;

namespace ProjectManager.Mapping
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
