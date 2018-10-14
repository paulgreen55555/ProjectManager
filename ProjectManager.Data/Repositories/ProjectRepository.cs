using System.Collections.Generic;
using System.Data.Entity;
using ProjectManager.Data.DataAccess;
using ProjectManager.Data.Interfaces;
using ProjectManager.Data.Entities;

namespace ProjectManager.Data.Repositories
{
    class ProjectRepository : IRepository<Project>
    {
        private DataContext db;
        public ProjectRepository(DataContext context)
        {
            this.db = context;
        }
        public IEnumerable<Project> GetAll()
        {
            return db.Projects;
        }
 
        public Project Get(int id)
        {
            return db.Projects.Find(id);
        }
 
        public void Create(Project item)
        {
            db.Projects.Add(item);
        }
 
        public void Update(Project item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
 
        public void Delete(int id)
        {
            Project user = db.Projects.Find(id);
            if (user != null)
                db.Projects.Remove(user);
        }
    }
}
