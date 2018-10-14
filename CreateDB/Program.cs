using System;
using System.Linq;
using ProjectManager.Data.DataAccess;

namespace CreateDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataContext("ProjectManagerDb"))
            {
                var projects = db.Projects.ToList();
                Console.WriteLine(projects.Count());
            }
            Console.ReadKey();
        }
    }
}
