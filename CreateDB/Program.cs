using System;
using System.Data.Entity;
using System.Linq;
using ProjectManager.Data.DataAccess;
using ProjectManager.Data.Entities;

namespace CreateDB
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var db = new DataContext("ProjectManagerDb"))
            {
                var projects = db.Projects.ToList();
                db.Projects.Add(new Project
                {
                    ProjectId = 1,
                    Name = "Project1",
                    Discription = "Proj1",
                    OwnerId = 1,
                    EndDate = DateTime.Now,
                    StartDate = DateTime.Now,
                    CloseDate = DateTime.Now
                });
                db.SaveChanges();
                Console.WriteLine(projects.Count());
            }
            Console.ReadKey();
        }
    }
}
