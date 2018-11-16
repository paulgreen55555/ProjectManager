using System;
using System.Globalization;
using AutoMapper;
using ProjectManager.Entities.DTO;
using ProjectManager.Entities.ViewModels.Project;

namespace ProjectManager.Mapping
{
    public class AutomapperWebProfile : Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<ProjectViewModel,ProjectDTO>();
            CreateMap<ProjectDTO, ProjectViewModel>();

            CreateMap<ProjectAddViewModel, ProjectDTO>()
                .ForMember("StartDate", opt => opt.MapFrom(
                    src => DateTime.ParseExact(src.StartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)))
                .ForMember("EndDate", opt => opt.MapFrom(
                    src => DateTime.ParseExact(src.StartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)));
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