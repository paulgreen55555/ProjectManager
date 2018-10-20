using AutoMapper;
using ProjectManager.BusinessLogic.Infrastructure;
using ProjectManager.Web.Infrastructure;

namespace ProjectManager.Mapping
{
    public static class Mapping
    {
        public static void Map(object typeIn, object typeOut)
        {
            Mapper.Map(typeIn, typeOut);
        }

        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AutomapperBLProfile>();
                cfg.AddProfile<AutomapperWebProfile>();
            });
        }
    }
}
