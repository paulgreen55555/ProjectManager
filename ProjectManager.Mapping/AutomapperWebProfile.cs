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
                    src => DateTime.ParseExact(src.StartDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)))
                .ForMember("EndDate", opt => opt.MapFrom(
                    src => DateTime.ParseExact(src.EndDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)));
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