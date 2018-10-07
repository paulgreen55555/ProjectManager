using System;
using System.Collections.Generic;
using ProjectManager.Data.Models;

namespace ProjectManager.Data.Actions
{
    public class ProjectAction
    {
        public static Project GetProjectById()
        {
            return new Project()
            {

                    ProjectId = 1,
                    Name = "Project1",
                    Discription = "Test Projet1",
                    StartDate = new DateTime(),
                    EndDate = new DateTime(),
                    CloseDate = new DateTime(),
                    OwnerId = 1,
                    StaffList = new List<Staff>()
                    {
                        new Staff()
                        {
                            LastName = "Ivan",
                            FirstName = "Ivanov"
                        },
                        new Staff()
                        {
                            LastName = "Petr",
                            FirstName = "Petrov"
                        }
                    }
                
            };

        }
    }
}
