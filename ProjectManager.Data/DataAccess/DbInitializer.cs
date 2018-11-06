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
                Discription = "Proj2",
                OwnerId = 1,
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                CloseDate = DateTime.Now
            });

            db.Projects.Add(new Project
            {
                ProjectId = 3,
                Name = "Project3",
                Discription = "Proj3",
                OwnerId = 1,
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                CloseDate = DateTime.Now
            });
            db.SaveChanges();
        }
    }

}
