using System;
using ProjectManager.Data.Entities;

namespace ProjectManager.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Project> Projects { get; }
        void Save();
    }

}
