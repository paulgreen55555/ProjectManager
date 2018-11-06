using System;
using ProjectManager.Entities.DataEntities;

namespace ProjectManager.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Project> Projects { get; }
        void Save();
    }

}
