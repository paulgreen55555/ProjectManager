using System;
using ProjectManager.Entities.Enums;

namespace ProjectManager.Entities.DataEntities
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ProjectStatus ProjectStatus { get; set; }

    }
}
