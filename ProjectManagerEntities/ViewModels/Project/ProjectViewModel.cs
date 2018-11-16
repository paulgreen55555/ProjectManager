using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManager.Entities.Enums;

namespace ProjectManager.Entities.ViewModels.Project

{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CloseDate { get; set; }

        public ProjectStatus ProjectStatus { get; set; }
    }
}