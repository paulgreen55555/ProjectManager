using System.Data.Entity;
using ProjectManager.Data.Models;

namespace ProjectManager.Data.DataAccess
{
    class DataContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

    }
}
