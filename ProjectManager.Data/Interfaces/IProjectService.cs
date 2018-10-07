using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Data.Interfaces
{
    public interface IProjectService
    {
        BusinessLogic.Models.Project GetProjectById();
    }
}
