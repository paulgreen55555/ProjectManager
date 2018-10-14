using System;
using ProjectManager.Data.Entities;

namespace ProjectManager.Data.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<Project> Projects { get; }
        void Save();
    }

}
