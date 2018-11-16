using System;
using System.Data.Entity;
using ProjectManager.Entities.DataEntities;

namespace ProjectManager.Data.DataAccess
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext db)
        {
            db.Projects.Add(new Project
            {
                ProjectId = 2,
                Name = "Project2",
                Description = "Proj2",
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                ProjectStatus = 0
            });

            db.Projects.Add(new Project
            {
                ProjectId = 3,
                Name = "Project3",
                Description = "Proj3",
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                ProjectStatus = 0
            });
            db.SaveChanges();
        }
    }

}
