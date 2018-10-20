using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.BusinessLogic.Mapping
{
    public static class ProjectMapping
    {
        public static void Map(object typeIn, object typeOut)
        {
            AutoMapper.Mapper.Map(typeIn,typeOut);
        }
    }
}
