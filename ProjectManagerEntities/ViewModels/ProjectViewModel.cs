using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManager.Entities.ViewModels

{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public string Discription { get; set; }

        public int OwnerId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CloseDate { get; set; }
    }
}