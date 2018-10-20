using System;
using ProjectManager.Data.DataAccess;
using ProjectManager.Data.Interfaces;

using ProjectManager.Data.Entities;

namespace ProjectManager.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataContext db;
        private ProjectRepository pojectRepository;
 
        public UnitOfWork(string connectionString)
        {
            db = new DataContext(connectionString);
        }
        public IRepository<Project> Projects
        {
            get
            {
                if (pojectRepository == null)
                    pojectRepository = new ProjectRepository(db);
                return pojectRepository;
            } 
        }
 
        public void Save()
        {
            db.SaveChanges();
        }
 
        private bool disposed = false;
 
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    
    }
}
