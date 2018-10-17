using AutoMapper;
using ProjectManager.BusinessLogic.DTO;
using ProjectManager.Data.Entities;

namespace ProjectManager.BusinessLogic.Mapping
{
    public static class ProjectMapper
    {
        public static ProjectDTO ProjectToBussines(Project project)
        {
           Mapper.Initialize(cfg=>cfg.CreateMap<Project, ProjectDTO>());
           return Mapper.Map<Project, ProjectDTO>(project);
        }


    }
}
