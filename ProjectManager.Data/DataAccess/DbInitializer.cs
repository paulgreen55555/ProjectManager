using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManager.Data.Entities;

namespace ProjectManager.Data.DataAccess
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext db)
        {
            db.Projects.Add(new Project{ProjectId = 1, Name = "Project1", Discription = "Proj1", OwnerId = 1});
            db.Projects.Add(new Project { ProjectId = 2, Name = "Project2", Discription = "Proj2", OwnerId = 2 });
            db.SaveChanges();
        }
    }

}
