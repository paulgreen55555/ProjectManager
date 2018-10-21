using System.Data.Entity;
using ProjectManager.Data.Entities;

namespace ProjectManager.Data.DataAccess
{
    public class DataContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }


        static DataContext()
        {
            Database.SetInitializer<DataContext>(new DbInitializer());
        }
        public DataContext(string connectionString)
            : base(connectionString)
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance; 
        }
    }
}
