using System;
using System.Collections.Generic;
using ProjectManager.BusinessLogic.Models;


namespace ProjectManager.BusinessLogic.Interfaces
{
    interface IProject
    {
        Project GetProjectById(int id);
        List<Project> GetProjectList();

    }
}
